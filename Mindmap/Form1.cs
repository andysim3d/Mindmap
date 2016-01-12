using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MindCore;

namespace Mindmap
{
    public partial class Form1 : Form
    {
        IDrawable li;
        public Form1()
        {
            InitializeComponent();
            li = new Line(this.pictureBox1);
            ((Line)li).setStart(new Point(200, 230));
            ((Line)li).setEnd(new Point(0, 20));

        }
        protected override void OnPaint(
            PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.OrangeRed, new Point(0, 0), new Point(100, 199));

            li.draw(e.Graphics);
            base.OnPaint(e);
            
        }


    }
}
