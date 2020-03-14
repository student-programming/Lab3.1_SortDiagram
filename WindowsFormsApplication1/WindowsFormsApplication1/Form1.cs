using System;
using System.Windows.Forms;


namespace SortDiagram
{
    public partial class Form1 : Form
    {
        private readonly GraphPainter _painter;
        private int[] _datacoloumns;
        private BubbleSorter _sorter;
        public Form1()
        {
            InitializeComponent();
            _painter = new GraphPainter(chGraph);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateNums_Click(object sender, EventArgs e)
        {
            _datacoloumns = new int[Convert.ToInt32(tbCountNumbers.Text)];
            tbNums.Text = "";
            Random random = new Random();
            for (int i = 0; i < _datacoloumns.Length; i++)
            {
                int num = random.Next(0, 99);
                _datacoloumns[i] = num;
                tbNums.Text += num + " ";
            }
            tbNums.Text = tbNums.Text.Trim();
            _painter.PaintGraph(_datacoloumns);
            _sorter = new BubbleSorter(_datacoloumns);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (tbNums.Text.Length == 0 || _sorter == null) return;
            _datacoloumns = _sorter.Sort(chbInvers);
            _painter.PaintGraph(_datacoloumns);

        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (tbNums.Text.Length == 0 || _sorter == null) return;
            _datacoloumns = _sorter.StepByStepSort();
            _painter.PaintGraph(_datacoloumns);

        }
    }
}
