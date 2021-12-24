﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ооп_лаба_6
{
    class Circle : BaseObject
    {
        private int x; //координаты центра круга
        private int y;
        private int r; //радиус
        private bool select;

        public Circle() { }

        public Circle(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
            this.r = 20;
            this.select = false;
        }

        override public void draw(PaintEventArgs e)
        {
            Pen pen;
            if (select == true)
                pen = new Pen(Color.Green, 2); //цвет и толщина кисти
            else
                pen = new Pen(Color.Black, 1);
            //-r чтобы центр круга оказывался в месте клика, тк эллипс рисуется из верхнего левого угла
            e.Graphics.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
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
    }
}
