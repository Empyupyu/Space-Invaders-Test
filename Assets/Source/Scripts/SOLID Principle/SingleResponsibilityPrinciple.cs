using UnityEngine;

namespace SOLID
{
    public sealed class SingleResponsibilityPrinciple
    {
        /// <summary>
        ///   ���� ������� ��������, ��� ������ ����� ��� �������� ��������� � ����� ���� ������ �������� ������ �� ���� ����.
        ///   ��� ����� ����� ������ ������ ���� ������� ����� �����. ��� ����� �� ������ ���� ����� �� ����������� ���,
        ///   � ������� ��� ��������� ������ �� ������ ����� �������� ���� ��������������. ��� �� ��������,
        ///   ��� ���� ������ ������ ��������� ������ ���� ����� ��� ��������. ����� ���� ����� ������, ���� ��� ��������� � ������ ���������������.
        ///   
        ///   ������� ������ ��������������� ���� ��� ������� ������ ����������� ������� �� ����� �������������� ���������� �
        ///   ���������� ��� ������ � ���� �������� ��������� ������.������� ���������� ������������ ����������� ������ �����,
        ///   ����� ������� ������ ������� ����, ��� ���������� ������ ��������.
        /// </summary>

        public void Case()
        {
            Tangerine tangerine = new Tangerine(new TangerinePeel(Color.yellow));
        }
    }

    #region BadCase
    //������ ��������� SRP
    public class TangerineAndTangerinePeel
    {
        public float Size { get; set; }
        public Color Color { get; private set; }
        public bool HasPeel { get; private set; }

        public void Scaling()
        {
            Size += 1f * Time.deltaTime;
        }

        public void Peeling()
        {
            HasPeel = false;
        }
    }
    #endregion

    #region GoodCase
    //������ ���������� SRP 
    public class Tangerine
    {
        public float Size { get; private set; }
        public TangerinePeel TangerinePeel { get; private set; }

        public Tangerine(TangerinePeel tangerinePeel)
        {
            TangerinePeel = tangerinePeel;
        }

        public void Scaling()
        {
            Size += 1f * Time.deltaTime;
        }
    }

    public class TangerinePeel
    {
        public Color Color { get; private set; }
        public bool HasPeel { get; private set; }

        public TangerinePeel(Color color)
        {
            Color = color;
            HasPeel = true;
        }

        public void Peeling()
        {
            HasPeel = false;
        }
    }
    #endregion
}
