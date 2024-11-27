namespace class_lab3
{

    /// <summary>
    /// Квадрат
    /// </summary>
    class Square : Rectangle
    {
        /// <summary>
        /// Конструктор по одному параметру
        /// </summary>
        /// <param name="a">Сторона квадрата</param>
        public Square(double a) : base(a, a) { }

        public override string ToString()
        {
            return ("Квадрат со стороной " + Height.ToString() + "; площадь: " + this.Area());
        }
    }
}