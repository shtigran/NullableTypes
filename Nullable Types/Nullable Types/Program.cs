using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            int? a = null;

            // Nullable type for valutype
            // Nullable types create instance from Nullable<T> generic type. And inherits the Hasvalue and Value properties.
            // That Hasvalue return boolean type, and indicate is the variable has value or not. And the Value propery allow take the value of 
            // variable or give the value

            // Example

            int b = 4;
            //b = a; It is false, but 
            a = b; //It is 



        }
    }
}
