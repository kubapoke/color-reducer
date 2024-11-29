using ColorReducer.Coloring;

namespace ColorReducer.Reducers
{
    internal abstract class Reducer
    {
        protected int _amount;
        protected Palette _palette;

        public Reducer(int amount)
        {
            _amount = amount;
            _palette = new Palette();
        }

        public virtual Bitmap Reduce(Bitmap bitmap)
        {
            DirectBitmap directBitmap = new DirectBitmap(bitmap);
            GeneratePalette(directBitmap);

            for (int x = 0; x < directBitmap.Width; x++)
            {
                for (int y = 0; y < directBitmap.Height; y++)
                {
                    var color = directBitmap.GetPixel(x, y);
                    var closestColor = _palette.GetClosestColor(color);

                    directBitmap.SetPixel(x, y, closestColor);
                }
            }

            return directBitmap.Bitmap;
        }

        protected abstract void GeneratePalette(DirectBitmap bitmap);
    }
}
