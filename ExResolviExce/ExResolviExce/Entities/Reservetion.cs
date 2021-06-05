using System;
using ExResolviExce.Entities.Exceptions;

namespace ExResolviExce.Entities
{
    class Reservetion
    {
        public int RoomNumber { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime CheckIn { get; set; }

        public Reservetion()
        {

        }

        public Reservetion(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            //Chamada de erro no atributo

            if (checkIn >= checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;

        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException (" Reservetion dates for update must be future dates.");
            }
            if (checkIn >= checkOut)
            {
                throw new DomainException (" Check-out date must be after check-in date");
            }
          

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Reservation: Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                +", "
                + " check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nigths.";

        }
    }
}
