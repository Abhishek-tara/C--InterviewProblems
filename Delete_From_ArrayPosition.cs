using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Delete_From_ArrayPosition
    {
        //Write a program in C# Sharp to delete an element at desired position from an array
        public static void Delete()
        {
            //Console.Write("Enter size of an array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //Console.WriteLine("\nInsert Array elements: ");

            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write("element at {0} : ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Given Array is:");

            //foreach(var e in arr)
            //{
            //    Console.Write(e + " ");
            //}

            //Console.Write("\nInput the position where to delete: ");
            //int pos = Convert.ToInt32(Console.ReadLine());

            ///*---- locate the position of i in the array -------*/
            //int k = 0;
            //while (k != pos - 1)
            //    k++;
            ///*---- the position of i in the array will be replaced by the 
            //       value of its right */
            //while (k < size)
            //{
            //    arr[k] = arr[k + 1];
            //    k++;
            //}
            //size--;
            //Console.Write("\nThe new list is : ");
            //foreach(var e in arr)
            //{
            //    Console.Write(e + " ");
            //}

            //--------------------------Alternate-------------------------------------------//
            int[] arr = { 1, 2, 3, 4, 5 };
            int pos = 3;

            // Print original array
            Console.Write("Original array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //Shift elements to the left
            for (int i = pos-1; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }


            //remove element.......
            arr[arr.Length - 1] = 0;

            // Print modified array
            Console.Write("\nModified array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }

                Console.Write(arr[i] + " ");

            }
        }
    }
}
