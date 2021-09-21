using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmsVisualisation
{
    public partial class MainWindow : Form
    {
        int[] TheArray;
        Graphics g;


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {

            g = ActionPanel.CreateGraphics();
            int NumEntries = ActionPanel.Width;
            int MaxVal = ActionPanel.Height;
            TheArray = new int[NumEntries];


            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.GhostWhite), 0, 0, NumEntries, MaxVal);

            Random rand = new Random();

            for(int i = 0; i < NumEntries; i++) TheArray[i] = rand.Next(0, MaxVal);
            

            for (int i = 0; i < NumEntries; i++) g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen), i, MaxVal - TheArray[i], 1, MaxVal);
            

        }

        private void BubbleButton_Click(object sender, EventArgs e)
        {
            iSort sort = new BubbleSort();
            if(IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);
        }

        private void HeapButton_Click(object sender, EventArgs e)
        {
            iSort sort = new HeapSort();
            if (IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            iSort sort = new SelectionSort();
            if (IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);

        }


        private void QuickButton_Click(object sender, EventArgs e)
        {
            iSort sort = new QuickSort();
            if (IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);

        }

        private void InsertionButton_Click(object sender, EventArgs e)
        {
            iSort sort = new InsertionSort();
            if (IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);
        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            iSort sort = new MergeSort();
            if (IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);

        }

        private void RadixButton_Click(object sender, EventArgs e)
        {
            iSort sort = new RadixSort();
            if (IsSorted(TheArray) == false) sort.SortAlg(TheArray, g, ActionPanel.Height);
        }





        private bool IsSorted(int[] TheArray)
        {
            if (TheArray.Length == 0) return false;

            for (int i = 0; i < TheArray.Count() - 1; i++) if (TheArray[i] > TheArray[i + 1]) return false;
           
            return true;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
