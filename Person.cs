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
	public void GetPersonInfo()
	{
		Console.WriteLine("Ange ditt för och efternamn");
		string userName = Console.ReadLine();

        Console.WriteLine("Ange din e-post adress");
		string userMail = Console.ReadLine();

        Console.WriteLine("Ange ditt telefonnummer");
		string phoneNumber = Console.ReadLine();

		_name = userName;
		_email = userMail;
		_PhoneN = phoneNumber;
    }
}
