﻿using System;
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

        /// <summary>
        /// Обьект класса, который нужен для проверки зависимых параметров 
        /// </summary>
        private LegParameters _legParameters;

        /// <summary>
        /// Обьект класса, который нужен для проверки зависимых параметров
        /// </summary>
        private SeatParameters _seatParameters;
        #endregion Параметры


        /// <summary>
        /// Конструктор класса BondParameters
        /// </summary>
        public BondParameters()
        {
                
        }
       


        #region Свойства

        /// <summary>
        /// Свойство параметров сидушки
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
        /// Свойство параметров ножки
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

        /// <summary>
        /// Свойства высоты связи между ножками табурет
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value != _width)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _height = value;
            }
        }

        /// <summary>
        /// Свойства длины связи между ножками табурета
        /// </summary>
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
               if (value != (SeatParameters.Length - (LegParameters.Width * 2)))
                {
                    throw new ArgumentOutOfRangeException();
                }
                _length = value;
            }
        }

        /// <summary>
        /// Свойства ширины связи между ножками табурета
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value != _legParameters.Width)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _width = value;
            }
        }
        #endregion Свойства
    }

}
