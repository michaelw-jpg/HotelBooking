using System;

public class Booking
{
    private string _name;
    private int _days;
    private DateTime _checkIn;
    private DateTime _checkOut;

    //default
    public Booking()
    {

    }

    //constructor
    public Booking(string name, int days, DateTime checkin)
    {
        _name = name;
        _days = days;
        _checkIn = checkin;
        _checkOut = checkin.AddDays(days);

    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public DateTime CheckIn
    {
        get { return _checkIn; }
        set { _checkIn = value; }
    }

    public DateTime CheckOut
    {
        get { return _checkOut; }
        set { _checkOut = value; }
    }
    public int Days
    {
        get { return _days; }
        set 
        { 
            if (value <= 0 )
            {
                throw new ArgumentException("Ange en positiv siffra");
            }
            _days = value;
        }
    }
    public void BookingInfo()
    {
        int price = 300;

        Console.WriteLine($"Guest name : {_name}");
        Console.WriteLine($"Check in Date: {_checkIn.ToShortDateString()}");
        Console.WriteLine($"You will checkout: {_checkOut.ToShortDateString()}");
        Console.WriteLine($"Total Price: {price * _days} kr");
    }
    public void GetBookingInfo()
    {

        Console.WriteLine("Ange ditt för och efternamn:");
        string name = Console.ReadLine();
        DateTime test1;
        while (true)
        {
            Console.WriteLine("Ange ankomstdatum : yyyy-mm-dd");
            string test = Console.ReadLine();


            if (!DateTime.TryParse(test, out test1) || test1 < DateTime.Now)
            {
                Console.WriteLine("Rätt format kekw eller fel datums");
                continue;
            }
            break;
        }
        int dayz;
        while (true)
        {
            Console.WriteLine("Hur många dagar ska du stanna?");
            string days = Console.ReadLine();
            if (!int.TryParse(days, out dayz) || dayz < 0)
            {
                Console.WriteLine("Ge mig ett positivt heltal");
                continue;
            }
            break;
        }

        Days = dayz;
        Name = name;
        CheckIn = test1;
        CheckOut = test1.AddDays(dayz);
    }

    //method for updating length of stay
    public void UpdateStayDate()
    {
        int days;
        while (true)
        { 
            Console.WriteLine("Ange antal dagar du vill stanna");
            if(!int.TryParse(Console.ReadLine(), out days) || days < 0)
            {
                Console.WriteLine("Ge mig ett positivt heltal");
                continue;
            }
            break;
        }

        Days = days;
        CheckOut = CheckIn.AddDays(days);

    }

}
