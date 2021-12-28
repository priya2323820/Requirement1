using System;
using System.Linq;

public class PasswordValidation
{
	public static void Main()
	{
		bool isValid = validatePassword();
		if (isValid)
		{
			Console.WriteLine("Password is valid");
		}
		else
		{
			Console.WriteLine("Password is invalid");
		}
	}

	public static bool validatePassword()
	{
		Console.WriteLine("Enter the password to be validated");
		const int minLength = 7;
		string password = Console.ReadLine();
		if (password.Length > minLength)
		{
			if (password.Any(Char.IsWhiteSpace))
			{
				return false;
			}
			if (password.Any(Char.IsUpper) && password.Any(Char.IsLower) && password.Any(Char.IsNumber) && password.Any(ch => !Char.IsLetterOrDigit(ch)))
			{
				return true;
			}
			Console.WriteLine("statement failed");
			return false;
		}
		else
		{
			return false;
		}
	}
}
