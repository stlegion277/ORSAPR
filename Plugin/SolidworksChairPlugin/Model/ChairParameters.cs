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

        public void ValidateParameters()
        {
            if (BondParameters.Width > LegParameters.Width || BondParameters.Width < 20)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (BondParameters.Height < 30 || BondParameters.Width < 50)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (SeatParameters.Width != SeatParameters.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (SeatParameters.Length < 320 || SeatParameters.Length > 500)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (SeatParameters.Thickness < 40 || SeatParameters.Thickness > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (LegParameters.Length < 40 || LegParameters.Length > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (LegParameters.Width != LegParameters.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (LegParameters.Height < 500 || LegParameters.Length > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
