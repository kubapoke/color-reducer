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

            int width = directBitmap.Width;
            int height = directBitmap.Height;

            Parallel.For(0, width * height, i =>
            {
                int x = i % width;
                int y = i / width;

                var color = directBitmap.GetPixel(x, y);
                var closestColor = _palette.GetClosestColor(color);

                directBitmap.SetPixel(x, y, closestColor);
            });

            return directBitmap.Bitmap;
        }

        protected abstract void GeneratePalette(DirectBitmap bitmap);
    }
}
