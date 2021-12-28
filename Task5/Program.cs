using System;

namespace Requirement5
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfStories;
            string storyDetails;
            Console.WriteLine("Enter no of stores:");
            noOfStories = Convert.ToInt32(Console.ReadLine());
            NoOfReadsComparator noOfReadsComparator = new NoOfReadsComparator();
            Story[] storyDetailsArray = new Story[noOfStories];


            for (int i = 0; i < noOfStories; i++)
            {
                Console.WriteLine("Enter the details of story {0}:", i + 1);
                storyDetails = Console.ReadLine();

                storyDetailsArray[i] = StoryBo.createStory(storyDetails);
            }

            Console.WriteLine("Press 1->View By Authou Name 2->View By Likes");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sorted By Name:");
                    Array.Sort(storyDetailsArray);
                    break;
                case 2:
                    Console.WriteLine("Sorted By No Of Reads:");
                    Array.Sort(storyDetailsArray, noOfReadsComparator);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!..");
                    break;
            }

            foreach (Story st in storyDetailsArray)
            {
                Console.WriteLine(st);
            }

        }
    }
}

