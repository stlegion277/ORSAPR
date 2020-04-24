using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class LegParameters
    {
        private int _height;

        private int _width;

        private int _length;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 500 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _height = value;
            }
        }

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

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 40 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _length = value;
            }
        }

        public LegParameters(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
        
    }
}
