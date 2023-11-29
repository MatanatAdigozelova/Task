using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            //1) Yuxaridaki arrayda 5 reqeminin nece defe tekrarlandigini tapin
            //2) Yuxaridaki arraydaki butun reqemlerin cemini tapin
            //3) arraydaki en boyuk reqemi tapin ve nece defe tekrarlandigini gosterin
            //4) arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin
            //4) arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin
            //5) arraydaki en boyuk reqemin ilk indexini tapin
            //6) 4 reqeminin arrayin hansi indexlerinde oldugunu gosterin
            //7) 5 reqeminin arraydaki en boyuk ve en kicik indexlerini tapin

            //--------------------------------------------------------------------------

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}



            //--------------------------------------------------------------------------
            //1 TASK
            int count = 0;
            for (int i = 0; i  arr.Length; i++)
            {

                if (arr[i] == 5)

                {
                    count++;
                }

            }
            Console.WriteLine(count);


            //----------------------------------------------------------------
            //2 TASK
            int sum = 0;
            for (int i = 0; i  arr.length; i++)
            {
                sum = arr[i] + sum;
            }
            console.writeline(sum);

            //------------------------------------------------------------------

            //3 TASK
            int max = arr[0];
            int maxcount = 0;


            for (int i = 0; i  arr.Length; i++)
            {
                if (arr[i]  max)
                {
                    max = arr[i];
                    maxcount++;
                }


            }
            Console.WriteLine(max);
            Console.WriteLine(maxcount);
            //Array.Sort(arr);
            //for (int i = 0; i  arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}




        }



        //Console.WriteLine(arr[0]);
        //int[] arr = {2,3,4,5};
        //int min = arr[0];
        //foreach (var item in arr)
        //{
        //    if (item  min)
        //    {
        //        min = item;
        //    }

        //}
        //Console.WriteLine(min);


    }
}
