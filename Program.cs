/// <summary>
/// Интерфейс для вывода на экран информации
/// </summary>
interface IPrint
{
    /// <summary>
    /// Вывод на экран строки с информацией
    /// </summary>
    public void Print();
}

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


class Program
{
    static void Main(string[] args)
    {
        Rectangle a = new Rectangle(2, 3);
        a.Print();
        Square b = new Square(3);
        b.Print();
        Circle c = new Circle(1);
        c.Print();
    }
}


