import abc
from math import pi
from jinja2 import Template

class GeometricShape(abc.ABC):
    @abc.abstractmethod
    def Area(self): pass

    @abc.abstractclassmethod
    def getFigureType(class_v): pass

class Colour():
    def __init__(self):
        self._shapeColour = None

#    def __init__(self, col):
#        self._shapeColour = col

    @property
    def shapeColour(self):
        return self._shapeColour

    @shapeColour.setter
    def shapeColour(self, value):
        self._shapeColour = value

    @shapeColour.deleter
    def shapeColour(self):
        del self._shapeColour

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

puk = Rectangle(2, 12, "Зеленый")
print(puk)
puk2 = Circle(10, "Корчиневый")
print(puk2)
puk3 = Square(2, "Желтый")
print(puk3)




#link = ('В html документе ссылки представляются так: \n'
#        '<a href="#">Ссылка</a>')
#tmp = Template("{{ link | e}}")

#cities = [
#        {'id':1, 'city':'Москва'},
#        {'id':7, 'city':'Минск'},
#        {'id':5, 'city':'Тверь'},
#        {'id':8, 'city':'Смоленск'},
#        {'id':11, 'city':'Калуга'}
#        ]
#link = '''<select name="cities">
#{% for c in cities -%}
#{% if c.id > 6 -%}
#    <option value="{{c['id']}}">{{c['city']}}</option>
#{%else-%}
#    {{c['city']}}
#{%endif%}    
#{% endfor %}
#'''

#tmp = Template(link)

#res = tmp.render(cities = cities)

#print(res)