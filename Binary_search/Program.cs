using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] aray = { 5, 10, 15, 20, 25 };
            Console.Write("Enter the value you look for : ");
            int value = int.Parse(Console.ReadLine());
            int len=aray.Length;
            int check=Binary_search(aray, value,0,len-1);
            if (check == -1) { Console.WriteLine("The value not founded "); }
            else Console.WriteLine("The value is valied in position " + check);
        }


        static int Binary_search(int[] arr,int value, int l ,int h)
        {
            while (l<=h)

            {
                int mid = h+l / 2;
                if (arr[mid] == value)
                {
                    return mid;

                }
               

                    if (arr[mid] < value) { l = mid + 1; }

                    else h = mid - 1;
                
                }
                return -1;     
            }
          
        }
    }

