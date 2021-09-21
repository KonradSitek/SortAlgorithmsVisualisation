using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class RadixSort : iSort
    {

       
        private int[] TheArray;
        private Graphics g;
        private int MaxVal;
        Brush Lighter = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
        Brush Darker = new System.Drawing.SolidBrush(System.Drawing.Color.GhostWhite);

        public void SortAlg(int[] TheArray_In, Graphics g_In, int MaxVal_In)
        {
            TheArray = TheArray_In;
            g = g_In;
            MaxVal = MaxVal_In;

            radixsort(TheArray,TheArray.Length-1);

        }

        private int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        private void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; 
            int i;
            int[] count = new int[10];

            
            for (i = 0; i < 10; i++)
                count[i] = 0;

           
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

          
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            
            for (i = 0; i < n; i++)
            {
                arr[i] = output[i];



                g.FillRectangle(Darker, i, 0, 1, MaxVal);

                g.FillRectangle(Lighter, i, MaxVal - TheArray[i], 1, MaxVal);

               
            }
                
        }

        private void radixsort(int[] arr, int n)
        {
            
            int m = getMax(arr, n);

          
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }





    }
}
