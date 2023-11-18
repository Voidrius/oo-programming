using System;

class Program
{
    public delegate string StringTransformationDelegate(string input);

    static void Main()
    {
        Console.WriteLine("Enter the string to process:");
        string inputString = Console.ReadLine();

        StringTransformationDelegate transformationDelegate = null;

        while (true)
        {
            Console.WriteLine("\nChoose the treatment you want, you can give several treatments at once");
            Console.WriteLine("as one string, e.g. '123'");
            Console.WriteLine("1: to capital letters");
            Console.WriteLine("2: lowercase");
            Console.WriteLine("3: as a title");
            Console.WriteLine("4: as a palindrome");
            Console.WriteLine("0: termination");

            string selection = Console.ReadLine();

            if (selection == "0")
            {
                break;
            }

            transformationDelegate = GetTransformationDelegate(selection);

            if (transformationDelegate != null)
            {
                string result = transformationDelegate(inputString);
                Console.WriteLine($"{inputString} changed to {result}\n");
            }
            else
            {
                Console.WriteLine("Invalid selection. Try again.\n");
            }
        }
    }

    static StringTransformationDelegate GetTransformationDelegate(string selection)
    {
        StringTransformationDelegate transformationDelegate = null;

        foreach (char c in selection)
        {
            switch (c)
            {
                case '1':
                    transformationDelegate += ToCapitalLetters;
                    break;
                case '2':
                    transformationDelegate += ToLowercase;
                    break;
                case '3':
                    transformationDelegate += ToTitle;
                    break;
                case '4':
                    transformationDelegate += ToPalindrome;
                    break;
                default:
                    return null; 
            }
        }

        return transformationDelegate;
    }

    static string ToCapitalLetters(string input)
    {
        return input.ToUpper();
    }

    static string ToLowercase(string input)
    {
        return input.ToLower();
    }

    static string ToTitle(string input)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
    }

    static string ToPalindrome(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}