using System;
using System.IO.Pipes;

public
class op
{
    static void leapYear()
    {
        Console.WriteLine("Enter year to check leap year");
        int n=Convert.ToInt32(Console.ReadLine());
        if (n % 400 == 0 || n % 100 != 0 && n % 4 == 0)
        {
            Console.WriteLine($"Year {n} is a leap year");
        }
        else
        {
            Console.WriteLine($"Year {n} is not a leap year");
        }
    }
    static void checkType()  
    {
        Console.WriteLine("Enter Number");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("Number is Zero");
        }
        else if (n > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else
        {
            Console.WriteLine("Number is negative");
        }
    }
    static void purchase()
    {
        Console.WriteLine("Enter total number of items");
        int num = Convert.ToInt32(Console.ReadLine());
        double[] price = new double[num];
        double[] taxRate = new double[num];
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Enter price of item {i + 1}");
            double it = Convert.ToDouble(Console.ReadLine());
            price[i] = it;
            Console.WriteLine($"Enter tax rate of item {i + 1}");
            double tax = Convert.ToDouble(Console.ReadLine());
            taxRate[i] = tax;
        }
        double ans = 0;
        for (int i = 0; i < num; i++)
        {
            ans += price[i] + (price[i] * taxRate[i]) / 100;
        }
        ans = ans > 50 * 80 ? ans - (ans * 10) / 100 : ans;
        Console.WriteLine($"Total cost of purchased itmes is : {Math.Round(ans, 2)}");
    }
    static void checkVowelOrConstant()
    {
        Console.WriteLine("Enter character");
        char var = Convert.ToChar(Console.ReadLine());
        bool temp=(var == 'a' || var == 'A' || var == 'e' || var == 'E' || var == 'i' || var == 'I'|| var == 'o' || var == 'O' || var == 'u' || var == 'U')?true:false;
        if(temp)
        {
            Console.WriteLine($"Character {var} is a vowel");
        }
        else
        {
            Console.WriteLine($"Character {var} is a consonant");
        }
        
    }
    static void checkBMI()
    {
        Console.WriteLine("Enter User's weight in kg");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter User's height in meters");
        Double height=Convert.ToDouble(Console.ReadLine());
        double ans=weight/(height*height);
        if (ans <= 18.5)
        {
            Console.WriteLine("User is underweight");
        }
        else if(ans>18.5 && ans <= 24.9)
        {
            Console.WriteLine("User has Normal Weight");
        }
        else if(ans>=25 && ans <= 29.9)
        {
            Console.WriteLine("User is OverWeight");
        }
        else
        {
            Console.WriteLine("User is in the category of obesity");
        }
    }
    public static void Main(string[] args)
    {
        checkVowelOrConstant();
    }
}