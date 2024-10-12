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