using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Image = SixLabors.ImageSharp.Image;

namespace ComBadgeRecognizer
{
    public partial class ComBadgeRecognizerForm : Form
    {
        private readonly YoloScorer<CombadgeModel> scorer;

        private ObjectLabeler labeler;

        public ComBadgeRecognizerForm()
        {
            InitializeComponent();

            scorer = new YoloScorer<CombadgeModel>("best.onnx");
            labeler = new ObjectLabeler();
        }

        private async void browseButton_Click(object sender, EventArgs args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (*.JPG)|*.jpg";

            DialogResult result = ofd.ShowDialog();
            if( result != DialogResult.OK )
            {
                return;
            }

            fileNameTB.Text = ofd.FileName;
                
            if( !File.Exists( ofd.FileName ) )
            {
                MessageBox.Show(
                    "Error loading selected image " + ofd.FileName + ":\n" + "File doesn't exist or is unreadable by the current user.",
                    "Error loading selected image"
                    );

                return;
            }

            progressBar1.Value = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;

            Image<Rgba32> img;
                
            try
            {
                img = await Image.LoadAsync<Rgba32>(ofd.FileName);
            }
            catch( Exception e )
            {
                MessageBox.Show(
                    "Error loading selected image " + ofd.FileName + ":\n" + e.Message,
                    "Error loading selected image"
                    );

                return;
            }               

            List<YoloPrediction> predictions = scorer.Predict(img);

            labeler.label(img, predictions);

            pictureBox1.BackgroundImage = img.ToArray().ToDrawingImage();

            progressBar1.Style = ProgressBarStyle.Blocks;
        }
    }
}
