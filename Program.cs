using System;
using System.Collections;

namespace HotelBooking
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<Person, Booking>> list = new List<Tuple<Person, Booking>>();
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("OOP Hotel bokningssystem");
                Console.WriteLine("[1]Lägg till en Bokning");
                Console.WriteLine("[2]Visa bokningar/ändra bokningar/avbokning");
                Console.WriteLine("[3]Avsluta");
                int.TryParse(Console.ReadLine(), out int menyChoice);

                switch (menyChoice)
                {
                    case 1:
                        Person guest = new Person();
                        guest.GetPersonInfo();
                        Booking bokning = new Booking(guest);
                        bokning.GetBookingInfo(guest);
                        Tuple<Person, Booking> guestAndBook = Tuple.Create(guest, bokning);
                        list.Add(guestAndBook);
                        break;
                    case 2:
                        Console.WriteLine("Visar Samtliga bokningar Namn - Incheckning - Utcheckning");
                        for (int i = 0; i < list.Count; i++)
                        { 
                            Console.WriteLine($"[{i+1}] Namn : {list[i].Item1.PName} - {list[i].Item2.CheckIn.ToShortDateString()}" +
                                $" - {list[i].Item2.CheckOut.ToShortDateString()} ");
                        }
                        break;
                    case 3:
                        break;
                }
            }
       

           
           




        }
    }
  

}

