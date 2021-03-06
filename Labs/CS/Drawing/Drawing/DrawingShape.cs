﻿using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;
using System;

namespace Drawing
{
    abstract class DrawingShape
    {
        protected int size;
        protected int locX = 0;
        protected int locY = 0;
        protected Shape shape = null;
        protected int _size;
        protected int _x = 0, _y = 0;
        public DrawingShape(int s)
        {
            size = s;
        }
        public int X
        {
            get => _x;
            set => _x = value;
        }

        //public void SetLocation(int xCoord, int yCoord)
        //{
        //    this.locX = xCoord;
        //    this.locY = yCoord;
        //}
        //public void SetColor(Color color)
        //{
        //    if (this.shape != null)
        //    {
        //        SolidColorBrush brush = new SolidColorBrush(color);
        //        this.shape.Fill = brush;
        //    }
        //}
        public Color Color
        {
            set
            {
                if (this.shape != null)
                {
                    SolidColorBrush brush = new SolidColorBrush(value);
                    this.shape.Fill = brush;
                }
            }
        }
        public virtual void Draw(Canvas canvas)
        {
            if (this.shape == null)
            {
                throw new InvalidOperationException("Shape is null ");
            }
            this.shape.Height = this.size;
            this.shape.Width = this.size;
            Canvas.SetTop(this.shape, this.locY);
            Canvas.SetLeft(this.shape, this.locX);
            canvas.Children.Add(this.shape);
        }
    }
}
