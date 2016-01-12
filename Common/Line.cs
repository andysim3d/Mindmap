using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindCore
{
    public class Line : IDrawable
    {
        private Control _canvas;
        private Point _start;
        private Point _end;
        private Color _color = (Color.Red);
        private int _width = 1;

        //可以将自己画在背景上
        public void draw(Graphics g)
        {
            var p = new Pen(_color);
            p.Width = _width;
            g.DrawLine(p, _start, _end);
        }

        public Line(Control parent)
        {
            this._canvas = parent;
        }

        public void setStart(Point start)
        {
            this._start = start;
        }

        public void setEnd(Point end)
        {
            this._end = end;
        }
    }
}
