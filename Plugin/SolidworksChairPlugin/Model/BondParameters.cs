using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class BondParameters
    {
        private int _height;

        private  int _width;

        private int _length;
        readonly LegParameters legParameters = new LegParameters();

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 30 || value > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _height = value;
            }
        }

        public int Length
        {
            get
            {
                return _height;
            }
            set
            {

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
                if (value < 20 || value > legParameters.Width)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _width = value;
            }
        }
    }

}
