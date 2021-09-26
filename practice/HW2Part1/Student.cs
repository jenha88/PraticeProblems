using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Part1
{
    public class Student
    {
        public string FirstNam { get; set; }
        public string LastNam { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }

        public Address Address { get; set; }

        public Student()
        {
            FirstNam = "";
            LastNam = "";
            Major = "";
            GPA = 0;
        }
        public Student(string firstName, string lastName, string major, double gpa)
        {
            firstName = FirstNam;
            lastName = LastNam;
            major = Major;
            gpa = GPA;
            Address = new Address(); 

        }
        public string CalculateDistinction()
        {
            string distinction;

            if (GPA >= 3.80 || GPA <= 4.00)
            {
                distinction = "Cum Laude";
            }
            else if (GPA <= 3.59 || GPA >= 3.40) 
            {
                distinction = "Magna Cum Laude";
            }
            else if (GPA <= 3.60 || GPA >= 3.37)
            {
                distinction = "Summa Cum Laude";
            }
            else 
            {
                distinction = "";

            }

            return distinction;

        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {

            Address = new Address(streetNumber, streetName, state, city, zipcode);   
        }

        public override string ToString()
        {
            return $" {FirstNam} {LastNam}, {Major} {CalculateDistinction()}";
        }
    }

}
