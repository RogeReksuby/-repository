from lab_python_oop.shape import GeometricShape
from lab_python_oop.colour import Colour
from math import pi

class Circle(GeometricShape):

    FIGURE_TYPE = "Круг"

    @classmethod
    def getFigureType(class_v):
        return class_v.FIGURE_TYPE

    def __init__(self, r, col):
        self._radius = r
        self._colour = Colour()
        self._colour.shapeColour = col

    @property
    def Radius(self):
        return self._radius

    @Radius.setter
    def Radius(self, r):
        self._radius = r

    @Radius.deleter
    def Radius(self, r):
        del self._radius

    def Area(self):
        return pi * (self.Radius * self.Radius)

    def __repr__(self):
        return '{} c радиусом {} и площадью {}'.format(
            Circle.getFigureType(),
            self.Radius,
            self.Area()
        )