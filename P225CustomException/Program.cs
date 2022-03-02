using System;
using System.Collections.Generic;

namespace P225CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{ Name = "Test"},
                new Student{ Name = "Test1"},
                new Student{ Name = "Test2"},
                new Student{ Name = "Test3"},
                new Student{ Name = "Test4"}
            };

            Student student = students.Find(s => s.Name == "test");

            if (student == null)
            {
                throw new StudentNotFoundException("Student Tapilmadi", new StudentNotFoundException("Test"));
            }
        }
    }
}
