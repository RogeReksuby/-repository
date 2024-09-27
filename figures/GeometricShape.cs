namespace class_lab2
{
    /// <summary>
    /// ����������� ����� - �������������� ������
    /// </summary>
    abstract class GeometricShape
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
    }
}