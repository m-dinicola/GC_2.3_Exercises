using System;

namespace _Exercises_Branching_
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                tryAgain = false;
                switch (GetInt("Which exercise would you like to run (26 / 27 / 28)? "))
                {
                    case 26:
                        
                        break;
                    case 27:
                        
                        break;
                    case 28:

                        break;
                    default:
                        Console.Write("That's not a valid input. Try again. ");
                        tryAgain = true;
                        break;
                }
            }
        }






        //IO methods necessary for template switch
        public static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int GetInt(string message)
        {
            return int.Parse(PromptUser(message));
        }
    }
}
