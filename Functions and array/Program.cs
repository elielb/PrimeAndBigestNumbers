using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_and_array
{
    class Program
    {
        static int calcNumbers = 0;
        static int numA = 0;
        static int numB = 0;
        static int[] arr_1 = new int[100];
        static int[,] arr_2 = new int[5, 5];
        static Random rnd;
        static void Main(string[] args)
        {
           
            Arr2to1(out arr_2, out arr_1);
            ReturnNum(arr_1);
            Console.ReadLine();
        }

        static private void Maker()
        {
            Console.WriteLine("the numbers in double arr are \n");
            rnd = new Random();
            for (int i = 0; i < arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2.GetLength(1); j++)
                {
                    Console.Write(arr_2[i, j] = rnd.Next(0, 1000));
                    Console.Write(",");
                }
            }
        }
        static private void Arr2to1(out int[,] arrDouble, out int[] arr)
        {
            arrDouble = new int[5, 5];
            arr = new int[100];
            Maker();
            Console.Write("\n\nthe prime numbers are : ");
            for (int i = 0; i < arrDouble.GetLength(0); i++)
            {
                for (int j = 0; j < arrDouble.GetLength(1); j++)
                {
                    if (Check_Prime(arrDouble[i, j]))
                    {
                        Console.Write(arrDouble[i, j] + ",");
                        for (int x = 0; x < arr.Length; x++)
                        {
                            if (arr[x] == 0)
                            {
                                arr[x] = arrDouble[i, j];
                                break;
                            }
                        }
                    }
                }
            }
        }
        static private bool Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }
        static private void ReturnNum(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (calcNumbers == 0)
                {
                    calcNumbers = arr[i] + arr[i + 1];
                    numA = arr[i];
                    numB = arr[i + 1];
                }
                if (calcNumbers < arr[i] + arr[i + 1])
                {
                    calcNumbers = arr[i] + arr[i + 1];
                    numA = arr[i];
                    numB = arr[i + 1];
                }
                if (arr[i + 1] == 0)
                    break;
            }
            Console.WriteLine("\n\nThe bigest number is " + calcNumbers + "\nit combain with the numbers " + numA + " and " + numB);

        }
    }
}
