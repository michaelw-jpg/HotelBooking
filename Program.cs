using System;

namespace HotelBooking
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Booking bokning = new Booking("Erik", 9, DateTime.Now);
            Booking bokning2 = new Booking();
            
            bokning2.GetBookingInfo();
            bokning2.BookingInfo();
            bokning2.UpdateStayDate();
            bokning2.BookingInfo();
           




        }
    }
  

}

