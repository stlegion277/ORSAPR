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

        /// <summary>
        /// Свойство высоты ножки
        /// </summary>
        public int Height
        {
            get => _height;
            set => _height = CheckValueRange(value, _legHeightMinValue, _legHeightMaxValue);
        }

        /// <summary>
        /// Свойство длины ножки
        /// </summary>
        public int Length
        {
            get => _length;
            set => _length = CheckValueRange(value, _legLengthMinValue, _legLengthMaxValue);
        }

        /// <summary>
        /// Свойство ширины ножки
        /// </summary>
        public int Width
        {
            get => _width;
            set => _width = CheckDepenpdentValues(value, _length);
        }
        #endregion Свойства

        /// <summary>
        /// Конструктор класса LegParameters
        /// </summary>
        public LegParameters()
        {

        }

        /// <summary>
        /// Метод проверки параметров табурета
        /// </summary>
        /// <param name="value">параметр табурета</param>
        /// <param name="min">минимально допустимое значение параметра табурета</param>
        /// <param name="max">максимально допустимое значение параметра табурета</param>
        private int CheckValueRange(int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return value;
            }
        }

        private int CheckDepenpdentValues(int parameter1, int parameter2)
        {
            if (parameter1 != parameter2)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return parameter1;
            }
        }

    }
}
