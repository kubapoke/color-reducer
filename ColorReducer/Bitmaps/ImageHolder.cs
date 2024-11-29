namespace ColorReducer.Bitmaps
{
    internal class ImageHolder
    {
        public DirectBitmap Image { get; set; }

        public ImageHolder(int width, int height)
        {
            Image = new DirectBitmap(width, height);
        }

        public void Draw(Bitmap bitmap)
        {
            Image.Clear();
            double scale = Math.Min((double)Image.Width / (double)bitmap.Width, (double)Image.Height / (double)bitmap.Height);

            int scaledWidth = (int)(bitmap.Width * scale);
            int scaledHeight = (int)(bitmap.Height * scale);
            int offsetX = (Image.Width - scaledWidth) / 2;
            int offsetY = (Image.Height - scaledHeight) / 2;

            for (int x = offsetX; x < Image.Width - offsetX - 1; x++)
            {
                for (int y = offsetY; y < Image.Height - offsetY - 1; y++)
                {
                    Image.SetPixel(x, y, bitmap.GetPixel((int)((x - offsetX) / scale), (int)((y - offsetY) / scale)));
                }
            }
        }
    }
}
