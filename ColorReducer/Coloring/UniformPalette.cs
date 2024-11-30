using System.Numerics;

namespace ColorReducer.Coloring
{
    internal class UniformPalette : IPalette
    {
        private int _rAmount, _gAmount, _bAmount;

        public UniformPalette()
        {

        }

        public UniformPalette(int rAmount, int gAmount, int bAmount)
        {
            _rAmount = rAmount;
            _gAmount = gAmount;
            _bAmount = bAmount;
        }

        public void SetColorAmounts(int rAmount, int gAmount, int bAmount)
        {
            _rAmount = rAmount;
            _gAmount = gAmount;
            _bAmount = bAmount;
        }

        public void AddColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _rAmount = _gAmount = _bAmount = 0;
        }

        public Color GetClosestColor(Vector3 color)
        {
            if (_rAmount <= 0 || _gAmount <= 0 || _bAmount <= 0)
                throw new InvalidOperationException("Palette amounts must be greater than zero.");

            float rBinSize = 256f / _rAmount;
            float gBinSize = 256f / _gAmount;
            float bBinSize = 256f / _bAmount;

            int rIndex = Math.Clamp((int)((color.X + rBinSize / 2) / rBinSize), 0, _rAmount - 1);
            int gIndex = Math.Clamp((int)((color.Y + gBinSize / 2) / gBinSize), 0, _gAmount - 1);
            int bIndex = Math.Clamp((int)((color.Z + bBinSize / 2) / bBinSize), 0, _bAmount - 1);

            int rClosest = rIndex * (int)rBinSize;
            int gClosest = gIndex * (int)gBinSize;
            int bClosest = bIndex * (int)bBinSize;

            rClosest = Math.Clamp(rClosest, 0, 255);
            gClosest = Math.Clamp(gClosest, 0, 255);
            bClosest = Math.Clamp(bClosest, 0, 255);

            return Color.FromArgb(rClosest, gClosest, bClosest);
        }

    }
}
