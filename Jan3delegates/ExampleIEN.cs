using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public class ExampleIEN
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();
            //IList<int> years = new List<int>();
            years.Add(1990);
            years.Add(2000);
            years.Add(2001);
            IEnumerable<int> ienu = years;// generic type or strongly typed means data type is int
            IEnumerable obj;//non generic collection where is type 
            foreach (var x in years) { Console.WriteLine(x); }
            IEnumerator<int> emrate = years.GetEnumerator();
            while (emrate.MoveNext()) { Console.WriteLine(emrate.Current); }
            List<Product> p = new List<Product>()
            {
                new Product(){ID=11 },//index 0
                new Product(){ID=12 },//index 1
            };
        }
    }
    public class Product { public int ID { get; set; } }
}
