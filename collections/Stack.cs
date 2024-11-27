
namespace class_lab3
{
    /// <summary>
    /// Элемент односвязного списка
    /// </summary>
    /// <typeparam name="Typ">Тип элементов в списке</typeparam>
    class ElementOfList<Typ>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="val">Значение элемента</param>
        public ElementOfList(Typ val)
        {
            Value = val;
            Next = null;
        }
        /// <summary>
        /// Значение
        /// </summary>
        public Typ Value { get; set; }
        /// <summary>
        /// Следующий элемент
        /// </summary>
        public ElementOfList<Typ>? Next { get; set; }

        //public override string ToString()
        //{
        //    if (Value == null) return "null";
        //    else return Value.ToString();
        //}
    }
    /// <summary>
    /// Класс - стек
    /// </summary>
    /// <typeparam name="Typ">Тип элементов в стеке</typeparam>
    class SimpleStack<Typ>
    {
        /// <summary>
        /// Создание пустого стека
        /// </summary>
        public SimpleStack()
        {
            Element = null;
        }
        /// <summary>
        /// Элемент стека
        /// </summary>
        public ElementOfList<Typ>? Element { get; set; }
        /// <summary>
        /// Добавление нового элемента в стек
        /// </summary>
        /// <param name="elem">Значениие элемента</param>
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
        /// Удаление элемента из стека
        /// </summary>
        public void Pop()
        {
            if (Element != null)
            {
                Element = Element.Next;
            }
        }

        /// <summary>
        /// Вывод элементов стека на экран
        /// </summary>
        public void PrintElements()
        {
            var temp = Element;
            Console.WriteLine("Элементы стека:");
            if (temp == null) Console.WriteLine("Элементы в стеке отсутсвуют");
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