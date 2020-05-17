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
   public class SeatParameters
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

        /// <summary>
        /// Минимальная толщина сиденья
        /// </summary>
        private int _thicknessMinValue = 40;

        /// <summary>
        /// Максимальная толщина сиденья
        /// </summary>
        private int _thicknessMaxValue = 100;

        /// <summary>
        /// Минимальная длина сиденья
        /// </summary>
        private int _lengthMinValue = 320;

        /// <summary>
        /// Максимальная длина сиденья
        /// </summary>
        private int _lengthMaxValue = 500;

        #endregion Параметры

        /// <summary>
        /// Конструктор класса SeatParameters
        /// </summary>
        public SeatParameters()
        {

        }
     

        #region Свойства

        /// <summary>
        /// Свойство ширины сидушки
        /// </summary>
        public int Width
        {
            get => _width;
            set => _width = CheckDepenpdentValues(value, _length);
        }

        /// <summary>
        /// Свойство толщины сидушки
        /// </summary>
        public int Thickness
        {
            get => _thickness;
            set => _thickness = CheckValueRange(value, _thicknessMinValue, _thicknessMaxValue);
        }

        /// <summary>
        /// Свойство длины сидушки
        /// </summary>
        public int Length
        {
            get => _length;
            set => _length = CheckValueRange(value, _lengthMinValue, _lengthMaxValue);
        }
        #endregion Свойства

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
