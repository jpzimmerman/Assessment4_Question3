using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question3 {
    class Program {
        static void Main(string[] args) {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };

            /* Extra ';' made the for-loop an empty statement, so an IndexOutOfRange exception was allowed to occur. I don't know what kind of money you paid in order to get a special guest appearance from the all-time Programming Hide and Seek champion, but I hope it wasn't too much. 
            // Also, the for-loop added 1 to every value in the array leading to a final sum of 27 rather than 21
            //for (int i = 0; i < array1.Length; i++) // ;
            //{
            //    array1[i]++;
            //}

            // GetSum needed to be marked a static method before being used in this code. 
            // In this specific case, we could also use our int array's built-in Sum method to  get away from any errors that  may be present in our GetSum method. */
            int result = GetSum(array1);
            int arraySumResult = array1.Sum();
            Console.WriteLine($"Result from GetSum(array1) method call, all errors fixed: {result}");
            Console.WriteLine($"Result from array1.Sum() method call, most errors avoided: {arraySumResult}");
            Console.ReadKey();
        }
        private static int GetSum(int[] array1) {
            //initial value of sum corrected from 1 to 0 so that we get an accurate sum of array values, rather than sum of array values plus 1
            //int sum = 1;
            int sum = 0;
            foreach (int item in array1) {
                sum += item;
            }
            return sum;
        }
    }
}
