using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence or word: ");
        string input = Console.ReadLine();
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"The given sentence or word is a palindrome: {isPalindrome}");
    }

    static bool IsPalindrome(string input)
    {
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        if (input == reversed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}




