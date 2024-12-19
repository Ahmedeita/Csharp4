namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statments
            //Console.WriteLine("1 T");
            //Console.WriteLine("2 T");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}
            #endregion


            #region For - Foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Numbers[i] += 10;
            //      if (Numbers[i]==5)
            //        {
            //          break;
            //        }
            //    Console.WriteLine(Numbers[i] + 10);
            //}

            //// Using a foreach loop to iterate over elements without modifying them Because it use Function GetEnumerator in Interface IEnummrable

            //foreach (int Number in Numbers)
            //{
            //    Console.WriteLine(Number + 10);
            //}
            #endregion


            #region While - Do While
            //int Number;
            //bool Flag;

            //do
            //{
            //    Console.WriteLine("Enter Even Number");

            //    //Number = int.Parse(Console.ReadLine());
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number % 2 == 1 || !Flag);

            //Console.WriteLine($"{Number} is Even");

            //int Number = 3;
            //bool Flag = false;

            //while (Number % 2 == 1 || !Flag)
            //{
            //    Console.WriteLine("Enter Even Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //Console.WriteLine($"{Number} is Even");
            #endregion

            #region String
            // Immutable Data Type [Value cannot be Changed]
            // Array Of Chars
            // "A H M E D"

            //string Name;

            //// Name = new string("Ahmed");

            //Name = "Ahmed";

            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Hash code Name 01 : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Hash code Name 02 : {Name02.GetHashCode()}");


            //string Name01 = "Ahmed";
            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Hash code Name 01 : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Hash code Name 02 : {Name02.GetHashCode()}");

            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Hash code Name 01 : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Hash code Name 02 : {Name02.GetHashCode()}");

            //Name01 = "Mostafa";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Hash code Name 01 : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Hash code Name 02 : {Name02.GetHashCode()}"); 

            //String Message = "Hello";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Message += " Route";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            #endregion






        }
    }
}
