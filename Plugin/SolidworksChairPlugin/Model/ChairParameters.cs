using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class ChairParameters
    {
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

        /// <summary>
        /// Конструктор класса параметров всего табурета
        /// </summary>
        /// <param name="legParameters"></param>
        /// <param name="seatParameters"></param>
        /// <param name="bondParameters"></param>
        public ChairParameters(LegParameters legParameters, SeatParameters seatParameters, BondParameters bondParameters)
        {
            LegParameters = legParameters;
            BondParameters = bondParameters;
            SeatParameters = seatParameters;
        }
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
                    _legParameters = value;
                }
            }
        }
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
        /// Валидация параметров табурета
        /// </summary>
        public void ValidateParameters()
        {
            CheckValueRange(BondParameters.Width, BondParameters.Width, LegParameters.Width, 20);

            CheckValueRange(BondParameters.Height, BondParameters.Width, 30, 50);

            CheckValueRange(SeatParameters.Length, SeatParameters.Length, 320, 500);

            CheckValueRange(SeatParameters.Thickness, SeatParameters.Thickness, 40, 100);

            CheckValueRange(LegParameters.Length, LegParameters.Length, 40, 100);

            CheckValueRange(LegParameters.Height, LegParameters.Length, 500, 1000);

            //проверка зависимых параметров, конкретно здесь проверяется равны ли стороны сидушки
            if (SeatParameters.Width != SeatParameters.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (LegParameters.Width != LegParameters.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
