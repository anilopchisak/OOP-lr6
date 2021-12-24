using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ооп_лаба_6
{
    class BaseObject
    {
        public BaseObject() { }

        ~BaseObject()
        {
        }
        public virtual void draw(PaintEventArgs e) { }

        public virtual bool ifselected(int _x, int _y) { return false; }

        public virtual void set_select(bool select) { }

        public virtual bool get_select() { return false; }

        public virtual int get_x() { return 0; }

        public virtual int get_y() { return 0; }

        public virtual void set_color(int _color) { }
    }
}
