import abc

class GeometricShape(abc.ABC):
    @abc.abstractmethod
    def Area(self): pass

    @abc.abstractclassmethod
    def getFigureType(class_v): pass
