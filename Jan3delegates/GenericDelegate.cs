using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public class GenericDelegate
    {// declare func,action,predicate method 
        public static double Func_addition(int n1, float n2, double n3)
        {
            return n1 + n2 + n3;
        }
        public static void Action_Addition(int n1, float n2, double n3) { Console.WriteLine("Action delegate is called   " + (n1 + n2 + n3)); }
        public static bool Predicate_Length(string name) { if (name.Length <= 5) return false; return true; }
        static void Main(string[] args)
        {// call or invoke
            Func<int, float, double, double> f_delegate = new Func<int, float, double, double>(Func_addition);
            double res = f_delegate(3, 123.45f, 123.54); //f_delegate.Invoke(,,,);
            Console.WriteLine(" Func delegate invoke " + res);
            Action<int, float, double> a_delagete = new Action<int, float, double>(Action_Addition);
            a_delagete(9, 9.89f, 67.89);
            Predicate<string> p_delegate = new Predicate<string>(Predicate_Length);
            bool b = p_delegate("Mphasis");
            Console.WriteLine(" predicate delegate with string " + b);
        }
    }
}
