﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L4_Training
{
    public class Persons
    {
        public string Id { get; }
        public string Name { get; }
        public string Surname { get; }

        public Persons(string _id, string _name, string _surname)
        {
            Id = _id;
            Name = _name;
            Surname = _surname;
        }

        

    }
}
