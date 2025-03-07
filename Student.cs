using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usama
{
    class Student
    {
        public string name;
        public int rollNumber;
        public double cgpa;
        
        public Student()
        {

        }
        public Student(string name, int rollNumber, double cgpa)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.cgpa = cgpa;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($@"Name:{name} 
Roll Number:{rollNumber} 
CGPA:{cgpa}
-------");
        }
    }
}
