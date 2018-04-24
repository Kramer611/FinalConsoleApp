using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Student:Person
    {
        // the : is the inheritance symbol
        //student is inheriting all the properties from Person

        //student specific properties
        public DateTime EnrollDate { get; set; }
        public string Major { get; set; }

        //read only property
        public string StudentName
        {
            get
            {
                return FirstName + " " + LastName;
                //or 
                //return LastName + ", " + FirstName;
            }
        }
    }
}
