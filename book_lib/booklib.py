class BookLib:
    def __init__(self, bookID: int, libID: int) -> None:
        self._bookID: int = bookID
        self._libID: int = libID

    @property
    def bookID(self) -> int: return self._bookID
    @bookID.setter
    def bookID(self, bookID: int) -> None: self._bookID = bookID

    @property
    def libID(self) -> int: return self._libID
    @libID.setter
    def libID(self, libID: int) -> None: self._libID = libID
