//Using directive
using System; // System is a namespace

namespace Session2 //namespace
{//start of namespace
    class Program //declare a class
    {//start of class

        /// <summary>
        /// Entry point for this program
        /// </summary>
        /// <param name="args">Pass cany value from console for the code to handle</param>
        static void Main(string[] args) //Entry point
        {
            /* Mutiline comment
            The age for user, by default is 45 more
            Refer: to Soft spec v21 page # 23
            */

            //Digits without points
            //Signed 32-bit integer
            int age = 45;//integer data type // Alias/Nickname of Int32
            int copyAge = age;//value is copied from age
            Int32 year = 2016;// the real name of int data type

            //Floating point data types
            float Value = 35.5F;
            double biggerValue = 45.678D;
            decimal MoreBiggerValue = 45243343.67454M;

            char SchoolType = 'c';//U , C, S
            string name = "My name is Owais";//char array basically
            bool isSchool = false;

            int myAgeIs;//variable declare
            myAgeIs = 34;//varaible intialize
            //Default values

            Console.WriteLine("Declaring and intializing char Array");
            //index starts from 0
            char[] Shortname = new char[3];//three elements
            Shortname[0] = 'O';// access using index
            Shortname[1] = 'w';// indivual element
            Shortname[2] = 's';
            //Shortname[3] = 's';//index out of bounds exceptions

            //int number1, number2 = 7;
            // String concatenation
            // String format and interpolation
            // Console.WriteLine("Kese ho !");//Method, it performs an action
            //Console.ReadLine();

            //DynamicAndObject();

            //StringFormatExamples();

           // PrintMyName("Zain Ahmed");// "Zain Ahmed" is a Argument

            Console.ReadLine();
        }

        static void CreateNewToyota()
        {
            Car Toyota;//variable declaration
            Toyota = new Car();//instance creation of type Car,
            Toyota.Name = "Corolla";
            Toyota.Color = "Red";
            Toyota.Year = 2015;
        }
        static void StringFormatExamples()
        {
            int var1 = 5;
            int var2 = 9;
            //string whatToPrint = string.Format("var1 is {0} and the value of {1}", var1, var2);

            Console.WriteLine(string.Format("var1 is {0} and the value of {1}",var1,var2));
            Console.WriteLine("var1 is {0} and the value of {1}, both values are {0}{1}.", 3, 6);
            Console.WriteLine($"var1 is {var1} and the value of {var2}");// C# 6
        }

        /// <summary>
        /// Prints my name
        /// </summary>
        /// <param name="name">Supply your name for printing</param>
        static void PrintMyName(string name){//method, function, procedure, subroutine
            int age = 45;
            Console.WriteLine($"Your name is {name}");
            DynamicAndObject();
        }

        /// <summary>
        /// Display difference between dynamic and object types
        /// </summary>
        static void DynamicAndObject()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-dynamic-type
            dynamic dyn = 1;
            object obj = 1;
            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            System.Console.WriteLine(dyn.GetType());
            System.Console.WriteLine(obj.GetType());
            //obj.GetType().FullName
            Console.ReadLine();
        }

        static void Identifiers()
        {
            //  -Allowed at any position: The alphabetic and underscore characters
            //   (a through z, A through Z, and _)

            int Age_ = 45;
            int age_ = 45;
            int _age = 45;

            //- Not allowed in the first position: Digits, but are allowed everywhere else.

            int Year_ = 45;

            //- Only allowed in the first position: The @ character but not at any other position.
            //   Although allowed, its use is generally discouraged.
            int @Year = 45;
            int @class = 34;

            //-Identifiers are case-sensitive, so myName and MyName are different variables
            int myAge = 65;
            int MyAge = 65;
        }
    }//End of class
}// End of namespace
