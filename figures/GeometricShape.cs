using System.ComponentModel.Design;

namespace class_lab3
{
    /// <summary>
    /// Абстрактный класс - Геометрическая Фигура
    /// </summary>
    abstract class GeometricShape: IPrint, IComparable
    {
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double Area();
        /// <summary>
        /// Вывод информации о фигуре
        /// </summary>
        /// <returns>Строка с основными параметрами фигуры</returns>
        public abstract string ToString();
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public int CompareTo(object? obj)
        {
            if (obj is GeometricShape figure) return Area().CompareTo(figure.Area()); 
            else throw new ArgumentException("Некорректный тип элемента");
        }
    }
}