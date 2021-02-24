using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab32
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool CanDrive => Age >= 16;

        public bool CanDrink => Age >= 21;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }
    }
}