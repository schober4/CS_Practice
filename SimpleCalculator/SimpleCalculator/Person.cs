﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Person
    {
        private int _age = 25;

        public int getAge()
        {
            return _age;
        }

        public void setAge(int newAge)
        {
            _age = newAge;
        }
    }
}
