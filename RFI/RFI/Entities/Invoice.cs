using System.Globalization;
namespace RFI.Entities
{
    class Invoice
    {
          public double BasicPayment { get; set; }
           public double Tax { get; set; }

           public Invoice(double basicPayment, double tax)
           {
               BasicPayment = basicPayment;
               Tax = tax;
           }
           public double TotalValue { get 
               { return BasicPayment + Tax; } }

           public override string ToString()
           {
               return "Basic payment: " + BasicPayment.ToString("F2",CultureInfo.InvariantCulture)
                   + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                   + "\nTotal payment: " + TotalValue.ToString("F2", CultureInfo.InvariantCulture);
           }
    }
}
