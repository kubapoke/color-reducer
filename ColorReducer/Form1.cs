using ColorReducer.Bitmaps;
using ColorReducer.Reducers;

namespace ColorReducer
{
    public partial class Form1 : Form
    {
        private ImageHolder MainImageHolder, PopularityImageHolder, KMeansImageHolder, PropagationImageHolder;
        private Bitmap MainImage, PopularityImage, KMeansImage, PropagationImage;

        public Form1()
        {
            InitializeComponent();

            RemakeImageHolders();
        }

        private void RemakeImageHolders()
        {
            MainImageHolder = new ImageHolder(mainPictureBox.Width, mainPictureBox.Height);
            PopularityImageHolder = new ImageHolder(popularityAlgorithmPictureBox.Width, popularityAlgorithmPictureBox.Height);
            KMeansImageHolder = new ImageHolder(kMeansAlgorithmPictureBox.Width, kMeansAlgorithmPictureBox.Height);
            PropagationImageHolder = new ImageHolder(propagationOfUncertaintyPictureBox.Width, propagationOfUncertaintyPictureBox.Height);

            mainPictureBox.Image = MainImageHolder.Image.Bitmap;
            popularityAlgorithmPictureBox.Image = PopularityImageHolder.Image.Bitmap;
            kMeansAlgorithmPictureBox.Image = KMeansImageHolder.Image.Bitmap;
            propagationOfUncertaintyPictureBox.Image = PropagationImageHolder.Image.Bitmap;
        }

        private void colorsAmountTrackBar_Scroll(object sender, EventArgs e)
        {
            colorAmountLabel.Text = $"{colorsAmountTrackBar.Value}";
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
            if (MainImage == null)
                return;

            Reducer popularityReducer = new PopularityReducer(colorsAmountTrackBar.Value);
            Reducer kMeansReducer = new KMeansReducer(colorsAmountTrackBar.Value, epsilonTrackBar.Value, maxIterationsTrackbar.Value);
            Reducer propagationReducer = new UncertaintyPropagationReducer(redScaleTrackBar.Value, greenScaleTrackBar.Value, blueScaleTrackBar.Value);

            PopularityImage = popularityReducer.Reduce(MainImage);
            PopularityImageHolder.Draw(PopularityImage);

            KMeansImage = kMeansReducer.Reduce(MainImage);
            KMeansImageHolder.Draw(KMeansImage);

            PropagationImage = propagationReducer.Reduce(MainImage);
            PropagationImageHolder.Draw(PropagationImage);

            popularityAlgorithmPictureBox.Invalidate();
            kMeansAlgorithmPictureBox.Invalidate();
            propagationOfUncertaintyPictureBox.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RemakeImageHolders();

            if (MainImage != null)
                MainImageHolder.Draw(MainImage);
            if (PopularityImage != null)
                PopularityImageHolder.Draw(PopularityImage);
            if (KMeansImage != null)
                KMeansImageHolder.Draw(KMeansImage);
            if (PropagationImage != null)
                PropagationImageHolder.Draw(PropagationImage);
        }

        private void epsilonTrackBar_Scroll(object sender, EventArgs e)
        {
            epsilonValueLabel.Text = $"{epsilonTrackBar.Value}";
        }

        private void maxIterationsTrackbar_Scroll(object sender, EventArgs e)
        {
            maxIterationsValueLabel.Text = $"{maxIterationsTrackbar.Value}";
        }

        private void redScaleTrackBar_Scroll(object sender, EventArgs e)
        {
            redScaleLabel.Text = $"{redScaleTrackBar.Value}";
            totalScaleLabel.Text = $"{redScaleTrackBar.Value * greenScaleTrackBar.Value * blueScaleTrackBar.Value}";
        }

        private void greenScaleTrackBar_Scroll(object sender, EventArgs e)
        {
            greenScaleLabel.Text = $"{greenScaleTrackBar.Value}";
            totalScaleLabel.Text = $"{redScaleTrackBar.Value * greenScaleTrackBar.Value * blueScaleTrackBar.Value}";
        }

        private void blueScaleTrackBar_Scroll(object sender, EventArgs e)
        {
            blueScaleLabel.Text = $"{blueScaleTrackBar.Value}";
            totalScaleLabel.Text = $"{redScaleTrackBar.Value * greenScaleTrackBar.Value * blueScaleTrackBar.Value}";
        }
    }
}
