from book_lib.book import Book
from book_lib.library import Library
from book_lib.booklib import BookLib
from operator import itemgetter

# массив, содержащий объекты "Библиотека"
libs = [
    Library("Библиотека имени Пушкина"), #id 1
    Library("Центральная библиотека"), #id 2
    Library("Детская библиотека"), #id 3
    Library("Библиотека имени Ленина"), #id 4
    Library("Библиотека МГТУ") #id 5
]

# массив, содержащий объекты "Книга"
books = [
    Book("Капитанская дочка", 112, 1), # id 1
    Book("Упражнения по математическому анализу", 218, 5), # id 2
    Book("Колобок", 15, 5), #id 3
    Book("Сказки для детей", 70, 3), #id 4
    Book("Computer Science", 280, 1), # id 5
    Book("Чистый код", 300, 5), # id 6
    Book("Солярис", 200, 4), # id 7
    Book("Краткий курс по выращиванию кабачков", 78, 4), # id 8
    Book("Обломов", 419, 1), # id 9
    Book("Красная шапочка", 45, 3) # id 10
]

# массив книг и библиотек для реализации связи многие ко многим
booklibs = [
    BookLib(1, 1),
    BookLib(1, 3),
    BookLib(2, 5),
    BookLib(3, 5),
    BookLib(4, 3),
    BookLib(3, 3),
    BookLib(5, 1),
    BookLib(5, 5),
    BookLib(6, 5),
    BookLib(7, 4),
    BookLib(7, 2),
    BookLib(8, 4),
    BookLib(9, 1),
    BookLib(9, 4),
    BookLib(9, 3),
    BookLib(8, 2),
    BookLib(10, 3)
]

# основная программа
def main() -> None:

    # списки данных - связь один ко многим
    one_to_many: list[tuple] = [(b.catalogNumber, b.name, l.id, l.name)
    for l in libs
    for b in books
    if (b.libID == l.id)
    ]
    print("\nМассив связей один ко многим: " + str(one_to_many))

    # списки данных - массив многих ко многим (временный)
    many_to_many_temp: list[tuple] = [(b.name, bl.bookID, bl.libID)
    for b in books
    for bl in booklibs
    if b.catalogNumber == bl.bookID
    ]
    # списки данных - массив многих ко многим (временный)
    many_to_many: list[tuple] = [(mm_bookID, mm_book_name, l.id, l.name)
    for l in libs
    for mm_book_name, mm_bookID, mm_libID in many_to_many_temp
    if l.id == mm_libID
    ]
    print("\nМассив связей многие ко многим: " + str(many_to_many))


    # вывод - 1 задание
    # вывести список всех библиотек, которые имеют в названии "Библиотека" (учитывая регистр)
    # для каждой библиотеки - список книг в ней
    print("\n Задача E1\n")
    res1 = [(l , list(filter(lambda i: i.libID == l.id, books)))
    for l in libs
    if ("Библиотека" in l.name)
    ]
    print(res1)

    # вывод - 2 задание
    # вывести список библиотек со средним кол-вом страниц в книгах в каждой библиотеке
    # сортировать по кол-ву страниц по убыванию
    print("\n Задача E2")
    res2: tuple = []
    for l in libs:
        currentBooks: list[Book] = list(filter(lambda i: i.libID == l.id, books))
        pagesCount: list[int] = []
        if (len(currentBooks) > 0):
            pagesCount = [pg.numOfPages for pg in currentBooks]
        
        averagePagesCount: float = 0
        if len(pagesCount) > 0: averagePagesCount = round(sum(pagesCount)/len(pagesCount), 2)
        res2.append((l.name, averagePagesCount))

    res2.sort(key=itemgetter(1), reverse=True)
    print(res2)

    # вывод - 3 задание
    # вывести список книг, название которых начинается с заглавной русской буквы 'К'
    # и название их библиотек
    print("\n Задача E3")
    res3: dict = {}
    for mm_book_id, mm_book_name, mm_lib_id, mm_lib_name in many_to_many:
        if (mm_book_name[0] == 'К'):
            if (mm_book_name not in res3): res3[mm_book_name] = []
            res3[mm_book_name].append(mm_lib_name) 

    print(res3)



if (__name__ == "__main__"):
    main()