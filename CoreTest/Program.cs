using System;

namespace CoreTest
{
    class Program
    {
        //https://www.telerik.com/blogs/c-8-indices-and-range
        //The hat operator (^) and range operator (..) 
        //                                    0    1    2    3    4    5    6
        static char[] rainbow = new char[] { 'v', 'i', 'b', 'g', 'y', 'o', 'r' };
        static void Main(string[] args)
        {
            //RangeTest();
            IndicesTest();
        }
        public static void IndicesTest()
        {
            Index lastIndex = ^1;

            //^ is hat sign
            char lastElement = rainbow[^1]; // v
            char secondToLast = rainbow[^2]; // 'i'
            char lastIndexElement = rainbow[lastIndex]; // 'r'

            //rainbow[^6] //'i'
            //rainbow[^7] //118 'v'
            //rainbow[^8] //OutOfRange Exception
        }

        public static void RangeTest()
        {
            Range firstFourRange = ..4;//starting from the first till 4th element
            Range lastTwoRange = ^2..;//starting from secondlast till the first element
            var lastElement = rainbow[0..4];

            char[] firstFourElements = rainbow[firstFourRange];
            char[] lastTwoElement = rainbow[lastTwoRange];
            //            rainbow[1..4] // i b g
            //rainbow[4..]// y o r
            //rainbow[..4]// v i b g
            //rainbow[6..] // r
            //rainbow[..]// all the elements
            //rainbow[7]//'System.IndexOutOfRangeException'
        }
    }
}
