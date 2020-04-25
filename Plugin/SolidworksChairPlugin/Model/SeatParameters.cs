using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    /// <summary>
    /// Класс хранящий параметры сидушки табурета
    /// </summary>
    class SeatParameters
    {
        #region Параметры
        /// <summary>
        /// Ширина сидушки
        /// </summary>
        private int _width;

        /// <summary>
        /// Толщина сидушки
        /// </summary>
        private int _thickness;

        /// <summary>
        /// Длина сидушки
        /// </summary>
        private int _length;
        #endregion Параметры

        /// <summary>
        /// Конструктор класса параметров сидушки
        /// </summary>
        /// <param name="width"></param>
        /// <param name="thickness"></param>
        /// <param name="length"></param>
        public SeatParameters(int width, int thickness, int length)
        {
            Width = width;
            Thickness = thickness;
            Length = length;
        }
        #region Свойства
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
        #endregion Свойства
    }
}
