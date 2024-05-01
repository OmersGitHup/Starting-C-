using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodswithClass
{
    internal class Calculator
    {
        public int sum(int n1,int n2)
        {
            int n3=n1+n2;
            Console.WriteLine(n3);
            return n3;
        }

        public int xQuare(int x)
        {
            int a2 = x * x;
            Console.WriteLine("Karesi: "+a2);
            
            return a2; // x karesini döndür
        }

    }
}
