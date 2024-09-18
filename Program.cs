namespace equation
{
    class Program
    {
        static int Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            double D = -1, r1, r2, r;
            if (args.Length == 3) // если есть аргументы командной строки
            {
                a = Convert.ToInt32(args[0]);
                b = Convert.ToInt32(args[1]);
                c = Convert.ToInt32(args[2]);
                D = b * b - 4 * a * c;
            }
            else // если нет аргументов
            {
                while (D < 0) // пока не будут действительные корни при заданных аргументах
                {
                    Console.Write("Уравнение имеет вид ax^4 + bx^2 + c\n" +
                        "Введите коэффициент a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите коэффициент b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите коэффициент c: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    D = b * b - 4 * a * c;
                    if (D < 0)
                        Console.WriteLine("При данных коэф-ах корни не являются действительными");
                }
            }


            // определение наличия, количества и самих корней квадратного уравнения
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Уравнение имеет следующие действительные корни: ");


                if (D == 0)
                {
                    Console.WriteLine("Уравнение имеет единственный корень: {0}", (-b) / (2 * a));
                }
                else
                {
                    D = Math.Sqrt(D);
                    Console.WriteLine("Корни данного квадратного уравнения: {0}; {1}",
                        (-b + D) / (2 * a), (-b - D) / (2 * a));

                }
            }



            if (D >= 0) // дискриминант >= 0 -> корни могут существовать
            {
                r1 = (-b + D) / (2 * a);
                r2 = (-b - D) / (2 * a);
                if (r1 >= 0 || r2 >= 0) // хотя бы один из квадратов корней положителен
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Уравнение имеет следующие действительные корни: ");
                    if (r1 >= 0) // проверка первого
                    {
                        r = Math.Sqrt(r1);
                        Console.Write("{0}; {1} ", r1, -r1);
                        if (r1 == r2) // проверка на совпадение двух квадратов
                        {
                            Console.WriteLine("");
                            Console.ResetColor();
                            return 0; 
                        }
                    }
                    if (r2 >= 0) // проверка второго
                    {
                        r = Math.Sqrt(r2);
                        Console.Write("{0}; {1} ", r2, -r2);
                    }

                    Console.WriteLine("");
                    Console.ResetColor();
                    return 0;
                }
            }

            // если корни не были найдены
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Уравнение не имеет действительных корней");
            Console.ResetColor();
            return 0;
        }
    }
}



