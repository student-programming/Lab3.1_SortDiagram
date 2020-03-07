using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortDiagram
{
    class GraphPainter
    {

        private readonly Chart _chart;


        public GraphPainter(Chart chart)
        {


            _chart = chart;
        }


        public void PaintGraph(int[] nums)
        {

            _chart.Series[0].Points.Clear();

            foreach (int num in nums)
            {

                _chart.Series[0].Points.Add(num);

                int count = _chart.Series[0].Points.Count;

                _chart.Series[0].Points[--count].Color = ColorPoint(num);
            }
        }


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






























