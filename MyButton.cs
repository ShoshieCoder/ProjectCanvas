using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyButton
    {
        protected Point _topLeft, _bottomRight;
        private int _width, _height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this._topLeft = topLeft;
            this._bottomRight = bottomRight;
            UpdateWidthAndHeight();
        }

        internal int GetWidth()
        {
            return this._width;
        }

        internal int GetHeight()
        {
            return this._height;
        }

        internal bool SetTopLeft(Point topLeft)
        {
            if (!(topLeft.GetX() > this._bottomRight.GetX() || topLeft.GetY() < this._bottomRight.GetY()))
            {
                this._topLeft = topLeft;
                UpdateWidthAndHeight();
                return true;
            }
            else
                return false;
        }

        internal bool SetBottomRight(Point bottomRight)
        {
            if (!(bottomRight.GetX() < this._topLeft.GetX() || bottomRight.GetY() > this._topLeft.GetY()))
            {
                this._bottomRight = bottomRight;
                UpdateWidthAndHeight();
                return true;
            }
            else
                return false;
        }

        internal Point GetTopLeft()
        {
            return this._topLeft;
        }

        internal Point GetBottomRight()
        {
            return this._bottomRight;
        }

        private void UpdateWidthAndHeight()
        {
            this._width = Math.Abs(_bottomRight.GetX() - _topLeft.GetX());
            this._height = Math.Abs(_topLeft.GetY() - _bottomRight.GetY());
        }

        public override string ToString()
        {
            return ($"TOP LEFT: {this._topLeft.GetX()}, {this._topLeft.GetY()} BOTTOM RIGHT: {this._bottomRight.GetX()}, {this._bottomRight.GetY()} HEIGHT: {this._height} WIDTH: {this._width}");
        }

    }
}
