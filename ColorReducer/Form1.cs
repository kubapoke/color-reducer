using ColorReducer.Bitmaps;
using ColorReducer.Reducers;

namespace ColorReducer
{
    public partial class Form1 : Form
    {
        private ImageHolder MainImageHolder, PopularityImageHolder;
        private Bitmap MainImage, PopularityImage;

        public Form1()
        {
            InitializeComponent();

            RemakeImageHolders();
        }

        private void RemakeImageHolders()
        {
            MainImageHolder = new ImageHolder(mainPictureBox.Width, mainPictureBox.Height);
            PopularityImageHolder = new ImageHolder(popularityAlgorithmPictureBox.Width, popularityAlgorithmPictureBox.Height);

            mainPictureBox.Image = MainImageHolder.Image.Bitmap;
            popularityAlgorithmPictureBox.Image = PopularityImageHolder.Image.Bitmap;
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

                MainImage = (Bitmap)Image.FromFile(path);
                MainImageHolder.Draw(MainImage);

                mainPictureBox.Invalidate();
            }
        }

        private void clusterImageButton_Click(object sender, EventArgs e)
        {
            Reducer reducer = new PopularityReducer(colorsAmountTrackBar.Value);

            PopularityImage = reducer.Reduce(MainImage);
            PopularityImageHolder.Draw(PopularityImage);

            popularityAlgorithmPictureBox.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RemakeImageHolders();

            MainImageHolder.Draw(MainImage);
            PopularityImageHolder.Draw(PopularityImage);
        }
    }
}
