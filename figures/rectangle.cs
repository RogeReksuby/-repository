namespace class_lab3
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    class Rectangle : GeometricShape, IPrint
    {
        /// <summary>
        /// Конструктор по двум параметрам
        /// </summary>
        /// <param name="h">Высота</param>
        /// <param name="w">Ширина</param>
        public Rectangle(double h, double w)
        {
            this.Height = h;
            this.Width = w;
        }
        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return ("Прямоугольник со сторонами " + Height.ToString() + " и " + Width.ToString()
                + "; площадь: " + this.Area());
        }

        //public void Print()
        //{
        //    Console.WriteLine(this.ToString());
        //}
    }
}