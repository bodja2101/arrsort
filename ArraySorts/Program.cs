using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySorts
{
    class Program
    {
        static List<int> number;
        static Random r = new Random();
        static void Main(string[] args)
        {
            number = new List<int>();
            for (int i = 0; i < 21; i++)
            {
                number.Add(r.Next(1, 100));
            }
            Console.Write("Unsort array: ");
            foreach (int num in number)
            {
                Console.Write("{0} ", num);
            }
            Console.Write("\nBuble sort array: ");
            Buble();
            Console.Write("\nReshuffle sort array: ");
            ReshuffleSort(number);
            Console.Write("\nInsertion sort array: ");
            InsertionSort(number);

            Console.Read();
        }
        static void Buble() 
        {
            bool flag = true;
            int temp;
            int numLength = number.Count;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (int num in number)
            {
                Console.Write("{0} ", num);
            }
        }
        static void ReshuffleSort(List<int> inputArray)
        {
            int[] intarr = new int[inputArray.Count];
            intarr = inputArray.ToArray();
            for (int i = 0; i < intarr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (intarr[j - 1] > intarr[j])
                    {
                        int temp = intarr[j - 1];
                        intarr[j - 1] = intarr[j];
                        intarr[j] = temp;
                    }
                }
            }
            foreach (int num in intarr)
            {
                Console.Write("{0} ", num);
            }
        }
        static void InsertionSort(List<int> inputArray)
        {
            int[] array = new int[inputArray.Count];
            array = inputArray.ToArray();
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            foreach (int num in array)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
