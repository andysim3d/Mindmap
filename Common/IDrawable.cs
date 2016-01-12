using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MindCore
{
    public interface IDrawable
    {
        /// <summary>
        /// draw itself
        /// </summary>
        void draw(Graphics g);
    }
}
