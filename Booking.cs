using System;

public class HotelBooking
{
    private string _name;
    private int _days;
    private DateTime _checkIn;
    private DateTime _checkOut;

    //default
    public HotelBooking()
    {

    }

    //constructor
    public HotelBooking(string name, int days, DateTime checkin)
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
        set { _days = value; }
    }
    public void BookingInfo()
    {


        Console.WriteLine($"Guest name : {_name}");
        Console.WriteLine($"Check in Date: {_checkIn.ToShortDateString()}");
        Console.WriteLine($"You will checkout: {_checkOut.ToShortDateString()}");
    }
    public void GetUserInfo()
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

        _days = dayz;
        _name = name;
        _checkIn = test1;
        _checkOut = test1.AddDays(dayz);
    }
