namespace Reverse_String_Project
{
    internal class Program
    {
       

        static void Main(string[] args)  
        {
            Console.WriteLine("Please input any string name to check whether it is a palindrome");
            
            string userInput = Console.ReadLine();
            string reverseString = string.Empty;
            
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + userInput[i]; 
            }
                
            Console.WriteLine(reverseString);
            if (reverseString == userInput)
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