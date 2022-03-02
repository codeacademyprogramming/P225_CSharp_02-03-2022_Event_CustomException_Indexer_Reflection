using System;
using System.Collections.Generic;

namespace P225Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            strList.Add("test");

            strList[12] = "P225";

            MyList myList = new MyList();
            //myList.Add("Hello");

            myList[8] = "World";

            Console.WriteLine(myList[12]);
        }
    }
}