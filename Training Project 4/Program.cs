using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;

L: Console.Write("Select the Program : ");
int select = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

switch (select)
{
    case 1:
        Console.Write("Give The Input : ");
        Console.WriteLine(Containsthreedigit(Convert.ToInt32(Console.ReadLine())));
        break;

    case 2:
        Console.Write("Give The Input : ");
        Console.WriteLine(palindrome(Convert.ToInt32(Console.ReadLine())));
        break;

    case 3:
        Console.Write("Give The Input : ");
        Fibonacci(Convert.ToInt32(Console.ReadLine()));
        break;

    case 4:
        datetime();
        break;

    case 5:
        swap();
        break;

    case 6:
        eligibilityadmission();
        break;

    case 7:
        Multiplicationtable();
        break;

    default:
        Console.WriteLine("-------INVALID INPUT-------");
        Console.WriteLine();
        goto L;
}
Console.ReadKey();

// 1. Write a method that checks if given number (positive integer) contains digit 3.
//    Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.
bool Containsthreedigit(int number)
{
    while (number > 0)
    {
        if (number % 10 == 3)
        {
            return true;
        }
        number = number / 10;
    }
    return false;

}

// 2. Write a method that should check no is palindrome or not.
bool palindrome(int number)
{
    int rem = 0;
    int sum = 0;

    int num = number;

    while (number > 0)
    {
        rem = number % 10;
        sum = (sum * 10) + rem;
        number = number / 10;
    }
    if (sum == num)
        return true;
    return false;

}

// 3.Write a method that should represent Fibonacci  series

void Fibonacci(int number)
{
    int num = 0;
    int num2 = 1;
    int sum;

    Console.Write(num + " " + num2 + " ");

    for (int i = 0; i <= number; i++)
    {
        sum = num + num2;

        Console.Write(sum + " ");

        num = num2;
        num2 = sum;
    }

}

// 4. Given two dates - first from the past and second as present date,
//    write a method that returns numbers of days between these two dates

void datetime()
{
    Console.Write("Enter The Date 1 : ");
    var date1 = Convert.ToDateTime(Console.ReadLine());

    var date2 = DateTime.Now;

    var Daydiffernt = date2 - date1;

    Console.WriteLine();
    Console.WriteLine("Day Different : " + Daydiffernt);
}

// 5.write a method that swaps them using temporary variable and without temp variable.

void swap()
{
    Console.Write("Give the value for A : ");
    int num1 = Convert.ToInt32((Console.ReadLine()));

    Console.Write("Give the value for B : ");
    int num2 = Convert.ToInt32((Console.ReadLine()));

    num1 = num1 + num2;
    num2 = num1 - num2;
    num1 = num1 - num2;

    Console.WriteLine();

    Console.Write("Swapping value of A : ");
    Console.WriteLine(num1);

    Console.Write("Swapping value of A : ");
    Console.WriteLine(num2);
}

// 6. Write a C# program to find the eligibility of admission for a professional course
//    based on the following criteria: 
//    Marks in Maths >=65
//    Marks in Phy >=55
//    Marks in Chem>=50
//    Total in all three subject >=180
//    or
//    Total in Math and Subjects >=140

void eligibilityadmission()
{
    Console.Write("Give the Maths Mark : ");
    int Maths = Convert.ToInt32(Console.ReadLine());

    Console.Write("Give the Physics Mark : ");
    int Physics = Convert.ToInt32((Console.ReadLine()));

    Console.Write("Give the Chemistry Mark : ");
    int Chemsitry = Convert.ToInt32((Console.ReadLine()));

    int Total = Maths + Physics + Chemsitry;

    int Mathsub = Maths + (Physics + Chemsitry);

    if (Maths >= 65 && Physics >= 55 && Chemsitry >= 50 && Total >= 180 || Mathsub >= 140)
    {
        Console.WriteLine("You're Eligible For This Admission");
    }
    else
    {
        Console.WriteLine("You're Not Eligible For This Admission");
    }
}

// 7. Write a method that prints 10 by 10 multiplication table. Remember about readibility (spaces in the right place).
void Multiplicationtable()
{

    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.Write(i * j + " ");
        }
        Console.WriteLine();
    }
}



