using System;

namespace Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter user {0}  details:", i + 1);
                string userdetails = Console.ReadLine();
                string[] users_detail = userdetails.Split(',');
                users[i] = new User(users_detail[0], users_detail[1], users_detail[2]);
            }


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("User {0}", i + 1);
                Console.WriteLine(users[i]);
            }

            if (users[0].Equals(users[1]))
            {
                Console.WriteLine("User 1 and User 2 are same");

            }
            else
            {
                Console.WriteLine("User 1 and User 2 are different");
            }

        }




        // sub class

    }
}

        

