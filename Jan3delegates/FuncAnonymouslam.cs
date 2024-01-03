using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public class FuncAnonymouslam
    {
        public static double Add2Numbers(double a, double b) { return a + b; }
        static void Main(string[] args)
        {
            Func<double, double, double> t1 = Add2Numbers;
            double res = t1(2.3, 3.4);
            Console.WriteLine(res);
            // anonymous method way 
            Func<double, double, double> t2 = delegate (double n1, double n2) { return n1 + n2; };
            double ans = t2(4.5, 5.5);
            Console.WriteLine(" Func in Anonymous way " + ans);
            // func in lambda way
            Func<double, double, double> t3 = (double n1, double n2) => (n1 + n2);
            double result = t3(5.5, 6.5);
            Console.WriteLine("func in lambda way " + result);
        }
    }
}
