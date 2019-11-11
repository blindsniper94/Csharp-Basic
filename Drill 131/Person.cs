﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_131
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }
        public virtual void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
