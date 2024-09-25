using System;

public class Person
{
	private string _name;
	private string _email;
	private string _PhoneN;
	//default constructor
	public Person()
	{
	}
	public Person(string name, string email, string phone)
	{
		_name = name;
		_email = email;
		_PhoneN = phone;
	}

	public string PName
	{
		get { return _name; }
		set { _name = value; }
	}
	public string Email
	{
		get { return _email; }
		set { _email = value; }
	}
	public string Phone
	{
		get { return _PhoneN; }
		set { _PhoneN = value; }
	}

	public void GetPersonInfo()
	{
		Console.WriteLine("Ange ditt för och efternamn");
		string userName = Console.ReadLine();

        Console.WriteLine("Ange din e-post adress");
		string userMail = Console.ReadLine();

        Console.WriteLine("Ange ditt telefonnummer");
		string phoneNumber = Console.ReadLine();

		PName = userName;
		Email = userMail;
		Phone = phoneNumber;
    }
}
