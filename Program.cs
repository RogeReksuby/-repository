using System.Collections;

namespace class_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region создание геометрических фигур
                Rectangle myRect = new Rectangle(9, 3);
                myRect.Print();
                Square mySquare = new Square(3);
                mySquare.Print();
                Circle myCircle = new Circle(10);
                myCircle.Print();
                #endregion

                #region создание коллекции класса ArrayList
                Console.WriteLine("\nСоздание коллекции ArrayList и сортировка");
                ArrayList figuresArr = [myCircle, myRect, mySquare];
                figuresArr.Sort();
                foreach (object obj in figuresArr)
                {
                    if (obj is GeometricShape)
                    {
                        GeometricShape res = (GeometricShape)obj;
                        res.Print();
                    }
                }
                #endregion
                
                #region создание коллекции класса List
                Console.WriteLine("\nСоздание коллекции List и сортировка");
                List<GeometricShape> figuresList = [myRect, myCircle, mySquare];
                figuresList.Sort();
                foreach (GeometricShape gs in figuresList)
                {
                     gs.Print();
                }
                #endregion

                #region работа с матрицей
                SparseMatrix MyMatrix = new SparseMatrix(5, 5);
                MyMatrix.AddElement(89, 24, 5);
                MyMatrix.AddElement(1, 1, 2);
                MyMatrix.AddElement(1, 4, 3);
                MyMatrix.AddElement(5, 5, 8);

                MyMatrix.PrintElements();
                Console.WriteLine(MyMatrix.ToString());
                #endregion

                #region работа со стеком

                var myStack = new SimpleStack<GeometricShape>();

                myStack.PrintElements();
                myStack.Push(myRect);
                myStack.Push(mySquare);
                myStack.Push(myCircle);

                myStack.PrintElements();
                myStack.Pop();
                myStack.PrintElements();
                #endregion

            }
            catch (Exception ex) {Console.WriteLine("Ошибка: " + ex.Message);}
            
        }
    }

}


