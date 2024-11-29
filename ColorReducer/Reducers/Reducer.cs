using ColorReducer.Coloring;

namespace ColorReducer.Reducers
{
    internal abstract class Reducer
    {
        protected Palette _palette;

        public Reducer()
        {
            _palette = new Palette();
        }

        public virtual void Reduce(DirectBitmap bitmap, int amount)
        {
            GeneratePalette(bitmap, amount);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    var closestColor = _palette.GetClosestColor(color);

                    bitmap.SetPixel(x, y, closestColor);
                }
            }
        }

        protected abstract void GeneratePalette(DirectBitmap bitmap, int amount);
    }
}
