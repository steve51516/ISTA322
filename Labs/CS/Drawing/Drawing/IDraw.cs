using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        void SetLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
}
