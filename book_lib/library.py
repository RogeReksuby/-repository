
class Library:

    # текущее кол-во библиотек
    counter: int = 0

    @staticmethod
    def getCounter() -> int:
        return Library.counter
    
    @staticmethod
    def addCounter() -> None:
        Library.counter+=1

    def __init__(self, name: str) -> None:
        Library.addCounter()
        self._id: int = Library.getCounter()
        self._name: str = name

    # cвойство - id библиотеки
    @property
    def id(self) -> int: return self._id
    @id.setter
    def id(self, id: int) -> None: self._id = id

    # свойство - название библиотеки
    @property
    def name(self) -> str: return self._name
    @name.setter
    def name(self, name: str) -> None: self._name = name
    
    # to string
    def __repr__(self) -> str: return self.name
