using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class LegParameters
    {
        /// <summary>
        /// Высота ножки
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина ножки
        /// </summary>
        private int _width;

        /// <summary>
        /// Длина ножки
        /// </summary>
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

        /// <summary>
        /// Конструктор класса параметров ножек табурета
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        public LegParameters(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
        
    }
}
