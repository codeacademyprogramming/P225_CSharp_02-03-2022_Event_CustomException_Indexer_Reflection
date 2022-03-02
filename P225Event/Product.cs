using System;
using System.Collections.Generic;
using System.Text;

namespace P225Event
{
    class Product
    {
        public string Name { get; set; }
        private int _count;
        public int Count 
        {
            get => _count;
            set
            {
                _count = value;
                if (_count < 10)
                {
                    NotiFy += Write;
                    NotiFy -= Write1;
                    //NotiFy();

                }
                else if (_count < 50)
                {
                    NotiFy += Write1;
                    NotiFy -= Write2;
                    //NotiFy();

                }
                else if(_count < 85)
                {
                    NotiFy += Write2;
                    //NotiFy();

                }
            }
        }

        public void Write()
        {
            Console.WriteLine("Cox Azalib");
        }

        public void Write1()
        {
            Console.WriteLine("50 faiz azalib");
        }

        public void Write2()
        {
            Console.WriteLine("Biraz Azalib");
        }

        public event Action NotiFy
        {
            add
            {
                value.Invoke();
                Console.WriteLine(value.Method.Name);
            }
            remove
            {
                value.Invoke();
                //Console.WriteLine(value);
            }
        }

        public void Sell(int count)
        {
            Count = Count-count;
        }
    }
}
