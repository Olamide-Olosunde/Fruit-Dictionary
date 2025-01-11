using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public class AcheneFruit : AggregateFruit
    {
        protected override string definition => base.definition + "\n" + "This is an achene fruit.";
        public string printDef()
        {
            //Console.WriteLine(definition);
            return definition;
        }
    }
}
