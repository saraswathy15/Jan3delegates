using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public class TestDelegate
    {
        public delegate double FirstDel(double x, double y);//step1
        public delegate void SendDel(string s);
        public static void Msg(string s) { }
        public static double Adding(double n1, double n2) { return n1 + n2; }//step2
        public static double Substract(double num1, double num2) { return num1 - num2; }//step2
        static void Main(string[] args)
        {
            FirstDel obj;//step3 24 bytes memory is allocated 
            //TestDelegate.Substract(9.9, 4.5);
            obj = Adding;// obj is storing address of adding()//step 4
            double res = obj.Invoke(4.5, 5.5); Console.WriteLine("adding ()  {0}", res);//step5 
            obj = Substract;
            double ans = obj.Invoke(4.5, 5.5); Console.WriteLine("substract()  {0}", ans);
            // obj = Msg; error no match
            SendDel ob = Msg;
        }
    }
}
