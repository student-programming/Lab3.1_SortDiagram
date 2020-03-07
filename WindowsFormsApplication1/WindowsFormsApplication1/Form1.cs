using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly GraphPainter _painter;
        private int[] _datacolumns;
        private BubbleSorter _sorter;
        public Form1()
        {
            InitializeComponent();
            _painter = new GraphPainter(chGraph);
        }

        private void bthGenerateNums_Click(object sender, EventArgs e)
        {
            _datacolumns = new int[Convert.ToInt32(tbCountNumbers.Text)];
            tbNums.Text = "";
            Random random = new Random();
            for (int i = 0; i < _datacolumns.Length; i++)
            {
                int num = random.Next(0, 99);
                _datacolumns[i] = num;
                tbNums.Text += num + " ";
            }
            tbNums.Text = tbNums.Text.Trim();
            _painter.PaintGraph(_datacolumns);
            _sorter = new BubbleSorter(_datacolumns);

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (tbNums.Text.Length == 0 || _sorter == null) return;
            _datacolumns = _sorter.Sort(chbinvers);
            _painter.PaintGraph(_datacolumns);
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (tbNums.Text.Length == 0 || _sorter == null) return;
            _datacolumns = _sorter.StepByStep();
            _painter.PaintGraph(_datacolumns);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
