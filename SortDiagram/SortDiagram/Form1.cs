using System;
using System.Windows.Forms;

namespace SortDiagram
{
    public partial class Form1 : Form
    {

        private readonly GraphPainter _painter;

        private int[] _datacolums;
        private BubbleSorter _sorter;


        public Form1()
        {

            InitializeComponent();

            _painter = new GraphPainter(chGraph);
        }

        private void btnGenerateNums_Click(object sender, EventArgs e)
        {


            _datacolums = new int[Convert.ToInt32(tbCountNumbers.Text)];

            tbNums.Text = "";

            Random random = new Random();

            for (int i = 0; i < _datacolums.Length; i++)
            {

                int num = random.Next(0, 99);
                _datacolums[i] = num;

                tbNums.Text += num + " ";
            }

            tbNums.Text = tbNums.Text.Trim();

            _painter.PaintGraph(_datacolums);

            _sorter = new BubbleSorter(_datacolums);
        }
       
        
        private void btnSort_Click(object sender, EventArgs e)
        {

            if (tbNums.Text.Length == 0 || _sorter == null) return;

            _datacolums = _sorter.Sort(chbInvers);

            _painter.PaintGraph(_datacolums);
         }

       
        private void btnNextStep_Click(object sender, EventArgs e)
        {

            if (tbNums.Text.Length == 0 || _sorter == null) return;

            _datacolums = _sorter.StepByStepSort();

            _painter.PaintGraph(_datacolums);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
