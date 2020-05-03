using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    /// <summary>
    /// Класс хранящий параметры ножек табурета
    /// </summary>
   public class LegParameters
    {
        #region Параметры
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

        #endregion Параметры

        #region Свойства
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
                _width = _length;
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
        #endregion Свойства


        public LegParameters()
        {

        }
        
    }
}
