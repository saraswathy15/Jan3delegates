using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public class FirstDelAnLambda
    {
        // public delegate double CalAreaPointer(double r);
        //  static double CalculateArea(double n) { return 3.14 * n * n; }
        static void Main(string[] args)
        {
            //  CalAreaPointer cp = CalculateArea;
            //  double area = cp.Invoke(3.5);
            //   Console.WriteLine("area calculated with delegate way "+area);
            //CalAreaPointer cp = new CalAreaPointer(delegate (double x)
            //{   //    return 3.14 * x * x;         //});
            //double area = cp.Invoke(3.5);// cp(3.5);
            //Console.WriteLine(" anonymous methods to calculate area "+area);
            // CalAreaPointer cp = abc => 3.14 * abc * abc;
            // double area = cp(3.5);
            // Console.WriteLine("lambda expression   area "+area);
            Func<double, double> cp = abc => 3.14 * abc * abc;// lambda type
            double area = cp(3.5);
            Console.WriteLine(" func  is generic delegate " + area);
            Console.ReadLine();
        }
    }
}
