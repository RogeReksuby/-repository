from lab_python_oop.shape import GeometricShape
from lab_python_oop.colour import Colour

class Rectangle(GeometricShape):

    FIGURE_TYPE = "Прямоугольник"

    @classmethod
    def getFigureType(class_v):
        return class_v.FIGURE_TYPE

    def __init__(self, w, h, col):
        self._width = w
        self._height = h
        self._colour = Colour()
        self._colour.shapeColour = col
    
    @property
    def Width(self):
        return self._width

    @Width.setter
    def Width(self, w):
        self._width = w

    @Width.deleter
    def Radius(self, w):
        del self._width

    @property
    def Height(self):
        return self._height

    @Height.setter
    def Height(self, h):
        self._height = h

    @Height.deleter
    def Height(self, h):
        del self._height

    def Area(self):
        return self.Width * self.Height

    def __repr__(self) :
        return '{} cо сторонами {} и {}, площадь равна {}'.format(
            Rectangle.getFigureType(),
            self.Width,
            self.Height,
            self.Area()
            )