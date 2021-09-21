using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class SelectionSort : iSort
    {
     
        private int[] TheArray;
        private Graphics g;
        private int MaxVal;

        Brush LightSeaGreenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
        Brush DarkSlateGrayBrush = new System.Drawing.SolidBrush(System.Drawing.Color.GhostWhite);


        public void SortAlg(int[] TheArray_In, Graphics g_In, int MaxVal_In)
        {
            TheArray = TheArray_In;
            g = g_In;
            MaxVal = MaxVal_In;


            

                int mn_index;

                for (int i = 0; i < TheArray.Length - 1; i++)
                {
                    mn_index = i;
                    for (int j = i + 1; j < TheArray.Length; j++)
                        if (TheArray[j] < TheArray[mn_index])
                            mn_index = j;

                    

                    Swap(i, mn_index);

                }

              
            

            
        }
        private void Swap(int i, int mn_index)
        {
            int temp = TheArray[i];
            TheArray[i] = TheArray[mn_index];
            TheArray[mn_index] = temp;


            g.FillRectangle(DarkSlateGrayBrush, i, 0, 1, MaxVal);
            g.FillRectangle(DarkSlateGrayBrush, mn_index, 0, 1, MaxVal);

            g.FillRectangle(LightSeaGreenBrush, i, MaxVal - TheArray[i], 1, MaxVal);
            g.FillRectangle(LightSeaGreenBrush, mn_index, MaxVal - TheArray[mn_index], 1, MaxVal);

        }


       
    }

    
}
