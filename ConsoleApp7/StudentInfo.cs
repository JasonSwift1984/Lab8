using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class StudentInfo
    {
        public string Name;
        public string Hometown;
        public string Food;
        public string Color;

        public StudentInfo () {}

        public StudentInfo(string names)
        {
            Name = names;
        }

        public StudentInfo(string names, string foods)
        {
            Name = names;
            Food = foods;
        }

        public StudentInfo(string names, string foods, string homeTown)
        {
            Name = names;
            Food = foods;
            Hometown = homeTown;
           
        }

        public StudentInfo(string names, string foods, string homeTown, string colors)
        {
            Name = names;
            Food = foods;
            Hometown = homeTown;
            Color = colors;

        } 
    }
}
