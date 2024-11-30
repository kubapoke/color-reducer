using System.Numerics;

namespace ColorReducer.Coloring
{
    internal class Palette : IPalette
    {
        private List<Color> _colors;

        public Palette()
        {
            _colors = new List<Color>();
        }

        public Palette(List<Color> colors)
        {
            _colors = colors.ToList();
        }

        public void AddColor(Color color)
        {
            _colors.Add(color);
        }

        public Color GetClosestColor(Vector3 color)
        {
            if (_colors.Count == 0)
                return Color.Transparent;

            float distance = float.MaxValue;
            float R = color.X;
            float G = color.Y;
            float B = color.Z;
            Color closestColor = _colors[0];

            foreach (Color c in _colors)
            {
                float distR = (R - c.R) * (R - c.R);
                float distG = (G - c.G) * (G - c.G);
                float distB = (B - c.B) * (B - c.B);
                float distSum = distR + distG + distB;

                if (distSum < distance)
                {
                    distance = distSum;
                    closestColor = c;
                }
            }

            return closestColor;
        }

        public void Clear()
        {
            _colors.Clear();
        }
    }
}
