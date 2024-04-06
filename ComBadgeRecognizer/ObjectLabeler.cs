using Yolov5Net.Scorer;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

using PointF = SixLabors.ImageSharp.PointF;
using Font = SixLabors.Fonts.Font;
using FontCollection = SixLabors.Fonts.FontCollection;
using Image = SixLabors.ImageSharp.Image;
using Color = SixLabors.ImageSharp.Color;

namespace ComBadgeRecognizer
{
    /// <summary>
    /// Labels detected objects on an Image
    /// </summary>
    class ObjectLabeler
    {
        private readonly Font font;

        public ObjectLabeler()
        {
            font = new Font(new FontCollection().Add("C:/Windows/Fonts/consola.ttf"), 12);
        }

        public void label( Image img, List<YoloPrediction> predictions )
        {
            foreach (YoloPrediction prediction in predictions)
            {
                double score = Math.Round(prediction.Score, 2);

                float x = prediction.Rectangle.Left - 3;
                float y = prediction.Rectangle.Top - 23;

                img.Mutate(a => a.DrawPolygon(
                    new SolidPen(prediction.Label.Color, 1),
                    new PointF(prediction.Rectangle.Left, prediction.Rectangle.Top),
                    new PointF(prediction.Rectangle.Right, prediction.Rectangle.Top),
                    new PointF(prediction.Rectangle.Right, prediction.Rectangle.Bottom),
                    new PointF(prediction.Rectangle.Left, prediction.Rectangle.Bottom)
                    )
                );

                img.Mutate(
                    a => a.DrawText(
                        $"{prediction.Label.Name} ({score})",
                        font,
                        prediction.Label.Color,
                        new PointF(x, y)
                        )
                    );
            }
        }
    }
}
