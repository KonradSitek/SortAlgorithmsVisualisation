using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class QuickSort : iSort
    {
        private bool _sorted = false;
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

            while (!_sorted)
            {
                quick_sort(TheArray, 0, TheArray.Length - 1);
                _sorted = IsSorted();
            }
            quick_sort(TheArray, 0, TheArray.Length - 1);

        }

        public void quick_sort(int[] TheArray, int left, int right)
        {
            if (right <= left) return;

            int i = left - 1, j = right + 1,
                pivot = TheArray[(left + right) / 2];


            int qwe = 1;
            while (qwe > 0)
            {
                while (pivot > TheArray[++i]) ;

                while (pivot < TheArray[--j] && j > 1) ;
              

              
                if (i <= j)
                    Swap(i, j);

                else break;
            }
            if (j > left) quick_sort(TheArray, left, j);
            if (i < right) quick_sort(TheArray, i, right);

        }

        private void Swap(int i, int p)
        {
            int temp = TheArray[i];
            TheArray[i] = TheArray[p];
            TheArray[p] = temp;

          

            g.FillRectangle(Darker, i, 0, 1, MaxVal);
            g.FillRectangle(Darker, p, 0, 1, MaxVal);


            g.FillRectangle(Lighter, i, MaxVal - TheArray[i], 1, MaxVal);
            g.FillRectangle(Lighter, p, MaxVal - TheArray[p], 1, MaxVal);
        }

       

        private bool IsSorted()
        {
            for (int i = 0; i < TheArray.Count() - 1; i++) if (TheArray[i] > TheArray[i + 1]) return false;
            
            return true;

        }
    }
}
