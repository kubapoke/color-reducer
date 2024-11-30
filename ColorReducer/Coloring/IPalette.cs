using System.Numerics;

namespace ColorReducer.Coloring
{
    internal interface IPalette
    {
        public void AddColor(Color color);
        public Color GetClosestColor(Vector3 color);
        public Color GetClosestColor(Color color)
        {
            return GetClosestColor(new Vector3(color.R, color.G, color.B));
        }
        public void Clear();
    }
}
