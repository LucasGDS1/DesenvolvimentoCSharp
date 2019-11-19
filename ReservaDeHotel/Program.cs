using System;
using ReservaDeHotel.Entities;

namespace ReservaDeHotel
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                if (checkout < checkin)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    Reservation reserva = new Reservation(room, checkin, checkout);
                    Console.WriteLine("Resernvation: " + reserva);

                    Console.WriteLine();
                    Console.WriteLine("Enter data to update the reservation: ");
                    Console.Write("Check-in Date (dd/MM/yyyy): ");
                    checkin = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out Date (dd/MM/yyyy): ");
                    checkout = DateTime.Parse(Console.ReadLine());

                    reserva.updateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reserva);
                }
            } catch(Exception e)
            {
                Console.WriteLine("Execeção: " + e.Message);
            }
        }
    }
}
