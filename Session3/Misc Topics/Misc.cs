using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Session3.NewFolder1
{
    public class Misc
    {
        static char[] rainbow = new char[] { 'v', 'i', 'b', 'g', 'y', 'o', 'r' };
        public static void RangeTest()
        {

        }

        //public static void IndicesTest()//Check CoreTest project
        //{
        //    char lastElement = rainbow[^1]; // r
        //    char secondToLast = rainbow[^2]; // 'o'
        //}

        public static void NotAssignedValue()
        {
            //C# 7.1
            int x = default;

            // C# 4 ?
            //int x = default(int);

            //Another way
            //int y = Int32;

            // compile-time error
            //int x;
            Console.WriteLine(x);
        }

        public static void PostnPreOperators()
        {
            int x, y;
            x = y = 0;

            Console.WriteLine(++x);//prints 1
            Console.WriteLine(y++);//print 0

            Console.ReadLine();
        }

        //A copy of the Value is changed directly and returned back to the caller
        //the orginal argument value remains intact
        public static int PassByValue(int a)
        {
            //++a;
            return ++a;
        }

        //Value is accessed/changed directly by using a reference instead of value being copied
        //notice the no return statement
        //the orginal argument value is changed
        public static void PassByRef(ref int a)
        {
            ++a;
        }

        public static void PassByOut(string FullName,out string FirstName,out string MiddleName,out string LastName)
        {
            var nameArray = FullName.Split(' ');
            FirstName = nameArray[0];
            MiddleName = nameArray[0];
            LastName = nameArray[0];
        }

        //Create put varaibles w/o declaration
        public static void OutVariablesWithoutDeclaration(ref int a)
        {
            PassByOut("Muhammad Allama Iqbal", out string first, out string middle, out string last);
            Console.WriteLine(first);
            Console.WriteLine(middle);
            Console.WriteLine(last);
        }

        //Out varaibles discard varaibles
        public static void OutVariablesWithDiscards(ref int a)
        {            
            PassByOut("Muhammad Allama Iqbal", out string first, out string middle, out string _);
            Console.WriteLine(first);
            Console.WriteLine(middle);
            //Console.WriteLine(last); // there is no last value

            //PassByOut("Muhammad Allama Iqbal", out string _, out string middle, out string _);//only take the middle value
            //benefits ?
            //no need for overloads, flexibility
        }


        //https://thedotnetguide.com/null-conditional-operator-in-csharp/
        public static void NullConditionalOperator() {
            Car toyota = null;
            //If employee is not null then return emp.Name else set null
            string carName = (toyota != null) ? toyota.Name : null;//to avoid nullRefernce exception
            string carName2 = toyota?.Name;//null
        }
    }
}
