using System.Collections.Concurrent;

namespace ColorReducer.Reducers
{
    internal class PopularityReducer : Reducer
    {
        public PopularityReducer(int amount) : base(amount) { }

        protected override void GeneratePalette(DirectBitmap bitmap)
        {
            _palette.Clear();

            var colorCounter = new ConcurrentDictionary<Color, int>();

            int width = bitmap.Width;
            int height = bitmap.Height;

            Parallel.For(0, width * height, i =>
            {
                int x = i % width;
                int y = i / width;

                var color = bitmap.GetPixel(x, y);

                if (colorCounter.TryGetValue(color, out int count))
                {
                    colorCounter[color] = count + 1;
                }
                else
                {
                    colorCounter[color] = 1;
                }
            });


            var mostPopularColors = colorCounter
                .OrderByDescending(x => x.Value)
                .Take(_amount)
                .ToList();

            foreach (var color in mostPopularColors)
            {
                _palette.AddColor(color.Key);
            }
        }
    }
}
