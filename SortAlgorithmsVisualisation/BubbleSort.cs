using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class BubbleSort : iSort
    {

        private bool _sorted = false;
        private int[] TheArray;
        private Graphics g;
        private int MaxVal;

        Brush Lighter = new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen);
        Brush Darker = new System.Drawing.SolidBrush(System.Drawing.Color.DarkSlateGray);
       



        public void SortAlg(int[] TheArray_In, Graphics g_In, int MaxVal_In)
        {

            TheArray = TheArray_In;
            g = g_In;
            MaxVal = MaxVal_In;

            while (!_sorted)
            {
                for (int i = 0; i < TheArray.Length - 1; i++)
                {


                    if (TheArray[i] > TheArray[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }
                _sorted = IsSorted();
            }

        }



        private async void Swap(int i, int p)
        {
            int temp = TheArray[i];
            TheArray[i] = TheArray[i + 1];
            TheArray[i + 1] = temp;


            g.FillRectangle(Darker, i, 0, 1, MaxVal);
            g.FillRectangle(Darker, p, 0, 1, MaxVal);

        


            g.FillRectangle(Lighter, i, MaxVal - TheArray[i], 1, MaxVal);
            g.FillRectangle(Lighter, p, MaxVal - TheArray[p], 1, MaxVal);


        }



        private bool IsSorted()
        {
            for (int i = 0; i < TheArray.Count() - 1; i++)
            {
                if (TheArray[i] > TheArray[i + 1]) return false;
            }

            return true;

        }



    }
}
