using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp14
{
    
    class ProductiveSortes
    {
        private long tick = Stopwatch.Frequency;
        public delegate int[] SortMethod(int[] arr);
        public int[] arr;
        
        public double Perfomance(SortMethod method)
        {
            Stopwatch stP = new Stopwatch();
            stP.Start();
            method(arr);
            stP.Stop();
            return (double)stP.ElapsedTicks / tick * 1000;

        }

    }
    
}
