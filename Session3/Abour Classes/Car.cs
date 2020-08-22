using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    //All classes derived implicitly or explicity from Object class
    public class Car
    {
        public static int CarsInMemory { get; set; }
        private int _year;
        public string Name { get; set; }
        public int Year //field backed properties //_year
        {
            get { return _year; }
            set
            {
                if (value >= 1950 && value <= DateTime.Now.Year)//make sure that the car is of current year or later model
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1950 and {DateTime.Now.Year}.");
                //A nameof expression produces the name of a variable, type, or member as the string constant
                _year = value;
            }
        }

        public Car()
        {
            CarsInMemory += 1;
        }
    }
}

//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof
//https://stackoverflow.com/questions/3890956/how-to-get-current-month-and-year
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
