using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp14
{
    public class GenerateArray
    {
        /*
        private int[] a100 = new int[10];
        private int[] a500 = new int[50];
        private int[] a1000 = new int[100];
        
        private int[] a2500 = new int[250];
        
        private int[] a5000 = new int[500];
        public int[] A100 { get => a100; }
        public int[] A500 { get => a500; }
        public int[] A1000 { get => a1000; }
        public int[] A2500 { get => a2500; }
        public int[] A5000 { get => a5000; }
        */
        
        private int[] arr = new int[100000];
        public int[] Arr { get => arr; }


        public List<int[]> ListArrays { get; set; }
       
        public GenerateArray()
        {
            Generate();

            ListArrays = new List<int[]> 
            {
                Arr,
                A100,
                A500,
                A2500,
                A1000,
                A2500,
                A5000,
                
                
            };
        }


        private void Generate()
        {
            Random rand = new Random();

            for (int i = 0; i < ListArrays.Count; i++)
            {
                ListArrays[i][i] = i + 1;
            }
            for (int i = 0; i < ListArrays[i].Length; i++)
            {
                int tempIndex = rand.Next(0, ListArrays[i].Length);
                int temp = ListArrays[i][tempIndex];
                ListArrays[i][tempIndex] = ListArrays[i][i];
                ListArrays[i][i] = temp;
            }

            /*
            A100 = Arr.Take(100).ToArray();
            A500 = Arr.Take(500).ToArray();
            A1000 = Arr.Take(1000).ToArray();
            A2500 = Arr.Take(2500).ToArray();
            A5000 = Arr.Take(5000).ToArray();
            A10000 = Arr.Take(10000).ToArray();
            */
        }


        
    }

}
