using NUnit.Framework;
using System;
using SolidworksChairPlugin.Model;

namespace ModelParametersTests
{
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

        [TestCase(45, 40, TestName = "���������� ���� ��������� ������ ����� �� ��������� 35")]
        [TestCase(95, 100, TestName = "���������� ���� ��������� ������ ����� �� ��������� 95")]
        public void SetLegWidth_NegativeTest(int Length, int Width)
        {
            var legParameters = new LegParameters();
            legParameters.Length = Length;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            legParameters.Width = Width);
        }

 












    }
}