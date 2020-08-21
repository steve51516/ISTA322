using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Square : DrawingShape, IDraw, IColor
    {

        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }
            base.Draw(canvas);
        }
        public Square(int sl)
        {
            sideLength = sl;
        }
        public Square(int sl) : base(sl)
        {

        }
        private int sideLength;
        private Rectangle rect = null;

        void IColor.SetColor(Color color)
        {
            if (rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                rect.Fill = brush;
            }
        }
    }
}
