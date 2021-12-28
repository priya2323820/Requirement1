# Requirement1
using System;

namespace Requirement1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userDetails;

            User[] usersDetailsArray = new User[2];

            for (int i = 0; i < usersDetailsArray.Length; i++)
            {
                Console.WriteLine("Enter User {0} Details:", i + 1);                
                userDetails = Console.ReadLine();

                string[] UserStringArray = userDetails.Split(",");

                usersDetailsArray[i] = new User(UserStringArray[0], UserStringArray[2], UserStringArray[1]);
            }

            for (int i = 0; i < usersDetailsArray.Length; i++)
            {
                Console.WriteLine("User {0}: ", i + 1);

                Console.WriteLine(usersDetailsArray[i]);
            }

            if (usersDetailsArray[0].Equals(usersDetailsArray[1]))
            {
                Console.WriteLine("User {0} is same as user {1}", 1, 2);
            }
            else
            {
                Console.WriteLine("User {0} is different from user {1}", 1, 2);
            }
        }
    }
}
