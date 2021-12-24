
namespace ооп_лаба_6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Circle = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Square = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Triangle = new System.Windows.Forms.ToolStripButton();
            this.tsDDbtn_Color = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_Increase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_Decrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Circle,
            this.tsbtn_Square,
            this.tsbtn_Triangle,
            this.tsDDbtn_Color,
            this.toolStripSeparator1,
            this.tsbtn_Increase,
            this.toolStripSeparator3,
            this.tsbtn_Decrease,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1204, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Circle
            // 
            this.tsbtn_Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Circle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Circle.Image")));
            this.tsbtn_Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Circle.Name = "tsbtn_Circle";
            this.tsbtn_Circle.Size = new System.Drawing.Size(50, 24);
            this.tsbtn_Circle.Text = "Circle";
            this.tsbtn_Circle.Click += new System.EventHandler(this.tsbtn_Circle_Click);
            // 
            // tsbtn_Square
            // 
            this.tsbtn_Square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Square.Name = "tsbtn_Square";
            this.tsbtn_Square.Size = new System.Drawing.Size(59, 24);
            this.tsbtn_Square.Text = "Square";
            this.tsbtn_Square.Click += new System.EventHandler(this.tsbtn_Square_Click);
            // 
            // tsbtn_Triangle
            // 
            this.tsbtn_Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Triangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Triangle.Image")));
            this.tsbtn_Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Triangle.Name = "tsbtn_Triangle";
            this.tsbtn_Triangle.Size = new System.Drawing.Size(66, 24);
            this.tsbtn_Triangle.Text = "Triangle";
            this.tsbtn_Triangle.Click += new System.EventHandler(this.tsbtn_Triangle_Click);
            // 
            // tsDDbtn_Color
            // 
            this.tsDDbtn_Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDDbtn_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.lightBlueToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.tsDDbtn_Color.Image = ((System.Drawing.Image)(resources.GetObject("tsDDbtn_Color.Image")));
            this.tsDDbtn_Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDDbtn_Color.Name = "tsDDbtn_Color";
            this.tsDDbtn_Color.Size = new System.Drawing.Size(59, 24);
            this.tsDDbtn_Color.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // lightBlueToolStripMenuItem
            // 
            this.lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem";
            this.lightBlueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lightBlueToolStripMenuItem.Text = "Light blue";
            this.lightBlueToolStripMenuItem.Click += new System.EventHandler(this.lightBlueToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtn_Increase
            // 
            this.tsbtn_Increase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Increase.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Increase.Image")));
            this.tsbtn_Increase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Increase.Name = "tsbtn_Increase";
            this.tsbtn_Increase.Size = new System.Drawing.Size(127, 24);
            this.tsbtn_Increase.Text = "Increase object +";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtn_Decrease
            // 
            this.tsbtn_Decrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Decrease.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Decrease.Image")));
            this.tsbtn_Decrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Decrease.Name = "tsbtn_Decrease";
            this.tsbtn_Decrease.Size = new System.Drawing.Size(130, 24);
            this.tsbtn_Decrease.Text = "Decrease object -";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 600);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_Square;
        private System.Windows.Forms.ToolStripButton tsbtn_Triangle;
        private System.Windows.Forms.ToolStripButton tsbtn_Circle;
        private System.Windows.Forms.ToolStripDropDownButton tsDDbtn_Color;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_Increase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtn_Decrease;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

