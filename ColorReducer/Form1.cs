using ColorReducer.Bitmaps;

namespace ColorReducer
{
    public partial class Form1 : Form
    {
        private ImageHolder MainImage;

        public Form1()
        {
            InitializeComponent();

            MainImage = new ImageHolder(mainPictureBox.Width, mainPictureBox.Height);

            mainPictureBox.Image = MainImage.Image.Bitmap;
        }

        private void colorsAmountTrackBar_Scroll(object sender, EventArgs e)
        {
            clusterImageButton.Text = $"Cluster image to {colorsAmountTrackBar.Value} colors";
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp",
            };
            openFileDialog.AutoUpgradeEnabled = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                Bitmap image = (Bitmap)Image.FromFile(path);
                MainImage.Draw(image);

                mainPictureBox.Invalidate();
            }
        }
    }
}
