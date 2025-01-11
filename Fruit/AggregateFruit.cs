using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public abstract class AggregateFruit : CompoundFruit
    {
        protected override string definition => base.definition + " This is an aggregate fruit.";
        public string printDef()
        {
            //Console.WriteLine(definition);
            return definition;
        }
    }
}
