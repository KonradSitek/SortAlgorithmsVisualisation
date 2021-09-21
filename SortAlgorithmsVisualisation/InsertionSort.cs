using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class InsertionSort : iSort
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

            sort(TheArray);

        }

        void sort(int[] TheArray)
        {
            int n = TheArray.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = TheArray[i];
                int j = i - 1;

                while (j >= 0 && TheArray[j] > key)
                {
                    TheArray[j + 1] = TheArray[j];


                    g.FillRectangle(Darker, j, 0, 1, MaxVal);
                    g.FillRectangle(Darker, j+1, 0, 1, MaxVal);


                    g.FillRectangle(Lighter, j, MaxVal - TheArray[j], 1, MaxVal);
                    g.FillRectangle(Lighter, j+1, MaxVal - TheArray[j+1], 1, MaxVal);


                    j = j - 1;
                }
                TheArray[j + 1] = key;
            }

        }



    }

}
