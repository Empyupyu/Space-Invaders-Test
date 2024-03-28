using UnityEngine;

namespace SOLID
{
    public sealed class OpenClosedPrinciple
    {
        /// <summary>
        ///   ������� ���������� ������� �������� �������� ��, ��� ����� ������ ���� ������ ��� ����������,
        ///   �� ������ �� �����������. ��� ������ ������ ���� ���������� ���, ����� ����� ���������������� 
        ///   ����� ���� ��������� ������ ��� �������� ����� ����������. ������� ��� ����������� ��������, 
        ///   ��� �� ��� ����������� �����, � �� ������ ��������� ������������. �� �� ������ ������ ���, ���� �� ������ ������. 
        ///   ��� ���������, ����� ������ ���� �������� ������ ��� ���������� � � C# �� ����� ������������ ��� ����� ������������.
        /// </summary>
        public void Case()
        {
            Table table = new Table();

            ITableDecoration tableDecoration = new TableClothDecoration();

            tableDecoration.Decoration(table);

            tableDecoration = new TableFlowerDecoration();

            tableDecoration.Decoration(table);
        }
    }

    #region BadCase
    //������ ��������� OCP
    public class TableDecoration
    {
        public string DecorationType { get; private set; }

        public void Decoration(Table table)
        {
            if (DecorationType == "�������� ���������")
            {

            }
            else if (DecorationType == "�������� �������")
            {

            }
        }
    }

    public class Table { }

    #endregion

    #region GoodCase
    //������ ���������� OCP 
    public abstract class ITableDecoration
    {
        public virtual void Decoration(Table table)
        {
            Debug.Log("Base realisation");
        }
    }

    public class TableFlowerDecoration : ITableDecoration
    {
        public override void Decoration(Table table)
        {
            Debug.Log("Flower realisation");
        }
    }

    public class TableClothDecoration : ITableDecoration
    {
        public override void Decoration(Table table)
        {
            Debug.Log("Tablecloth realisation");
        }
    }
    #endregion
}
