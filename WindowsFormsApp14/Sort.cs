using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp14
{
    public class Sort
    {
        private GenerateArray ga;
        private int[] countArr1;

        public Sort()
        {
            Ga = new GenerateArray();
        }
        
        public GenerateArray Ga { get => ga; set => ga = value; }
        public int[] CountArr1 { get => countArr1; set => countArr1 = value; }



        public int[] Buble(int[] arr)
        {
            //int[] arr2 = new int[arr.Length];
            int[] arr2 = arr;
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        int a = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = a;
                    }
                }

            }
            return arr2;

        }



        public int[] ShakeSort(int[] arr)
        {
            int a;
            int l = 0;
            int r = arr.Length - 1;

            for (int i = l; i < r; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int t = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = t;
                }
            }
            r--;
            for (int i = r; i > l; i--)
            {
                if (arr[i] < arr[i - 1])
                {
                    a = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = a;
                }
            }
            l++;


            return arr;
        }

        public int[] SwitchSort(int[] mas)
        {
            int[] sortmas = new int[mas.Length];
            sortmas[0] = mas[0];
            int j = 0;
            for (int i = 1; i < sortmas.Length; i++)
            {
                int temp = mas[i];
                for (j = i - 1; j >= 0 && sortmas[j] > temp; j--)
                {
                    sortmas[j + 1] = sortmas[j];
                }
                sortmas[j + 1] = temp;
            }
            return sortmas;

        }
               
        
        public int[] CountSort(int[] mas)
        {
           
        int k = 0;
        int[] sortmas = new int[mas.Length];
        for (int i = 0; i < mas.Length; i++)
        {
            k = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[i] > mas[j])
                {
                    k++;
                }
            }
            sortmas[k] = mas[i];

        }
            
        return sortmas;
        }
            



        
        public int[] ExtractSort(int[] mas)
        {
        int[] sortmas = new int[mas.Length];
        mas.CopyTo(sortmas, 0);
        for (int i = 0; i < sortmas.Length-1; i++)
        {
            int min = sortmas[i];
            int tempindex=i;
            for (int j = i+1; j < sortmas.Length; j++)
            {
                if (sortmas[j]<min)
                {
                    tempindex = j;
                    min = sortmas[j];
                }
            }
            int temp = sortmas[tempindex];
            sortmas[tempindex] = sortmas[i];
            sortmas[i] = temp;

        }
        return sortmas;
        }










        /*
        public int[] ShakeSort(int[] arr)
        {
            int[] arr3 = new int[arr.Length];
            arr3 = arr;
            int r = 0;
            int count2 = 0;
            int count = 1;
            int wcheck = 0;
            bool ans = true;
            foreach (var item in arr3)
            {
                wcheck++;
                int i = count2;
                for (int j = count2 + 1; j < arr3.Length; j++)
                {
                    if (arr3[i] > arr3[j])
                    {
                        int a;
                        a = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = a;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                count++;
                int l = arr3.Length - (count + 1);
                for (int k = arr3.Length - count; k > 0; k--)
                {
                    if (arr3[k] < arr3[l])
                    {
                        int b;
                        b = arr3[k];
                        arr3[k] = arr3[l];
                        arr3[l] = b;
                        l--;
                    }
                    else
                    {
                        l--;
                    }
                }
                count2++;

                for (int s = r + 1; s < arr3.Length; s++)
                {
                    if (arr3[r] < arr3[s])
                    {
                        r++;
                        ans = true;
                        
                    }
                    else
                    {
                        ans = false;
                        break;
                    }
                    
                }
                if (ans == true)
                {
                    return arr3;
                }
                
            }
            return arr3;

        }
     
        public int[] Extract(int[] arr)
        {
            int[] nArr = new int[arr.Length];
            nArr = arr;
            int[] nArr2 = new int[nArr.Length];
            int count = 0;
            int index = 0;
            int numMax = nArr.Max();
            int[] nAr = new int[nArr.Length - 1];
            for (int i = 0; i < nAr.Length; i++)
            {
                nAr[i] = nArr[i];
            }
            for (int i = nAr.Length; i > 0; i--)
            {

                nAr[i] = numMax;
                for (int k = 0; k < nArr.Length; k++)
                {
                    if (nArr[k] != numMax)
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                numMax = nAr.Max();
                Array.Copy(nArr, 0, nAr, 0, (nArr.Length - (nArr.Length - index)));
                Array.Copy(nArr, index + 1, nAr, index, (nArr.Length - index-1));

            }
            while (nAr.Length > 0)
            {


            }


            return arr;
        }

        */


        /*
                public int[] Extract2(int[] arr)
                {
                    int[] nArr = new int[arr.Length];
                    nArr = arr;
                    int k = 0;
                    int numMax = nArr.Max();
                    int count = 1;
                    for (int i = 0; i < nArr.Length; i++)
                    {

                        int[] nArr2 = new int[nArr.Length - count];
                        for (int j = 0; j < nArr2.Length; )
                        {
                            if (nArr[k] == numMax)
                            {
                                k++;
                                continue;
                            }

                            else
                            {
                                nArr2[j] = nArr[k];
                                j++;
                            }

                            k++;

                        }
                        numMax = nArr2.Max();
                        count++;
                    }



                    return arr;
                }


            */



        /*        public int[] Buble(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            arr2 = arr;
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        int a = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = a;
                    }
                }

            }
            return arr2;

        }*/


    }

}

