using ColorReducer.Bitmaps;
using ColorReducer.Reducers;

namespace ColorReducer
{
    public partial class Form1 : Form
    {
        private ImageHolder MainImage, PopularityImage;
        private Bitmap PublicImage;

        public Form1()
        {
            InitializeComponent();

            MainImage = new ImageHolder(mainPictureBox.Width, mainPictureBox.Height);
            PopularityImage = new ImageHolder(popularityAlgorithmPictureBox.Width, popularityAlgorithmPictureBox.Height);

            mainPictureBox.Image = MainImage.Image.Bitmap;
            popularityAlgorithmPictureBox.Image = PopularityImage.Image.Bitmap;
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

                PublicImage = (Bitmap)Image.FromFile(path);
                MainImage.Draw(PublicImage);

                mainPictureBox.Invalidate();
            }
        }

        private void clusterImageButton_Click(object sender, EventArgs e)
        {
            Reducer reducer = new PopularityReducer();

            PopularityImage.Draw(PublicImage);
            reducer.Reduce(PopularityImage.Image, colorsAmountTrackBar.Value);

            popularityAlgorithmPictureBox.Invalidate();
        }
    }
}
