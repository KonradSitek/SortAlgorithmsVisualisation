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


            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.DarkSlateGray), 0, 0, NumEntries, MaxVal);

            Random rand = new Random();

            for(int i = 0; i < NumEntries; i++) TheArray[i] = rand.Next(0, MaxVal);
            

            for (int i = 0; i < NumEntries; i++) g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen), i, MaxVal - TheArray[i], 1, MaxVal);
            

        }
    }
}
