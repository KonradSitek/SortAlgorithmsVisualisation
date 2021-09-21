using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class MergeSort : iSort
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


            sort(TheArray, 0, TheArray.Length - 1);

        }

        private void  merge(int[] TheArray, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;


            for (i = 0; i < n1; ++i)
                L[i] = TheArray[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = TheArray[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    TheArray[k] = L[i];

                    g.FillRectangle(Darker, k, 0, 1, MaxVal);
                    g.FillRectangle(Lighter, k, MaxVal - TheArray[k], 1, MaxVal);
                   
                    i++;
                }
                else
                {
                    TheArray[k] = R[j];


                    g.FillRectangle(Darker, k, 0, 1, MaxVal);
                    g.FillRectangle(Lighter, k, MaxVal - TheArray[k], 1, MaxVal);
                   

                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                TheArray[k] = L[i];
                i++;
                k++;
            }


            while (j < n2)
            {
                TheArray[k] = R[j];
                j++;
                k++;
            }
        }

        void sort(int[] TheArray, int l, int r)
        {
            if (l < r)
            {
                
                int m = l + (r - l) / 2;
              

                sort(TheArray, l, m);
                sort(TheArray, m + 1, r);

                merge(TheArray, l, m, r);


                
            }
        }



    }
}
