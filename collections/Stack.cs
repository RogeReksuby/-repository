
namespace class_lab3
{
    /// <summary>
    /// ������� ������������ ������
    /// </summary>
    /// <typeparam name="Typ">��� ��������� � ������</typeparam>
    class ElementOfList<Typ>
    {
        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="val">�������� ��������</param>
        public ElementOfList(Typ val)
        {
            Value = val;
            Next = null;
        }
        /// <summary>
        /// ��������
        /// </summary>
        public Typ Value { get; set; }
        /// <summary>
        /// ��������� �������
        /// </summary>
        public ElementOfList<Typ>? Next { get; set; }

        //public override string ToString()
        //{
        //    if (Value == null) return "null";
        //    else return Value.ToString();
        //}
    }
    /// <summary>
    /// ����� - ����
    /// </summary>
    /// <typeparam name="Typ">��� ��������� � �����</typeparam>
    class SimpleStack<Typ>
    {
        /// <summary>
        /// �������� ������� �����
        /// </summary>
        public SimpleStack()
        {
            Element = null;
        }
        /// <summary>
        /// ������� �����
        /// </summary>
        public ElementOfList<Typ>? Element { get; set; }
        /// <summary>
        /// ���������� ������ �������� � ����
        /// </summary>
        /// <param name="elem">��������� ��������</param>
        public void Push(Typ elem)
        {
            ElementOfList<Typ> tempElem = new ElementOfList<Typ>(elem);
            if (Element == null)
            {
                Element = tempElem;
            }
            else
            {
                tempElem.Next = Element;
                Element = tempElem;
            }
        }
        /// <summary>
        /// �������� �������� �� �����
        /// </summary>
        public void Pop()
        {
            if (Element != null)
            {
                Element = Element.Next;
            }
        }

        /// <summary>
        /// ����� ��������� ����� �� �����
        /// </summary>
        public void PrintElements()
        {
            var temp = Element;
            Console.WriteLine("�������� �����:");
            if (temp == null) Console.WriteLine("�������� � ����� ����������");
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.Value.ToString());
                    temp = temp.Next;
                }
            }
        }

    }

}