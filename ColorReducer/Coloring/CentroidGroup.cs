namespace ColorReducer.Coloring
{
    internal class CentroidGroup
    {
        private DirectBitmap _image;
        private List<Centroid> _centroids;

        public CentroidGroup(int amount, DirectBitmap image)
        {
            _image = image;
            _centroids = new List<Centroid>();

            InitCentroids(amount);
        }

        private void InitCentroids(int amount)
        {
            int width = _image.Width;
            int height = _image.Height;
            int totalPixels = width * height;

            double step = (double)totalPixels / amount;

            for (int i = 0; i < amount; i++)
            {
                int idx = (int)(i * step);
                int x = idx % width;
                int y = idx / width;

                _centroids.Add(new Centroid(_image.GetPixel(x, y)));
            }
        }

        public double CenterCentroids()
        {
            double maxMove = double.MinValue;

            Parallel.ForEach(_centroids, centroid =>
            {
                centroid.Clear();
            });

            int width = _image.Width;
            int height = _image.Height;

            Parallel.For(0, width * height, i =>
            {
                int x = i % width;
                int y = i / width;

                var color = _image.GetPixel(x, y);
                AddToClosestCentroid(color);
            });

            Parallel.ForEach(_centroids, centroid =>
            {
                double move = centroid.MoveToMassCenter();
                double initialValue, computedValue;

                do
                {
                    initialValue = maxMove;
                    computedValue = Math.Max(move, initialValue);
                }
                while (initialValue != Interlocked.CompareExchange(ref maxMove, computedValue, initialValue));
            });

            return maxMove;
        }

        public Palette GeneratePalette()
        {
            Palette palette = new Palette();

            foreach (var centroid in _centroids)
            {
                palette.AddColor(centroid.Color);
            }

            return palette;
        }

        private void AddToClosestCentroid(Color color)
        {
            Centroid closestCentroid = new Centroid(color);
            int closestDistance = int.MaxValue;

            int R = color.R;
            int G = color.G;
            int B = color.B;

            foreach (var centroid in _centroids)
            {
                int distR = (R - centroid.Color.R) * (R - centroid.Color.R);
                int distG = (G - centroid.Color.G) * (G - centroid.Color.G);
                int distB = (B - centroid.Color.B) * (B - centroid.Color.B);
                int distSum = distR + distG + distB;

                if (distSum < closestDistance)
                {
                    closestDistance = distSum;
                    closestCentroid = centroid;
                }
            }

            closestCentroid.AddColor(color);
        }
    }
}
