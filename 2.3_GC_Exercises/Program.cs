using System;
using System.Text;

namespace _2._3_GC_Exercises
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
                        VowelCount();
                        break;
                    case 27:
                        ConsonantCount();
                        break;
                    case 28:
                        VowelBump();
                        break;
                    default:
                        Console.Write("That's not a valid input. Try again. ");
                        tryAgain = true;
                        break;
                }
            }
        }

        public static void VowelCount()
        {
            LetterSetCount(PromptUser("Please enter text for which to count vowels: "), "aeiouAEIOU");
        }

        public static void ConsonantCount()
        {
            LetterSetCount(PromptUser("Please enter text for which to count consonants: "), "pyfgcrldhtnsqjkxbmwvzPYFGCRLDHTNSQJKXBMWVZ");
        }

        public static void VowelBump()
        {
            string vowels = "aoeuiAOEUI";
            Console.WriteLine(BumpChar(PromptUser("Please enter text from which we will remove vowels: "), vowels));
        }

        public static string BumpChar(string input, string letterSet)
        {
            StringBuilder returnString = new StringBuilder("");
            foreach (char c in input)
            {
                if (!letterSet.Contains(c))
                {
                    returnString.Append(c);
                }
            }
            return returnString.ToString();
        }

        public static void LetterSetCount(string input, string letterSet)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (letterSet.Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

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
