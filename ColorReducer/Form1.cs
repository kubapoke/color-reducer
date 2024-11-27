namespace ColorReducer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorsAmountTrackBar_Scroll(object sender, EventArgs e)
        {
            clusterImageButton.Text = $"Cluster image to {colorsAmountTrackBar.Value} colors";
        }
    }
}
