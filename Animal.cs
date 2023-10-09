using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public string _name { get; set; }
        public string _breed { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                if (value <= 0)
                {
                    Console.WriteLine("Age must be greater than 0");
                    return;
                }

            }
        }
    }
}
