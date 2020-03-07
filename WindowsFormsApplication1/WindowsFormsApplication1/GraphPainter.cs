using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    class GraphPainter
    {
        // обЪявляем переменную
        private readonly Chart _chart;

        // метод-конструктор класса
        public GraphPainter(Chart chart)
        {
            // переменая _chart принимает данные chart,
            // переданные из другого класса
            _chart = chart;
        }

        // метод отрисовки данных на диаграмме
        public void PaintGraph(int[] nums)
        {
            // очищаем точки (столбцы) на диаграмме
            _chart.Series[0].Points.Clear();
            // для каждого элемента в массиве данных
            foreach (int num in nums)
            {
                // добавляем точку (столбец) на диаграмму
                _chart.Series[0].Points.Add(num);
                // узнаём порядковый номер точки (столбца)
                int count = _chart.Series[0].Points.Count;
                // задаём точке (столбцу) цвет
                _chart.Series[0].Points[--count].Color = ColorPoint(num);
            }
        }
        // метод задания цвета точкам (столбцам) на диаграмме
        private Color ColorPoint(int num)
        {
            if (num < 7) return Color.Yellow;
            if (num < 14) return Color.Blue;
            if (num < 21) return Color.Green;
            if (num < 28) return Color.LightBlue;
            if (num < 35) return Color.MediumPurple;
            if (num < 42) return Color.AntiqueWhite;
            if (num < 49) return Color.Aquamarine;
            if (num < 56) return Color.Bisque;
            if (num < 63) return Color.Indigo;
            if (num < 70) return Color.Brown;
            if (num < 77) return Color.Coral;
            if (num < 84) return Color.DarkBlue;
            if (num < 91) return Color.DarkGoldenrod;
            return Color.LightPink;
        }
    }
}
