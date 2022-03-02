using System;
using System.Collections.Generic;
using System.Text;

namespace P225ReflectionLibraryLibrary
{
    public class Student
    {
        public string Ad { get; set; }
        public string SurName;
        private int Age;
        private static int _count;

        public void Write(string str, int a)
        {
            Console.WriteLine(str+" "+a);
        }

        public void Write1(string str, int a)
        {
            Console.WriteLine(str + " " + a);
        }
    }
}
