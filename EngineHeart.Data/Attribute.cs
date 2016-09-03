﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Attribute
    {
        public string Name { get; set; }
        public int Value { get; private set; }
        
        public Attribute(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }

        public int GenerateValue(Random r)
        {
            Value = r.Next(1, 6);
            return ((Value*(Value+1))/2);
        }


    }
}