using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matikkapeli_T_15
{
    internal class Kortti : Button
    {
        int _aX = 0;
        int _aY = 0;
        int _nextLineIndex = 0;
        public Kortti(int ax, int ay, int nextLineIndex)
        {
            _aX= ax;
            _aY= ay;
            _nextLineIndex= nextLineIndex;
            Location = new Point(15 + _aX, 50 + _aY);
            _aX += 100;
            Size = new Size(100, 100);
            Name = "";

        }

    }
}
