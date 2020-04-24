using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class SeatParameters
    {
        private int _width;
        private int _thickness;
        private int _length;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value != _length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _width = value;
            }
        }

        public int Thickness
        {
            get
            {
                return _thickness;
            }
            set
            {
                if (value < 40 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _thickness = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 320 || value > 500)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _length = value;
            }
        }
    }
}
