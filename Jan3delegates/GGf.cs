using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public abstract class GGF { public abstract void Fun1(); }
    public class GF : GGF { public sealed override void Fun1() { Console.WriteLine(" am direct child class"); } }
    public class F : GF
    {
        static void Main(string[] args)
        {
            F obj = new F(); obj.Fun1();// accessed but not allowed to override
        }
    }
}
