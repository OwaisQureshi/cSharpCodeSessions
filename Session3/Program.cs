using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session3.NewFolder1;
using Session3.Reference_Vs_Value_Types;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferenceType();
            //ValueType();

            Misc.PostnPreOperators();
        }

        private static void ReferenceType()//copies reference only
        {
            var personC = new PersonClass { Age = 34, Name = "Khaloo Class" };

            PersonClass personClass;
            personClass = personC;//refeernce is copied


            Console.WriteLine("Original Object: Before changing values");
            Console.WriteLine($"{nameof(personC)} value is {personC}");
            Console.WriteLine("Reference is copied: Before changing values");
            Console.WriteLine($"{nameof(personClass)} value is {personClass}");

            personClass.Age = 59;
            Console.WriteLine("Reference is copied: After changing values");
            Console.WriteLine($"{nameof(personClass)} value is {personClass}");

            Console.WriteLine("Original Object: After changing values");
            Console.WriteLine($"{nameof(personC)} value is {personC}");

            Console.ReadLine();
        }

        private static void ValueType()//copies the whole value
        {
            var personC = new PersonStruct { Age = 24, Name = "Uncle Struct" };

            PersonStruct personStruct;
            personStruct = personC;//refeernce is copied


            Console.WriteLine("Original Object: Before changing values");
            Console.WriteLine($"{nameof(personC)} value is {personC}");
            Console.WriteLine("Reference is copied: Before changing values");
            Console.WriteLine($"{nameof(personStruct)} value is {personStruct}");

            personStruct.Age = 59;
            Console.WriteLine("Reference is copied: After changing values");
            Console.WriteLine($"{nameof(personStruct)} value is {personStruct}");

            Console.WriteLine("Original Object: After changing values");
            Console.WriteLine($"{nameof(personC)} value is {personC}");

            Console.ReadLine();
        }


        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        static void CreateNewCar(string[] args)
        {
            var corolla = new Car();
            var civic = new Car { Name = "Honda Civic", Year = 2010 };//object initializers syntax 
        }
    }
}


