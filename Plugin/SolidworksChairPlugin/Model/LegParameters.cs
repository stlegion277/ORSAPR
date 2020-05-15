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

        /// <summary>
        /// Минимальная высота ножки
        /// </summary>
        private int _legHeightMinValue = 500;

        /// <summary>
        /// Максимальная высота ножки
        /// </summary>
        private int _legHeightMaxValue = 1000;

        /// <summary>
        /// Минимальная длина ножки
        /// </summary>
        private int _legLengthMinValue = 40;

        /// <summary>
        /// Максимальная длина ножки
        /// </summary>
        private int _legLengthMaxValue = 100;

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
                if (value < _legHeightMinValue || value > _legHeightMaxValue)
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
                if (value < _legLengthMinValue || value > _legLengthMaxValue)
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
