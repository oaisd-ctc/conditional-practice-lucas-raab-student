
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class Program
{

    public static void Main(string[] args)
    {

        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativezero(-1);
        CheckForPositiveNegativezero(0);
        CheckForPositiveNegativezero(1);
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(7);
        CheckEvenOrOdd(10);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(1);
        DisplayDayOfWeek(2);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(4);
        DisplayDayOfWeek(5);
        DisplayDayOfWeek(6);




    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativezero(int X)
    {

        if (X == 0)
        {
            Console.WriteLine("Your Number is zero");

        }
        else if (X > 0)
        {
            Console.WriteLine("Your Number is Postive ");
        }
        else
        {
            Console.WriteLine("Your Number is Negative ");
        }
    }
    public static void FindMinimum(int Min1, int Min2, int Min3)
    {
        if (Min1 < Min2 && Min1 < Min3)
        {
            Console.WriteLine("The Minimun vaule is " + Min1);

        }
        else if (Min2 < Min1 && Min2 < Min3)
        {
            Console.WriteLine("the MInimun Value is " + Min2);
        }
        else
        {
            Console.WriteLine("the minimun vaule is " + Min3);
        }

    }
    public static void FindMaximum(int Max1, int Max2, int Max3)
    {
        if (Max1 > Max2 && Max1 > Max3)
        {
            Console.WriteLine("The maximum is " + Max1);

        }
        else if (Max2 > Max1 && Max2 > Max3)
        {
            Console.WriteLine("The maximum is " + Max2);

        }
        else
        {
            Console.WriteLine("The maximum is " + Max3);
        }


    }
    public static void IsDivisibleBy5(int Divide)
    {
        if (Divide % 5 == 0)
        {
            Console.WriteLine(+Divide + " is divisible  by 5");

        }
        else
        {
            Console.WriteLine(+Divide + " is not dvisible by 5");

        }

    }
    public static void CheckEvenOrOdd(int EvenorOdd)
    {
        if (EvenorOdd % 2 == 0)
        { Console.WriteLine(+EvenorOdd + " Is an even Number"); }
        else
        {
            Console.WriteLine(+EvenorOdd + " Is a odd number");

        }

    }
    public static void CheckVowelOrConsonant(char letter)

    {
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine(letter + " is a vowel");
                break;
            default:
                Console.WriteLine(letter + " Is a contsonat");
                break;
        }


    }
    public static void DisplayDayOfWeek(int daycode)
    {
        if (daycode == 0)
        {
            Console.WriteLine("Sunday");

        }
        else if (daycode == 1)
        {
            Console.WriteLine("Monday");
        }
        else if (daycode == 2)
        {
            Console.WriteLine("Tuesday");
        }
        else if (daycode == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else if (daycode == 4)
        {
            Console.WriteLine("Thursday");
        }
        else if (daycode == 5)
        {
            Console.WriteLine("Friday");
        }
        else
        {
            Console.WriteLine("Saturday");
        }
    }





}




