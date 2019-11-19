using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeHotel.Entities
{
    class Reservation
    {
        public int roomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }
           
        public Reservation(int roomnumber, DateTime checkin, DateTime checkout)
        {
            roomNumber = roomnumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }
        
        public void updateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room: "
                    + roomNumber
                    + ", check-in: "
                    + Checkin.ToString("dd/MM/yyyy")
                    + ", check-out: "
                    + Checkout.ToString("dd/MM/yyyy")
                    + ", "
                    + Duration() 
                    + " nights.";
        }
    }
}
