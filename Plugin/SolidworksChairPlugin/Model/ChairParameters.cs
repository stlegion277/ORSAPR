using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class ChairParameters
    {
        private BondParameters _bondParameters;

        private SeatParameters _seatParameters;

        private LegParameters _legParameters;


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
        public void CheckValueRange(int parameter1, int parameter2, int min, int max)
        {
            if (parameter1 < min || parameter2 > max)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void ValidateParameters()
        {
            CheckValueRange(BondParameters.Width, BondParameters.Width, LegParameters.Width, 20);

            CheckValueRange(BondParameters.Height, BondParameters.Width, 30, 50);

            CheckValueRange(SeatParameters.Length, SeatParameters.Length, 320, 500);

            CheckValueRange(SeatParameters.Thickness, SeatParameters.Thickness, 40, 100);

            CheckValueRange(LegParameters.Length, LegParameters.Length, 40, 100);

            CheckValueRange(LegParameters.Height, LegParameters.Length, 500, 1000);

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
