﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public abstract class DryFruit : SimpleFruit
    {
        protected override string definition => base.definition + " This is a dry fruit.";
        public string printDef()
        {
            //Console.WriteLine(definition);
            return definition;
        }
    }
}
