using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Reference_Vs_Value_Types
{
    //struct .. -> ValueType -> Object
    public struct PersonStruct//Value type
    {
        public int Age;
        public string Name;

        public override string ToString()
        {
            return $"Age is {Age} and Name is {Name}";
        }
    }
}
