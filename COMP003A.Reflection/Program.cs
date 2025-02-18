using System.Transactions;

namespace COMP003A.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer1 myAnswer1 = new Answer1 { AnswerOne = "What worked best for me was the lecture activities. They provided examples and an opportunity to reinforce what I had just learned." };
            Console.WriteLine("1. What worked well for you over the last 8 weeks?\n");
            myAnswer1.DisplayAnswerOne();

            Console.WriteLine("\n2. What external resources did you use to aid your learning?\n");
            Answer2 AnswerTwo = new Answer2("I used the provided links like GeekForGeek and Microsoft Learn. One other that I used was w3schools.com. I tried my best to use the lectures instead of resorting to Google, AI, or YouTube. ");
            AnswerTwo.DisplayAnswerTwo();
            Console.WriteLine("\n3. What would you change about the course?\n");
            AnswerThree();

            Console.WriteLine("\n4. Did you learn what you expected to learn in this course?\n");
            Console.WriteLine("I was not sure what to expext when I started this course. I can say that it was well taught and well constructed. It is a great way to learn C#, although I " +
                "sure most of it comes from on the job experience. ");

            while (true)
            {
                Console.WriteLine("\n5. What concepts were new to you?\n");

                int choice;

                Console.WriteLine("Enter 1 for short answer.");
                Console.WriteLine("Enter 2 for long answer.");
                Console.WriteLine("Enter 3 to exit.");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());


                if (choice == 3) break;

                else if (choice == 1)
                { Console.WriteLine("\nEverything."); }

                else if (choice == 2)
                {
                    Console.WriteLine("\nAll of the concepts were new to me. Sme more difficult to understand than other.");
                }
                else
                {
                    Console.WriteLine("\nInvalid entry. Select 1 or 2");
                }
            }

                Console.WriteLine("\n6. What concepts have you encountered already in the past?\n");

                Console.WriteLine("I have not been exposed to C# prior to taking this course.");

                Console.WriteLine("\n7. Do you have any tips/comments for the instructor?\n");

                Console.WriteLine("There isn't much I could say. I think the class was well constructed. The lectures are made easy to understand, but I felt in the last three weeks that some one the answers" +
                    "I was looking for during a lecture week were answered in next week's lectures. SO far in the three classes I have been in, instructed by you, I have felt that it has been a great exposure " +
                    "and constinues to motivate me. All the challenges have felt like an accomplishment week after week. ");
            
        }

        static void AnswerThree()
        {
            Console.WriteLine("The only thing I would change about the course is unlocking the week's assignment. Personally I needed the extra time to complete the assignment in order to turn it in on time");
        }
    }
}
