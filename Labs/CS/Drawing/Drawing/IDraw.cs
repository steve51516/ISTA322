using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        int X { get; set; }
        int Y { get; set; }
        //void SetLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
}
