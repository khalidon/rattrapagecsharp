using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string bt;
            string mn;
            Maison maison1 = new Maison(4, "sgb35");
           bt =  maison1.ToString();
            Batiment batiment1 = new Batiment("sgb35");
           mn = batiment1.ToString();
            Console.WriteLine(bt);
            Console.ReadLine();
        }
    }
}
