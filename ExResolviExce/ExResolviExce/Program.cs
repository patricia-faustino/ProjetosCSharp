using System;
using ExResolviExce.Entities;
using ExResolviExce.Entities.Exceptions;

namespace ExResolviExce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservetion reservetion = new Reservetion(roomNumber, checkIn, checkOut);
            Console.WriteLine(reservetion);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());


            try
            {

                reservetion.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservetion);
            }
            catch (DomainException e) // nao esquecer de chamar a classe da excecao
            {
                Console.WriteLine(" Error in reservetion " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(" Unexped Error " + e.Message);
            }



        }
    }
}
