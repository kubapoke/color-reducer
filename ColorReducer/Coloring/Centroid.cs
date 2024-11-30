using System.Collections.Concurrent;
using System.Numerics;

namespace ColorReducer.Coloring
{
    internal class Centroid
    {
        public Color Color { get; set; }
        private ConcurrentBag<Color> _colors;

        public Centroid(Color color)
        {
            _colors = new ConcurrentBag<Color>();
            Color = color;
        }

        public void Clear()
        {
            _colors.Clear();
        }

        public void AddColor(Color color)
        {
            _colors.Add(color);
        }

        public double MoveToMassCenter()
        {
            if (_colors.Count == 0)
                return 0;

            Vector3 colorAverage = new Vector3(0, 0, 0);

            foreach (var color in _colors)
            {
                colorAverage += new Vector3(color.R, color.G, color.B);
            }

            colorAverage /= _colors.Count;

            Color newColor = Color.FromArgb((int)colorAverage.X, (int)colorAverage.Y, (int)colorAverage.Z);

            int RDiff = newColor.R - Color.R;
            int GDiff = newColor.G - Color.G;
            int BDiff = newColor.B - Color.B;

            Color = newColor;

            return Math.Sqrt(RDiff * RDiff + GDiff * GDiff + BDiff * BDiff);
        }
    }
}
