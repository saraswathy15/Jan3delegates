using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3delegates
{
    public class CityClass
    {
        private string[] cities = new string[10];
        // to declare an indexer
        public string this[int i]
        {
            get { return cities[i]; }
            set { cities[i] = value; }
        }
    }//
    public class TestCity
    {
        static void Main(string[] args)
        {
            CityClass cc = new CityClass();
            cc[0] = "New Delhi";
            cc[1] = "Mumbai";
            cc[2] = "kolkatta";
            cc[3] = "Chennai";
            Console.WriteLine("{0}\t{1}\t{2}", cc[0], cc[1], cc[2]);
            for (int i = 0; i < 10; i++) { Console.WriteLine(cc[i]); }
        }
    }
}
