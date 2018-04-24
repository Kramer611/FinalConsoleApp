using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Instructor:Person
    {
        //instructor inherits all properties from person

        //instructor specific properties
        public DateTime HireDate { get; set; }//property

        private string _rank; //private field

        public string Rank
        {
            get
            {
                int years = YearsOfWork(this.HireDate);
                if(years >= 25)
                {
                    _rank = Ranking.DistinguisedProfessor.ToString();
                }else if(years >= 20)
                {
                    _rank = Ranking.AssocicateProfessor.ToString();
                }else if (years >= 15)
                {
                    _rank = Ranking.AssistantProfessor.ToString();
                }else if (years >= 10)
                {
                    _rank = Ranking.AssistantProfessor.ToString();
                }else
                {
                    _rank = Ranking.Instructor.ToString();
                }
                return _rank;
            }
            set
            {
                _rank = value;
            }
        }
        //Ranking enumeration
        private enum Ranking : byte
        {
            Instructor = 1,
            AssistantProfessor = 2,
            AssocicateProfessor = 3,
            FullProfessor = 4,
            DistinguisedProfessor = 5
        }

        //method
        private static int YearsOfWork(DateTime HireDate)
        {
            DateTime now = DateTime.Today;//get the current date and time
            int yrsExp = now.Year - HireDate.Year;
            if (HireDate.AddYears(yrsExp) > now)
                yrsExp--;

            return yrsExp;
        }

        public string InstructorName
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
