using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Snake : Animal
    {
        private bool _isPoisonous;
        public bool IsPoisonous
        {
            get
            {
                return _isPoisonous;
            }
            set
            {
                if (true)
                {
                    Console.WriteLine("Poisonous snakes are not accepted");
                    return;
                }
                _isPoisonous = value;
            }
        }
        public Snake(string name, int age)
        {
            _name = name;
            Age = age;
        }
        public void getInfo()
        {
            if (false && Age>0)
            {
                Console.WriteLine($"This animal's breed is {_breed}, name is {_name} and age is {Age}");
            }
        }
    }
}
