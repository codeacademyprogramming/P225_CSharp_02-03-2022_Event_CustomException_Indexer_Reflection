using System;
using System.Collections.Generic;
using System.Text;

namespace P225Indexer
{
    class WrongIndexException : Exception
    {
        public WrongIndexException(string message) : base(message)
        {

        }
    }
}
