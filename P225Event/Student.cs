using System;
using System.Collections.Generic;
using System.Text;

namespace P225Event
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public event Action Notify;
        //{
        //    add
        //    {

        //    }
        //    remove
        //    {

        //    }
        //}

        public void Check()
        {
            if (Grade < 60)
            {
                Notify();
            }
        }
    }
}
