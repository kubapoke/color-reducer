using ColorReducer.Coloring;

namespace ColorReducer.Reducers
{
    internal class KMeansReducer : Reducer
    {
        protected int _eps, _maxIterations;

        public KMeansReducer(int amount, int eps, int max_iterations) : base(amount)
        {
            _eps = eps;
            _maxIterations = max_iterations;
        }

        protected override void GeneratePalette(DirectBitmap bitmap)
        {
            _palette.Clear();

            CentroidGroup group = new CentroidGroup(_amount, bitmap);

            for (int i = 0; i < _maxIterations; i++)
            {
                var maxMove = group.CenterCentroids();
                if (maxMove <= _eps)
                    break;
            }

            _palette = group.GeneratePalette();
        }
    }
}
