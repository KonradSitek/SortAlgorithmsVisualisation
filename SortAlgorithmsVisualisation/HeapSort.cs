using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualisation
{
    class HeapSort : iSort
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
                heapSort(TheArray, TheArray.Length);
                _sorted = IsSorted();
            }

        }

        private void heapify(int[] TheArray, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && TheArray[l] > TheArray[largest])
                largest = l;

            if (r < n && TheArray[r] > TheArray[largest])
                largest = r;

            if (largest != i)
            {
                Swap(i, largest);


                heapify(TheArray, n, largest);
            }


        }


        private void heapSort(int[] TheArray, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(TheArray, n, i);


            for (int i = n - 1; i > 0; i--)
            {

                Swap(0, i);

                heapify(TheArray, i, 0);
            }


        }

        private async void Swap(int i, int largest)
        {
            int temp = TheArray[i];
            TheArray[i] = TheArray[largest];
            TheArray[largest] = temp;


            g.FillRectangle(Darker, i, 0, 1, MaxVal);
            g.FillRectangle(Darker, largest, 0, 1, MaxVal);



            g.FillRectangle(Lighter, i, MaxVal - TheArray[i], 1, MaxVal);
            g.FillRectangle(Lighter, largest, MaxVal - TheArray[largest], 1, MaxVal);

          

        }

        private bool IsSorted()
        {
            for (int i = 0; i < TheArray.Count() - 1; i++) if (TheArray[i] > TheArray[i + 1]) return false;
          
            return true;

        }
    }


}

