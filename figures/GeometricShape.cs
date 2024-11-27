using System.ComponentModel.Design;

namespace class_lab3
{
    /// <summary>
    /// ����������� ����� - �������������� ������
    /// </summary>
    abstract class GeometricShape: IPrint, IComparable
    {
        /// <summary>
        /// ���������� �������
        /// </summary>
        /// <returns>������� ������</returns>
        public abstract double Area();
        /// <summary>
        /// ����� ���������� � ������
        /// </summary>
        /// <returns>������ � ��������� ����������� ������</returns>
        public abstract string ToString();
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public int CompareTo(object? obj)
        {
            if (obj is GeometricShape figure) return Area().CompareTo(figure.Area()); 
            else throw new ArgumentException("������������ ��� ��������");
        }
    }
}