using NUnit.Framework;
using System;
using SolidworksChairPlugin.Model;

namespace ModelParametersTests
{
    /// <summary>
    /// ��������� ����� ��� ���������� ��������
    /// </summary>
    [TestFixture]
    public class ModelParametersTests
    {
       [Test]
       [TestCase(20, TestName = "���������� ���� ��������� ������� ������� �� ��������� 20")]
       [TestCase(120, TestName = "���������� ���� ��������� ������� ������� �� ��������� 120")]
       public void SetSeatThickness_NegativeTest(int Thickness)
        {
            var seatParameters = new SeatParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            seatParameters.Thickness = Thickness);
        }

        [TestCase(40, TestName = "���������� ���� ��������� ������� ������� �� ��������� 40")]
        [TestCase(100, TestName = "���������� ���� ��������� ������� ������� �� ��������� 100")]
        public void SetSeatThickness_PositiveTest(int Thickness)
        {
            var seatParameters = new SeatParameters();
            seatParameters.Thickness = Thickness;
        }

        [TestCase(310, TestName = "���������� ���� ��������� ����� ������� �� ��������� 310")]
        [TestCase(510, TestName = "���������� ���� ��������� ����� ������ �� ��������� 510")]
        public void SetSeatLength_NegativeTest(int Length)
        {
            var seatParameters = new SeatParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            seatParameters.Length = Length);
        }

        [TestCase(320, TestName = "���������� ���� ��������� ����� ������� �� ��������� 320")]
        [TestCase(500, TestName = "���������� ���� ��������� ����� ������� �� ��������� 500")]
        public void SetSeatLength_PositiveTest
            (int Length)
        {
            var seatParameters = new SeatParameters();
            seatParameters.Length = Length;
        }

        [TestCase(310, 320, TestName = "���������� ���� ��������� ������ ������� �� ��������� 310")]
        [TestCase(510, 500, TestName = "���������� ���� ��������� ������ ������� �� ��������� 510")]
        public void SetSeatWidth_NegativeTest(int Width, int Length)
        {
            var seatParameters = new SeatParameters();
            seatParameters.Length = Length;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                seatParameters.Width = Width);
        }

        [TestCase(320, 320, TestName = "���������� ���� ��������� ������ ������� �� ��������� 320")]
        [TestCase(500, 500, TestName = "���������� ���� ��������� ������ ������� �� ��������� 500")]
        public void SetSeatWidth_PositiveTest(int Width, int Length)
        {
            var seatParameters = new SeatParameters();
            seatParameters.Length = Length;
                seatParameters.Width = Width;
        }

        [TestCase(300, TestName = "���������� ���� ��������� ������ ����� �� ��������� 300")]
        [TestCase(1020, TestName = "���������� ���� ��������� ������ ����� �� ��������� 1020")]
        public void SetLegHeight_NegativeTest(int Height)
        {
            var legParameters = new LegParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            legParameters.Height = Height);
        }

        [TestCase(500, TestName = "���������� ���� ��������� ������ ����� �� ��������� 500")]
        [TestCase(1000, TestName = "���������� ���� ��������� ������ ����� �� ��������� 1000")]
        public void SetLegHeight_PositiveTest(int Height)
        {
            var legParameters = new LegParameters();
            legParameters.Height = Height;
        }

        [TestCase(30, TestName = "���������� ���� ��������� ����� ����� �� ��������� 30")]
        [TestCase(110, TestName = "���������� ���� ��������� ����� ����� �� ��������� 110")]
        public void SetLegLength_NegativeTest(int Length)
        {
            var legParameters = new LegParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            legParameters.Length = Length);
        }

        [TestCase(40, TestName = "���������� ���� ��������� ����� ����� �� ��������� 40")]
        [TestCase(100, TestName = "���������� ���� ��������� ����� ����� �� ��������� 100")]
        public void SetLegLength_PositiveTest(int Length)
        {
            var legParameters = new LegParameters();
            legParameters.Length = Length;
        }

        [TestCase(45, 40, TestName = "���������� ���� ��������� ������ ����� �� ��������� 35")]
        [TestCase(95, 100, TestName = "���������� ���� ��������� ������ ����� �� ��������� 95")]
        public void SetLegWidth_NegativeTest(int Length, int Width)
        {
            var legParameters = new LegParameters();
            legParameters.Length = Length;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            legParameters.Width = Width);
        }

        [TestCase(40, 40, TestName = "���������� ���� ��������� ������ ����� �� ��������� 40")]
        [TestCase(100, 100, TestName = "���������� ���� ��������� ������ ����� �� ��������� 100")]
        public void SetLegWidth_PositiveTest(int Length, int Width)
        {
            var legParameters = new LegParameters();
            legParameters.Length = Length;
            legParameters.Width = Width;
        }

        [TestCase(0, TestName = "���������� ���� ��������� ������ ����� �� ��������� 0")]
        [TestCase(0, TestName = "���������� ���� ��������� ������ ����� �� ��������� 0")]
        public void SetBondWidth_NegativeTest(int Width)
        {
            var bondParameters = new BondParameters();
            Assert.Throws<ArgumentNullException>(() =>
            bondParameters.Width = Width);
        }

        [TestCase(40, TestName = "���������� ���� ��������� ������ ����� �� ��������� 40")]
        [TestCase(100, TestName = "���������� ���� ��������� ������ ����� �� ��������� 100")]
        public void SetBondWidth_PositiveTest(int Width)
        {
            var bondParameters = new BondParameters();
            bondParameters.Width = Width;
        }

        [TestCase(40, 40, TestName = "���������� ���� ��������� ������ ����� �� ��������� 40")]
        [TestCase(100, 100, TestName = "���������� ���� ��������� ������ ����� �� ��������� 100")]
        public void SetBondHeight_PositiveTest(int Width, int Height)
        {
            var bondParameters = new BondParameters();
            bondParameters.Width = Width;
            bondParameters.Height = Height;
        }


        [TestCase(40, 45, TestName = "���������� ���� ��������� ������ ����� �� ��������� 45")]
        [TestCase(100, 110, TestName = "���������� ���� ��������� ������ ����� �� ��������� 110")]
        public void SetBondHeight_NegativeTest(int Width, int Height)
        {
            var bondParameters = new BondParameters();
            bondParameters.Width = Width;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            bondParameters.Height = Height);
        }


        [TestCase(240, TestName = "���������� ���� ��������� ����� ����� �� ��������� 240")]
        [TestCase(320, TestName = "���������� ���� ��������� ����� ����� �� ��������� 320")]
        public void SetBondLength_PositiveTest(int Length)
        {
            var bondParameters = new BondParameters();
            bondParameters.Length = Length;
        }

        [TestCase(0, TestName = "���������� ���� ��������� ����� ����� �� ��������� 0")]
        [TestCase(0, TestName = "���������� ���� ��������� ����� ����� �� ��������� 0")]
        public void SetBondLength_NegativeTest(int Length)
        {
            var bondParameters = new BondParameters();
            Assert.Throws<ArgumentNullException>(() =>
           bondParameters.Length = Length);
        }

        [TestCase(null, null, null, TestName = "���������� ���� ��� ������ ChairParameters �� ��������� null")]
        public void SetChairParametersBond_NegativeTest(BondParameters bondParameters, SeatParameters 
            seatParameters, LegParameters legParameters)
        {
            var chairParameters = new ChairParameters(new LegParameters(), new SeatParameters(), new BondParameters());
            Assert.Throws<ArgumentNullException>(() =>
           chairParameters.BondParameters = bondParameters);
            Assert.Throws<ArgumentNullException>(() =>
           chairParameters.SeatParameters = seatParameters);
            Assert.Throws<ArgumentNullException>(() =>
           chairParameters.LegParameters = legParameters);
        }
























    }
}