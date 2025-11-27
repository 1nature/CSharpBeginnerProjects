using System.ComponentModel.DataAnnotations;

namespace Complex_Reverse_String_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input any string name to check whether it is a palindrome");

            string userInput = Console.ReadLine();
            string reverseString = string.Empty;

            for (int i = 0; i < userInput.Length; i++)
            {
                reverseString = userInput[i] + reverseString;
            }

            Console.WriteLine(reverseString);
            if (reverseString.ToLower() == userInput.ToLower())
            {
                Console.WriteLine($"{userInput} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a palindrome");
            }

        }
    }
}
