from lab_python_oop.rectangle import Rectangle
from lab_python_oop.circle import Circle
from lab_python_oop.square import Square
import art

def main():
    myRec = Rectangle(13, 13, "Синий")
    myCirc = Circle(13, "Зеленый")
    mySquare =Square(13, "Красный")
    print(art.text2art("My Figures"))    
    print(myRec)
    print(myCirc)
    print(mySquare)

if (__name__ == "__main__"):
    main()