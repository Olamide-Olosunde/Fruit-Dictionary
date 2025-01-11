using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public abstract class Fruit
    {
        //protected string def = "This is a fruit";
        protected virtual string definition => "This is a fruit.";
        public string printDef()
        {
            //Console.WriteLine(definition);
            return definition;
        }
    }
}
