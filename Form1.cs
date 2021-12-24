using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ооп_лаба_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circle circle = new Circle();
        Square square = new Square();
        Triangle triangle = new Triangle();
        Storage storage = new Storage();
        int index = -1;
        bool ctrl = false;
        bool chosen_circle = true; bool chosen_square = false; bool chosen_triangle = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool new_figure = true;
                for (int i = 0; i < storage.getCount(); i++) //для каждого объекта массива
                {
                    if (storage.get_current_obj(i).ifselected(e.X, e.Y) == true) //если на объект нажали
                    {
                        new_figure = false;
                        if (ctrl == true)
                            storage.get_current_obj(i).set_select(true);
                        else
                        {
                            for (int j = 0; j < storage.getCount(); j++)
                            {
                                if (storage.get_current_obj(j).get_select() == true) //снимаем выделение у всех объектов
                                    storage.get_current_obj(j).set_select(false);

                            }
                            storage.get_current_obj(i).set_select(true); //ставим выделение у объекта на который нажали
                        }
                    }
                }

                if (new_figure == true)
                {
                    for (int i = 0; i < storage.getCount(); i++) storage.get_current_obj(i).set_select(false); //снимаем выделение у всех объектов
                    index = index + 1;

                    if (chosen_circle == true)
                    {
                        circle = new Circle(e.X, e.Y);
                        storage.addCircle(index, circle);
                    }
                    else if (chosen_square == true)
                    {
                        square = new Square(e.X, e.Y);
                        storage.addSquare(index, square);
                    }
                    else if (chosen_triangle == true)
                    {
                        triangle = new Triangle(e.X, e.Y);
                        storage.addTriangle(index, triangle);
                    }

                    storage.get_current_obj(index).set_select(true);
                }
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (storage.getCount() != 0)
            {
                for (int i = 0; i < storage.getCount(); i++) storage.get_current_obj(i).draw(e);
                storage.set_current_index(index);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl = true;
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < storage.getCount(); i++)
                    if (storage.get_current_obj(i).get_select() == true)
                    {
                        storage.get_current_obj(i).set_select(false);
                        storage.deleteObject(i);
                    }
                storage.change_array();
                storage.set_current_index(0);
                index = storage.getCount() - 1;

                Refresh();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                ctrl = false;
        }

        private void tsbtn_Circle_Click(object sender, EventArgs e)
        {
            chosen_circle = true;
            chosen_square = false;
            chosen_triangle = false;
        } //выбираем в меню что рисовать

        private void tsbtn_Square_Click(object sender, EventArgs e)
        {
            chosen_circle = false;
            chosen_square = true;
            chosen_triangle = false;
        }

        private void tsbtn_Triangle_Click(object sender, EventArgs e)
        {
            chosen_circle = false;
            chosen_square = false;
            chosen_triangle = true;
        }

        private void change_color(int color)
        {
            if (storage.getCount() != 0)
            {
                for (int i = 0; i < storage.getCount(); i++)
                    if (storage.get_current_obj(i).get_select() == true)
                        storage.get_current_obj(i).set_color(color);
                storage.set_current_index(index);
                Refresh();
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(1);
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(2);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(3);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(4);
        }

        private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(5);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(6);
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(7);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(0);
        }
    }
}
