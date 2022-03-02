using System;
using System.Collections.Generic;
using System.Text;

namespace P225Indexer
{
    class MyList
    {
        private string[] _arr;

        public MyList()
        {
            _arr = new string[10];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }

        public string this[int index]
        {
            get
            {
                if (index >=0 && index < _arr.Length)
                {
                    return _arr[index];
                }

                throw new WrongIndexException("Get Elemey Isdediyniz Index Yanlisdir");
            }
            set
            {
                if (index >= 0 && index < _arr.Length)
                {
                    _arr[index] = value;
                    return;
                }

                throw new WrongIndexException("Set Elemey Isdediyniz Index Yanlisdir");
            }
        }
    }
}
