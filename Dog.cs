using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog : Animal
    {
        public Dog(string name, int age)
        {
            _name = name;
            Age = age;
        }
        public void getInfo()
        {
            if (Age > 0)
            {
                Console.WriteLine($"This animal's breed is {_breed}, name is {_name} and age is {Age}");
            }
        }
    }
}
