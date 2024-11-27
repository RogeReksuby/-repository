namespace class_lab3
{

    /// <summary>
    /// Элемент разреженной матрицы
    /// </summary>
    class MatrixElement : IComparable
    {
        /// <summary>
        /// Констуктор элемента
        /// </summary>
        /// <param name="x">Номер столбца в матрице</param>
        /// <param name="y">Номер строки в матрице</param>
        /// <param name="elm">Значение элемента матрицы</param>
        public MatrixElement(int x, int y, int elm)
        {
            X = x;
            Y = y;
            Value = elm;
        }
        /// <summary>
        /// Номер столбца
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Номер строки
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Значение элемента
        /// </summary>
        public int Value { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is MatrixElement elm1)
            {
                if (this.Y > elm1.Y) return 1;
                else if (this.Y < elm1.Y) { return -1; }
                else if (this.X == elm1.X) { throw new ArgumentException("Разные элементы с совпадающими позициями"); }
                else return this.X.CompareTo(elm1.X);
            }
            else throw new ArgumentException("Некорректный тип элемента");
        }

    }

    /// <summary>
    /// Разреженная матрица
    /// </summary>
    class SparseMatrix
    {
        /// <summary>
        /// Конструктор пустой матрицы
        /// </summary>
        /// <param name="X">Кол-во столбцов</param>
        /// <param name="Y">Кол-во строк</param>
        public SparseMatrix(int X, int Y)
        {
            dimX = X;
            dimY = Y;
            Elements = new List<MatrixElement>();
        }

        /// <summary>
        /// Размерность по x
        /// </summary>
        public int dimX { get; set; }
        /// <summary>
        /// Размерность по y
        /// </summary>
        public int dimY { get; set; }
        /// <summary>
        /// Список ненулевых элементов матрицы
        /// </summary>
        public List<MatrixElement> Elements { get; set; }
        /// <summary>
        /// Добавление нового элемента в матрицу
        /// </summary>
        /// <param name="x">Номер столбца элемента</param>
        /// <param name="y">Номер строки элемента</param>
        /// <param name="val">Значение элемента</param>
        public void AddElement(int x, int y, int val)
        {
            if (x < 0 || y < 0 || (x > this.dimX) || (y > this.dimY))
                Console.WriteLine("Элемент выходит за пределы матрицы");
            else
            {
                Elements.Add(new MatrixElement(x, y, val));
                Elements.Sort();
            }

        }
        /// <summary>
        /// Вывод элементов на экран
        /// </summary>
        public void PrintElements()
        {
            Console.WriteLine("\nМатрица " + this.dimY + " X " + this.dimX);
            foreach (MatrixElement elm in Elements)
            {
                Console.WriteLine("Элемент на позиции X = " + elm.X +
                    ", Y = " + elm.Y + " имеет значение " + elm.Value);
            }
        }
        /// <summary>
        /// Получение строки, содержащей полное отображение матрицы
        /// </summary>
        /// <returns>Строка, содержащая марицу</returns>
        public override String ToString()
        {
            String res = "";
            int jNum = 0;
            for (int j = 0; j < this.dimY; j++)
            {
                for (int i = 0; i < this.dimX; i++)
                {
                    if (Elements.Count == 0 || Elements.Count <= jNum ||
                        !(Elements[jNum].X == i + 1 && Elements[jNum].Y == j + 1)) res = res + "0 ";
                    else
                    {
                        res = res + Elements[jNum].Value + " ";
                        jNum++;
                    }

                }
                res = res + "\n";
            }
            return res;
        }
    }

}