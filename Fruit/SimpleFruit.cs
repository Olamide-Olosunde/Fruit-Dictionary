using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public abstract class SimpleFruit : Fruit
    {
        //protected override string definition
        //{
        //    get { return base.definition + "This is a simple fruit"; }
        //}
        //protected override string definition => base.definition + ". This is a simple fruit";
        protected override string definition => "This is a simple fruit.";// + "\n" + "";
        public string printDef()
        {
            //Console.WriteLine();
            return definition;
        }
    }
}
