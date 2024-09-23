using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2A_2425_GlobalVariables
{
    internal class Program
    {
        /// <summary>
        /// This is a global variable
        /// </summary>
        static int num = 4;

        static void Main(string[] args)
        {
            int aNumber = 12;

            displayNum();
            num = 14;

            displayNum();
            justAMethod(23);

            displayNum();

            aNumber = int.Parse("a");

            if(Parse("a", out aNumber))
            {

            }

            Console.ReadKey();
        }

        static void justAMethod(int a)
        {
            Console.WriteLine(a);
            //num = 15;
        }

        static void displayNum()
        {
            Console.WriteLine(">>>>" + num);
        }

        static void justAMethod()
        {

        }
        static void justAMethod(int a, int b)
        {

        }
        static void justAMethod(string a, int b)
        {

        }
        static void justAMethod(int a, string b)
        {

        }


        static bool Parse(string input, out int num)
        {
            try
            {
                num = int.Parse(input);
                return true;
            }
            catch (Exception e)
            {
                num = 0;
                return false;
            }
        }

        static bool Parse(string input, out float num)
        {
            try
            {
                num = float.Parse(input);
                return true;
            }
            catch (Exception e)
            {
                num = 0;
                return false;
            }
        }
    }
}
