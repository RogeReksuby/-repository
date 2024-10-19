class Book:

    # текущее кол-во книг
    counter: int = 0

    @staticmethod
    def getCounter() -> int:
        return Book.counter
    
    @staticmethod
    def addCounter() -> None:
        Book.counter+=1

    # конструктор по всем параметрам
    def __init__(self, name: str, numOfPages: str, libID: str) -> None:
        Book.addCounter()
        self._catalogNumber: int = Book.getCounter()
        self._name: str = name
        self._numOfPages: int = numOfPages
        self._libID: int = libID
    
    # cвойство - номер в каталоге (а можно ли его менять?)
    @property
    def catalogNumber(self) -> int: return self._catalogNumber
    @catalogNumber.setter
    def catalogNumber(self, num: int) -> None: self._catalogNumber = num

    # cвойство - название книги
    @property
    def name(self) -> str: return self._name
    @name.setter
    def name(self, name: str) -> None: self._name = name

    # cвойство - кол-во страниц
    @property
    def numOfPages(self) -> int: return self._numOfPages
    @numOfPages.setter
    def numOfPages(self, num: int) -> None: self._numOfPages = num

    # cвойство - id библиотеки
    @property
    def libID(self) -> int: return self._libID
    @libID.setter
    def libID(self, num: int) -> None: self._libID = num

    # to string
    def __repr__(self) -> str: return self.name
