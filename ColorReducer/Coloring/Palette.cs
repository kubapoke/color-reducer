namespace ColorReducer.Coloring
{
    internal class Palette
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

        public Color GetClosestColor(Color color)
        {
            if (_colors.Count == 0)
                return Color.Transparent;

            int distance = int.MaxValue;
            int R = color.R;
            int G = color.G;
            int B = color.B;
            Color closestColor = _colors[0];

            foreach (Color c in _colors)
            {
                int distR = (R - c.R) * (R - c.R);
                int distG = (G - c.G) * (G - c.G);
                int distB = (B - c.B) * (B - c.B);
                int distSum = distR + distG + distB;

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
