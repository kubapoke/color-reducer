using ColorReducer.Coloring;
using System.Numerics;

namespace ColorReducer.Reducers
{
    internal class UncertaintyPropagationReducer : Reducer
    {
        private int _rAmount, _gAmount, _bAmount;
        private readonly float[,] _propagationMatrix = { { 0, 0, 0 }, { 0, 0, 7f / 16f }, { 3f / 16f, 5f / 16f, 1f / 16f } };
        private readonly int fX = 1, fY = 1;

        public UncertaintyPropagationReducer(int rAmount, int gAmount, int bAmount) : base(0)
        {
            _rAmount = rAmount;
            _gAmount = gAmount;
            _bAmount = bAmount;
        }

        public override Bitmap Reduce(Bitmap bitmap)
        {
            DirectBitmap directBitmap = new DirectBitmap(bitmap);
            GeneratePalette(directBitmap);

            int width = directBitmap.Width;
            int height = directBitmap.Height;

            Vector3[,] colors = new Vector3[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var color = directBitmap.GetPixel(x, y);
                    colors[x, y] = new Vector3(color.R, color.G, color.B);
                }
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var color = _palette.GetClosestColor(colors[x, y]);
                    Vector3 error = new Vector3(colors[x, y].X - (float)color.R, colors[x, y].Y - (float)color.G, colors[x, y].Z - (float)color.B);

                    for (int i = -fX; i <= fX; i++)
                    {
                        for (int j = -fY; j <= fY; j++)
                            if (x + i >= 0 && x + i < width && y + j >= 0 && y + j < height)
                                colors[x + i, y + j] += error * _propagationMatrix[fX + i, fY + j];
                    }

                    directBitmap.SetPixel(x, y, color);
                }
            }

            return directBitmap.Bitmap;
        }

        protected override void GeneratePalette(DirectBitmap bitmap)
        {
            _palette = new UniformPalette(_rAmount, _gAmount, _bAmount);
        }
    }
}
