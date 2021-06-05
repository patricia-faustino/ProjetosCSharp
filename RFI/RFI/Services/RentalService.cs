using System;
using RFI.Entities;

namespace RFI.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
          public double PricePerDay { get; set; }
          private ITaxService _taxService;

          public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
          {
              PricePerHour = pricePerHour;
              PricePerDay = pricePerDay;
              _taxService = taxService;
          }
          public void ProcessInvoice(CarRental carRental)
          {
              TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
              double basicPayment = 0.0;

              if (duration.TotalHours <= 12.0)
              {
                  basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;

              }
              else
              {
                  basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
              }
              double tax = _taxService.Tax(basicPayment);

              carRental.Invoice = new Invoice(basicPayment, tax);

          }
   

    }
}
