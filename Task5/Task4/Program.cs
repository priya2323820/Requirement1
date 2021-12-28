using System;

namespace Requirement4
{
    class Program
    {
        public static int noOfStory;
        static void Main(string[] args)
        {
            int noOfLikes;
            string storyDetails, authourName;
            Console.WriteLine("Enter the no of story:");
            noOfStory = Convert.ToInt32(Console.ReadLine());

            StoryBo storyBo = new StoryBo();
            Story[] storyDetailsArray = new Story[noOfStory];
            Story[] findStoryList = new Story[] { };



            for (int i = 0; i < noOfStory; i++)
            {
                Console.WriteLine("Enter the details of story {0}:", i + 1);
                storyDetails = Console.ReadLine();

                string[] storyStringArray = storyDetails.Split(",");

                storyDetailsArray[i] = new Story(storyStringArray[0], storyStringArray[1], storyStringArray[2],
                    Convert.ToInt32(storyStringArray[3]), Convert.ToInt32(storyStringArray[4]), Convert.ToInt32(storyStringArray[5]));
            }

            Console.WriteLine("Press 1->View By Authou Name 2->View By Likes");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter The Authour Name:");
                    authourName = Console.ReadLine().Trim();
                    Console.WriteLine("The Authour {0} :", authourName);
                    findStoryList = storyBo.findStoryByAuthor(storyDetailsArray, authourName);
                    break;
                case 2:
                    Console.WriteLine("Enter The No Of Likes:");
                    noOfLikes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("No Of Likes {0}:", noOfLikes);
                    findStoryList = storyBo.finfindStoryByLikes(storyDetailsArray, noOfLikes);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!..");
                    break;
            }

            if (findStoryList.Length != 0 && findStoryList != null)
            {
                foreach (Story st in findStoryList)
                {
                    Console.WriteLine(st);
                }
            }
            else
            {
                Console.WriteLine("No such story found!..");
            }

        }
    }
}
