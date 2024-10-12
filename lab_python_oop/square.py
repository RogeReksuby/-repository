from lab_python_oop.rectangle import Rectangle

class Square(Rectangle):
    def __init__(self, w, col):
        super().__init__(w, w, col)
    
    FIGURE_TYPE = "Квадрат"

    def __repr__(self):
        return '{} со стороной {} и площадью {}'.format(
            Square.getFigureType(),
            self.Width,
            self.Area()
        )