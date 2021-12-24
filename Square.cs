using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ооп_лаба_6
{
    class Square : BaseObject
    {
        private int x; //координаты центра круга
        private int y;
        private int r; //радиус
        private bool select;
        private int color;

        public Square() { }

        public Square(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
            this.r = 20;
            this.select = false;
            this.color = 0;
        }

        override public void draw(PaintEventArgs e)
        {
            Pen pen; pen = new Pen(Color.Black, 1);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (select == true)
            {
                if (color == 0) pen = new Pen(Color.Black, 2); //цвет и толщина кисти
                if (color == 1) pen = new Pen(Color.Red, 2);
                if (color == 2) pen = new Pen(Color.Orange, 2);
                if (color == 3) pen = new Pen(Color.Yellow, 2);
                if (color == 4) pen = new Pen(Color.Green, 2);
                if (color == 5) pen = new Pen(Color.LightBlue, 2);
                if (color == 6) pen = new Pen(Color.Blue, 2);
                if (color == 7) pen = new Pen(Color.Purple, 2);
            }
            else
            {
                if (color == 0) pen = new Pen(Color.Black, 1); //цвет и толщина кисти
                if (color == 1) pen = new Pen(Color.Red, 1);
                if (color == 2) pen = new Pen(Color.Orange, 1);
                if (color == 3) pen = new Pen(Color.Yellow, 1);
                if (color == 4) pen = new Pen(Color.Green, 1);
                if (color == 5) pen = new Pen(Color.LightBlue, 1);
                if (color == 6) pen = new Pen(Color.Blue, 1);
                if (color == 7) pen = new Pen(Color.Purple, 1);
            }
            //if (select == true)
            //    //e.Graphics.DrawRectangle(pen, (int)(x - r), (int)(y - r), (int)(2.3 * r), (int)(2.3 * r));
            //    pen = new Pen(Color.Black, 2); //цвет и толщина кисти
            //else
            //    pen = new Pen(Color.Black, 1);
            //-r чтобы центр круга оказывался в месте клика, тк эллипс рисуется из верхнего левого угла
            e.Graphics.DrawRectangle(pen, x - r, y - r, 2 * r, 2 * r);
        }

        override public bool ifselected(int _x, int _y)
        {
            if (Math.Pow((_x - x), 2) + Math.Pow((_y - y), 2) <= Math.Pow(this.r, 2))
                return true;
            else return false;
        }

        override public void set_select(bool _select)
        {
            this.select = _select;
        }

        override public bool get_select()
        {
            return select;
        }

        override public int get_x()
        {
            return x;
        }

        override public int get_y()
        {
            return y;
        }

        override public void set_color(int _color)
        {
            this.color = _color;
        }
    }
}
