//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System;

namespace WMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            String readStr = Console.ReadLine();
            Console.WriteLine("you have input:" + readStr);
            outText();
        }

        static void outText()

        {
            Program1 p = new Program1();
            Console.WriteLine(p.outText());

            DynamicAndVar dv = new DynamicAndVar();
            Console.WriteLine(dv.outText());
        }
    }

    class Program1
    {
        public String outText()
        {
            Object o;
            o = 100L;
            o = "200";
            return "p1.outtext" + Convert.ToString(o.ToString());
        }
    }

    class DynamicAndVar
    {
        public String outText()
        {
            Object o;
            o = "oStr";
            dynamic d;
            d = 100;
            Program1 p = new Program1();
            var v = p;
            Console.WriteLine(o.GetType());
            Console.WriteLine(d.GetType());

            Console.WriteLine(v.GetType());

            return "DynamicAndVar.outtext" + ", o:" + o + ", d:" + d + ", v:" + v;
        }
    }
}

