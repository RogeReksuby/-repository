namespace class_lab3
{
    /// <summary>
    /// Круг 
    /// </summary>
    class Circle : GeometricShape
    {
        /// <summary>
        /// Конструктор по радиусу
        /// </summary>
        /// <param name="r">Радиус круга</param>
        public Circle(double r)
        {
            Radius = r;
        }
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return ("Круг с радиусом " + Radius.ToString() + "; площадь: " + this.Area());
        }
    }
}