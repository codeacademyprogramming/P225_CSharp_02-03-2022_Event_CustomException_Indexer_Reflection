using System;
using System.Collections.Generic;
using System.Text;

namespace P225CustomException
{
    class StudentNotFoundException : Exception
    {
        //public string message { get; set; }
        //public override string Message => message;

        public StudentNotFoundException(string message) : base(message)
        {

        }

        public StudentNotFoundException(string message, StudentNotFoundException studentNotFoundException) : base(message, studentNotFoundException)
        {

        }
    }
}
