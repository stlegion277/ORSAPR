using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    /// <summary>
    /// Класс, хранящий параметры всего табурета
    /// </summary>
    public class ChairParameters
    {
        #region Параметры
        /// <summary>
        /// Обьект класса связи между ножками
        /// </summary>
        private BondParameters _bondParameters;

        /// <summary>
        /// Обьект класса сидушки табурета
        /// </summary>
        private SeatParameters _seatParameters;

        /// <summary>
        /// Обьект класса ножек табурета
        /// </summary>
        private LegParameters _legParameters;
        #endregion Параметры

        /// <summary>
        /// Конструктор класса параметров всего табурета
        /// </summary>
        /// <param name="legParameters">Параметры ножек</param>
        /// <param name="seatParameters">Параметры сидушки</param>
        /// <param name="bondParameters">Параметры связей</param>
        public ChairParameters(LegParameters legParameters, SeatParameters seatParameters, BondParameters bondParameters)
        {
            LegParameters = legParameters;
            BondParameters = bondParameters;
            SeatParameters = seatParameters;
        }
        #region Свойства

        /// <summary>
        /// Свойство для параметров связей
        /// </summary>
        public BondParameters BondParameters
        {
            get
            {
                return _bondParameters;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                _bondParameters = value;
            }
        }

        /// <summary>
        /// Свойство для параметров сидушки
        /// </summary>
        public SeatParameters SeatParameters
        {
            get
            {
                return _seatParameters;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                _seatParameters = value;
            }
        }

        /// <summary>
        /// Свойство для параметров ножек
        /// </summary>
        public LegParameters LegParameters
        {
            get
            {
                return _legParameters;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                _legParameters = value;
            }
        }
        #endregion Свойства

        #region Валидация
        /// <summary>
        /// Метод проверки параметров табурета
        /// </summary>
        /// <param name="parameter1">первый параметр табурета</param>
        /// <param name="parameter2">второй параметр табурета</param>
        /// <param name="min">минимально допустимое значение параметра табурета</param>
        /// <param name="max">максимально допустимое значение параметра табурета</param>
        public void CheckValueRange(int parameter1, int parameter2, int min, int max)
        {
            if (parameter1 < min || parameter2 > max)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Проверка зависимых параметров
        /// </summary>
        /// <param name="parameter1">первый параметр табурета</param>
        /// <param name="parameter2">второй параметр табурета</param>
        public void CheckDepenpdentValues(int parameter1, int parameter2)
        {
            if (parameter1 != parameter2)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Валидация параметров табурета
        /// </summary>
        public void ValidateParameters()
        {
            CheckDepenpdentValues(BondParameters.Width, LegParameters.Width);

            if (BondParameters.Length != (SeatParameters.Length - (LegParameters.Width * 2)))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        #endregion Валидация
    }
}
