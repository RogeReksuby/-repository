namespace class_lab2
{
    /// <summary>
    /// Абстрактный класс - Геометрическая Фигура
    /// </summary>
    abstract class GeometricShape
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
    }
}