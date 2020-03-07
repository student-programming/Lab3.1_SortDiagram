using System;
using System.Windows. Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //переменная для работы с диаграммой
        private readonly GraphPainter _painter;
        // переменные для работы с данными
        private int[] _datacolumns;
        private Bubblesorter _sorter;

        //метод-конструктор класса 
        public Form1()
        {
            //инициализация компонентов формы при ее создании
            InitializeComponent();
            //создание объекта для диаграммы
            _painter = new GraphPainter(chGraph);
        }

        //метод генерации данных
        private void btnGeneraterNums_Click(object sender,EventArgs e)
        {
            //объявляем массив с количеством элементов, заданным в tbCountNumbers
            _datacolumns = new int[Convert.ToInt32(tbCountNumbers.Text)];
            // очищаем текст в компоненте tbNums
            tbNums.Text = " ";
            //создаем объект для генерации чисел
            Random random = new Random();
            //заполняем массив _detacomns случайными сислами 
            for (int i = 0; i < _datacolumns. Length; i++)
            {
                //случайные числа из пиапазона от 0 до 99
                int num = random.Next(0,99);
                _datacolumns[i] = num;
                //записываем сгенерированные числа через пробел в tbNums
                tbNums.Text += num + " ";
            }
            // необходимо убрать лишний пробел в конце строки 
            tbNums.Text = tbNums.Text.Trim();
            // вызываем метод рисования столбцов на диограмме
            _painter.PaintGraph(_datacolumns);
            // создаем обьект для сортировки в дальнейшем
            _sorter = new Bubblesorter(_datacolumns);
        }

        // метод сортировки данных
        private void btnSort_Clisk(object sender, EventArgs e)
        {
            // если данных нет - то выходим из метода
            if (tbNums.Text.Length == null) return;
             // если данных есть - сортируем их
            _datacolumns = _sorter.Sort(chbInvers);
            // и выводим отсортированные данные на диаграмму
            _painter.PaintGraph(_datacolumns);
        }

        // метод пошаговой сортировки данных
        private void btNextStep_Click(object sender, EventArgs e)
        {
            // если данных нет - то выходим из метода
            if (tbNums.Text.Length == 0 || _sorter ==null) return;
             // если данных есть - изменяем их пошагово
            _datacolumns = _sorter.StepbyStepsort();
                // и каждый шаг отображаем на диаграмме
                _painter.PaintGraph(_datacolumns);
        }
    }
}



       