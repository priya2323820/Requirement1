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


// User Class

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Cases
{
    class User
    {




        //fields
        private string username;
        private string mailid;
        private string password;

        //default constructor
        public User()
        {

        }

        public User(string username, string mailid, string password)
        {
            this.username = username;
            this.mailid = mailid;
            this.password = password;
        }

        //properties
        public string Username { get => username; set => username = value; }
        public string Mailid { get => mailid; set => mailid = value; }
        public string Password { get => password; set => password = value; }


        public override string ToString()
        {
            return String.Format("Username: {0}\nMail Id: {1}\nPassword: {2}", Username, Mailid, Password);
        }

        public override bool Equals(object obj)
        {
            User obj_user = (User)obj;
            return this.username.Equals(obj_user.username);
            //  return base.Equals(obj);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

}

