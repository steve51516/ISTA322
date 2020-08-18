using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : DrawingShape, IDraw, IColor
    {
        
        private Ellipse circle = null;
        public Circle(int d)
        {
            diameter = d;
        }

        void IDraw.Draw(Canvas canvas)
        {
            if (circle != null)
            {
                canvas.Children.Remove(circle);
            }
            else
            {
                circle = new Ellipse();
            }
            circle.Height = diameter;
            circle.Width = diameter;
            Canvas.SetTop(circle, locY);
            Canvas.SetLeft(circle, locX);
            canvas.Children.Add(circle);
        }

        void IColor.SetColor(Color color)
        {
            if (this.circle != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.circle.Fill = brush;
            }
        }

        void IDraw.SetLocation(int xCoord, int yCoord)
        {
            locX = xCoord;
            locY = yCoord;
        }
    }
}
