﻿namespace ColorReducer.Reducers
{
    internal class PopularityReducer : Reducer
    {
        public PopularityReducer() : base() { }

        protected override void GeneratePalette(DirectBitmap bitmap, int amount)
        {
            _palette.Clear();

            var colorCounter = new Dictionary<Color, int>();

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var color = bitmap.GetPixel(x, y);
                    if (colorCounter.ContainsKey(color))
                    {
                        colorCounter[color]++;
                    }
                    else
                    {
                        colorCounter[color] = 1;
                    }
                }
            }

            var mostPopularColors = colorCounter
                .OrderByDescending(x => x.Value)
                .Take(amount)
                .ToList();

            foreach (var color in mostPopularColors)
            {
                _palette.AddColor(color.Key);
            }
        }
    }
}
