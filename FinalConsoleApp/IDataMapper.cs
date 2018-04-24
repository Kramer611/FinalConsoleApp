using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    internal interface IDataMapper<T>
    {
        /*
         * T in <T>
         * a generic type parameter allows you to specify and arbitrary type "T" to a method a
         * compile_time, without specifying a concrete type in the method or class declaration
         * 
         */

        List<T> Select();
        List<T> Find(string LastName);
    }
}
