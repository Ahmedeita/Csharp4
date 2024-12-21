using System;
using System.ComponentModel;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Entere Integer Number : ");
            //int Number;
            //int.TryParse(Console.ReadLine(), out Number);
            //for (int i = 1; i <= Number; i++)
            //    Console.Write($" {i},");
            #endregion

            #region Q2
            //2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("ENTER THE NUMBER : ");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; )
            //    Console.WriteLine($"{Num} * {i} = {Num * i++}");

            #endregion

            #region Q3
            //3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter Integer Number : ");
            //int Number;
            //int.TryParse(Console.ReadLine(), out Number);
            //for (int i = 1; i <= Number; i++)
            //    if (i % 2 == 0 )
            //    Console.Write($" {i},");
            #endregion

            #region Q4
            //4- Write a program that takes two integers then prints the power.
            //Console.Write("Enter the Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter the exponent x : ");
            //int x = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 0; i < x; i++)
            //{
            //    result *= num;
            //}
            //Console.WriteLine($"{num} ^ {x} = {result} ");
            #endregion

            #region Q5
            // 5- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter the String : ");
            //string Text = Console.ReadLine();
            //for (int i = Text.Length; i > 0; i--)
            //{
            //    Console.Write(Text[i - 1]);

            //}
            #endregion

            #region Q6
            //6- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Enter start number: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter end number: ");
            //int end = int.Parse(Console.ReadLine());

            //for (int num = start; num <= end; num++)
            //{
            //    bool Prime = true;
            //    for (int i = 2; i * i <= num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            Prime = false;
            //            break;
            //        }

            //    }
            //    if (Prime)
            //        Console.WriteLine(num);

            #endregion

            #region Q7
            //7- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a decimal number To Convert : ");
            //int Num = int.Parse(Console.ReadLine());

            //StringBuilder sb = new StringBuilder();

            //while (Num > 0)
            //{
            //    sb.Append(Num % 2);
            //    Num /= 2;
            //}
            //Console.Write("The Binary of 25 is " + sb);
            #endregion

            #region Q8
            //8- . Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size of the identity matrix : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //           Console.Write("1 ");

            //        else
            //          Console.Write("0 ");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q9
            //9- Write C# program that Extract a substring from a given string.
            //Console.Write("Enter The String : ");
            //string Text = Console.ReadLine();

            //Console.Write("Enter the Start Index : ");
            //int StartIndex = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Length  : ");
            //int Length = int.Parse(Console.ReadLine());

            //if (StartIndex >= 0 && Length + StartIndex <= Text.Length)
            //    Console.WriteLine(Text.Substring(StartIndex, Length));

            //else
            //    Console.WriteLine("Invalid Input !!! ");


            #endregion

            #region Q10
            //10- Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("Enter the 1st String : ");
            //string FirstString = Console.ReadLine();
            //Console.WriteLine("Enter the 2nd String : ");
            //string SecondString = Console.ReadLine();
            //StringBuilder sb = new StringBuilder(FirstString);
            //sb.Append(SecondString);
            //Console.WriteLine(sb);
            #endregion

            #region Q11 - Q8
            //11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //----> Same Number 8 
            //Console.Write("Enter the size of the identity matrix : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //           Console.Write("1 ");

            //        else
            //          Console.Write("0 ");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q12
            //12- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter the Length of the array : ");
            //int [] Numbers = new int[int.Parse(Console.ReadLine())];

            //for (int i = 0; i < Numbers.Length;)
            //{
            //    bool flag = true;
            //    int num;
            //    Console.Write($"Enter element [{i+1}] : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //    if (flag)
            //    {
            //        Numbers[i] =num;
            //        i++;
            //    }

            //}
            //int sum =0 ;
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    sum += Numbers[i];

            //}
            //Console.WriteLine($"The Sum of Elements In The Array = {sum}");
            #endregion

            #region Q13
            //13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter the Length of the array : ");
            //int Size = int.Parse(Console.ReadLine());
            //int [] FirstArray = new int[Size];
            //int [] SecondArray = new int[Size];

            //for (int i = 0; i < FirstArray.Length;)
            //{
            //    bool flag = true;
            //    int num;
            //    Console.Write($"Enter First Array element [{i + 1}] : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //    if (flag)
            //    {
            //        FirstArray[i] = num;
            //        i++;
            //    }

            //}

            //for (int i = 0; i < SecondArray.Length;)
            //{
            //    bool flag = true;
            //    int num;
            //    Console.Write($"Enter Second Array element [{i + 1}] : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //    if (flag)
            //    {
            //        SecondArray[i] = num;
            //        i++;
            //    }

            //}

            //int[] MergedArray = FirstArray.Concat(SecondArray).ToArray();
            //Array.Sort(MergedArray);

            //for (int i = 0; i < MergedArray.Length; i++)
            //{
            //    Console.WriteLine($"The Megerd Array Element [{i+1}] :{MergedArray[i]} ");

            //}


            #endregion

            #region Q14
            //14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.Write("Enter the Length of the array : ");
            //int Size = int.Parse(Console.ReadLine());
            //int[] Numbers = new int[Size];
            //int[] frequency = new int[Size];

            //for (int i = 0; i < Size;)
            //{
            //    bool flag = true;
            //    int num;
            //    Console.Write($"enter Numbers element [{i + 1}] : "); 
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //    if (flag)
            //    {
            //        Numbers[i] = num;
            //        i++;
            //    }

            //}
            //for (int i = 0; i < Size; i++)
            //{
            //    int counter = 1;
            //    for (int j = i + 1; j < Size; j++) 
            //    {
            //        if (Numbers[i] == Numbers[j])
            //        {
            //            counter++;
            //            frequency[j] = -1;
            //        }
            //    }

            //    if (frequency[i] >= 0)
            //        frequency[i] = counter;

            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //    if (frequency[i] >= 0)
            //        Console.WriteLine($"{Numbers[i]}: {frequency[i]}");



            #endregion

            #region Q15
            //15 - Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("Enter the Length of the array : ");
            //int Size = int.Parse(Console.ReadLine());
            //int[] Numbers = new int[Size];

            //for (int i = 0; i < Numbers.Length;)
            //{
            //    bool flag = true;
            //    int num;
            //    Console.Write($"Enter First Array element [{i + 1}] : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //    if (flag)
            //    {
            //        Numbers[i] = num;
            //        i++;
            //    }

            //}
            //int Max = Numbers.Max();
            //Console.WriteLine($"Max Number : {Max}");
            //int Min = Numbers.Min();
            //Console.WriteLine($"Min Number : {Min}");
            #endregion

        }
    }
}
