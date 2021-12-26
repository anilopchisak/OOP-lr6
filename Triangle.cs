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
    class Triangle : BaseObject
    {
        private int x; //координаты центра круга
        private int y;
        private int r; //радиус
        private bool select;
        private int color;

        public Triangle() { }

        public Triangle(int _x, int _y)
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
                switch (color)
                {
                    case 0:
                        pen = new Pen(Color.Black, 2);
                        break;
                    case 1:
                        pen = new Pen(Color.Red, 2);
                        break;
                    case 2:
                        pen = new Pen(Color.Orange, 2);
                        break;
                    case 3:
                        pen = pen = new Pen(Color.Yellow, 2);
                        break;
                    case 4:
                        pen = new Pen(Color.Green, 2);
                        break;
                    case 5:
                        pen = new Pen(Color.LightBlue, 2);
                        break;
                    case 6:
                        pen = new Pen(Color.Blue, 2);
                        break;
                    case 7:
                        pen = new Pen(Color.Purple, 2);
                        break;
                }
            }
            else
            {
                switch (color)
                {
                    case 0:
                        pen = new Pen(Color.Black, 1);
                        break;
                    case 1:
                        pen = new Pen(Color.Red, 1);
                        break;
                    case 2:
                        pen = new Pen(Color.Orange, 1);
                        break;
                    case 3:
                        pen = pen = new Pen(Color.Yellow, 1);
                        break;
                    case 4:
                        pen = new Pen(Color.Green, 1);
                        break;
                    case 5:
                        pen = new Pen(Color.LightBlue, 1);
                        break;
                    case 6:
                        pen = new Pen(Color.Blue, 1);
                        break;
                    case 7:
                        pen = new Pen(Color.Purple, 1);
                        break;
                }
            }

            Point[] vertices = new Point[3];
            vertices[0] = new Point(x, y - r); //a
            vertices[1] = new Point(x - r, y + r); //b
            vertices[2] = new Point(x + r, y + r); //c
            e.Graphics.DrawPolygon(pen, vertices);
        }

        override public bool ifselected(int _x, int _y) //x0
        {
            Point a = new Point(x, y - r); //a
            Point b = new Point(x - r, y + r); //b
            Point c = new Point(x + r, y + r); //c
            int a1 = (a.X - _x) * (b.Y - a.Y) - (b.X - a.X) * (a.Y - _y);
            int b1 = (b.X - _x) * (c.Y - b.Y) - (c.X - b.X) * (b.Y - _y);
            int c1 = (c.X - _x) * (a.Y - c.Y) - (a.X - c.X) * (c.Y - _y);

            if ((a1 > 0 && b1 > 0 && c1 > 0) || (a1 < 0 && b1 < 0 && c1 < 0))
                return true;
            else return false;
        }

        override public bool out_of_form(int _x, int _y, Panel f) //чтобы оставалась в пределах формы
        {
            if (x - r + _x < 0) return true;
            if (y - r + _y < 0) return true;
            if (x + r + _x > f.Width) return true;
            if (y + r + _y > f.Height) return true;
            return false;
        }

        override public void move(KeyEventArgs e, Panel f)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (out_of_form(0, -7, f) == false) this.y = this.y - 5;
                    break;

                case Keys.Down:
                    if (out_of_form(0, 7, f) == false) this.y = this.y + 5;
                    break;

                case Keys.Left:
                    if (out_of_form(-7, 0, f) == false) this.x = this.x - 5;
                    break;

                case Keys.Right:
                    if (out_of_form(7, 0, f) == false) this.x = this.x + 5;
                    break;
            }
        }

        override public void change_size(KeyEventArgs e, Panel f)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemplus:
                    if (out_of_form(0, -7, f) == false && out_of_form(0, 7, f) == false &&
                        out_of_form(-7, 0, f) == false && out_of_form(7, 0, f) == false)
                        this.r = this.r + 1;
                    break;

                case Keys.OemMinus:
                    if (r > 5) this.r = this.r - 1;
                    break;
            }
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

        override public void set_radius(int plus_or_minus)
        {
            this.r = this.r + plus_or_minus;
        }

        override public int get_radius()
        {
            return this.r;
        }

        override public void set_xy(int _x, int _y)
        {
            this.x = this.x + _x;
            this.y = this.y + _y;
        }
    }
}
