using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    /// <summary>
    /// Класс, хранящий параметры связей между ножками табурета
    /// </summary>
    public class BondParameters
    {
        #region Параметры 
        /// <summary>
        /// Высота(толщина) связи между ножками табурета 
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина связи между ножками табурета 
        /// </summary>
        private int _width;

        /// <summary>
        /// Длина связи между ножками табурета 
        /// </summary>
        private int _length;

        #endregion Параметры


        /// <summary>
        /// Конструктор класса BondParameters
        /// </summary>
        public BondParameters()
        {
                
        }
       


        #region Свойства

        /// <summary>
        /// Свойства высоты связи между ножками табурет
        /// </summary>
        public int Height
        {
            get => _height;
            set => _height = CheckDepenpdentValues(value, _width);
        }

        /// <summary>
        /// Свойства длины связи между ножками табурета
        /// </summary>
        public int Length
        {
            get => _length;
            set => _length = CheckValueIsNotNull(value);
        }

        /// <summary>
        /// Свойства ширины связи между ножками табурета
        /// </summary>
        public int Width
        {
            get => _width;
            set => _width = CheckValueIsNotNull(value);
        }
        #endregion Свойства


        /// <summary>
        /// Метод проверки параметров табурета
        /// </summary>
        /// <param name="value">параметр табурета</param>
        /// <param name="min">минимально допустимое значение параметра табурета</param>
        /// <param name="max">максимально допустимое значение параметра табурета</param>
        private int CheckValueIsNotNull(int value)
        {
            if (value == 0)
            {
                throw new ArgumentNullException();
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
