using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public class IndehiscentFruit : DryFruit
    {
        protected override string definition => base.definition + "\n" + "This is an indehiscent fruit.";
        public string printDef()
        {
            //Console.WriteLine(definition);
            return definition;
        }
    }
}
