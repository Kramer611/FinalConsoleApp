using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalConsoleApp
{
    public class InstructorDataMapper : IDataMapper<Instructor>
    {
        private string path;
        public InstructorDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Instructors.txt";
        }

        private List<Instructor> GetInstructors()
        {
            List<Instructor> instructor = new List<Instructor>();
            //read from Students.txt using the system.IO
            if (File.Exists(path)) ;
            {
                var sr = new StreamReader(path);
                string line;
                //read each line in Instructor.txt and  populate a new Instructor object with values from
                //line within the file
                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(",");//create array from CSV (coma seperated value)
                    var instructors = new Instructor
                    {
                        ID = Int16.Parse(elems[0]),
                        FirstName = elems[1],
                        LastName = elems[2],
                        Address = elems[3],
                        City = elems[4],
                        Province = elems[5],
                        PostalCode = elems[6],
                        Phone = elems[7],
                        Email = elems[8],
                        HireDate = DateTime.Parse(elems[9])
                        
                    };
                    //add each new student (one for each line in Instructor.txt) to the list 
                    instructor.Add(instructors);
                }
            }

            return instructor;
        }


        public List<Instructor> Find(string LastName)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> Select()
        {
            return GetInstructors();
        }
    }
}
