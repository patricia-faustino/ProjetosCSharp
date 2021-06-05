using System;
using ExFixInteracao.Entities;

namespace ExFixInteracao.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinepaymentservice;

        public ContractService(IOnlinePaymentService onlinepaymentservice)
        {
            _onlinepaymentservice = onlinepaymentservice;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinepaymentservice.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinepaymentservice.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));

            }

        }
    }
}
