using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmonicFunction
{
    public class HarmonicFunction
    {
        public static void AHarmonicFunction() 
        {
            int i, n;
            double s = 0.0;
            Console.Write("\n\n");
            Console.WriteLine("Calculate the n th number of Harmonic function");
            Console.WriteLine("input the number of terms of harmonic :");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) 
            {
                Console.Write(" 1/{0}+ ", i);
                s+=1/(float)i;
            }
            Console.WriteLine("sum of Series upto {0} terms :{1}" ,n,s);
            
           
            
        }
    }
}
