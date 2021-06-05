using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixInteracao.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercetage = 0.02;
        private const double MonthlyInterest = 0.01;

    
        public double PaymentFee(double amount)
        {
            return amount * FeePercetage;
        }

        public double Interest(double amount, int months)
        {
            return amount * months * MonthlyInterest;
        }
    }
}
