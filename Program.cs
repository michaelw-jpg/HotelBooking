using System;
using System.Collections;
using System.Collections.Generic;

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
                        BookingWriter(list);
                        int.TryParse(Console.ReadLine(), out int answer);
                        answer--;
                        if (answer < 0)
                            break;
                        list[answer].Item2.BookingInfo();
                        BookEditor(list[answer].Item2);
                        break;
                    case 3:
                        break;
                }
            }

        }

        static void BookingWriter(List<Tuple<Person, Booking>> list)
        {
            
            Console.WriteLine("Visar Samtliga bokningar Namn - Incheckning - Utcheckning");
            for (int i = 0; i < list.Count; i++)
            {
                // Hides "removed" bookings
                if (list[i].Item2.CheckIn < Convert.ToDateTime("0003-01-01"))
                    continue;
                
                Console.WriteLine($"[{i + 1}] Namn : {list[i].Item1.PName} - {list[i].Item2.CheckIn.ToShortDateString()}" +
                    $" - {list[i].Item2.CheckOut.ToShortDateString()} ");
            }

        }

        static void BookEditor(Booking bokning)
        {
            Console.WriteLine("Vill du: ");
            Console.WriteLine("[1]Ändra bokning");
            Console.WriteLine("[2]Avboka");
            Console.WriteLine("[3]Återgå till bokningslista");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    bokning.UpdateStayDate();
                    bokning.UpdateCheckInDate();
                    Console.WriteLine("Bekräftelse ändring, summering uppgifter:\n ");
                    bokning.BookingInfo();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine($"Avboka : \n");
                    bokning.BookingInfo();
                    Console.WriteLine("Skriv DEL för att ta bort");
                    string answer = Console.ReadLine();
                    if (answer == "DEL")
                    {
                        bokning.BookingClear();
                    }
                    Console.WriteLine("Bokningen har tagits bort");
                    break;

                case 3:
                    break;


            }
        }

        

    }
  

}

