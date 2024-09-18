import math
import sys

class Eqt:
    def __init__(self):
        D = -1
        while (D < 0):
            if (len(sys.argv) == 4):
                a = int(sys.argv[1])
                b = int(sys.argv[2])
                c = int(sys.argv[3])
            else:
                print('Уравнение имеет вид ax^4 + bx^2 + c')
                print('Введите a: ', end = '')
                a = int(input())
                print('Введите b: ', end = '')
                b = int(input())
                print('Введите c: ', end = '')
                c = int(input())
            D = b*b - 4*a*c
            if (D < 0):
                print('Дискриминант D = ', D, ' меньше нуля')
            else:
                print('Дискриминант D = ', D)
                self.a = a
                self.b = b
                self.c = c
                self.D = D
                self.roots = []


    def get_roots(self):
        D = math.sqrt(self.D)
        r1 = (-self.b + D) / (2 * self.a)
        r2 = (-self.b - D) / (2 * self.a)
        print(r1, ' ', r2)
        if (r1 >= 0):
            self.roots.append(math.sqrt(r1))
            self.roots.append(-self.roots[-1])
        
        if (r2 >= 0 and r2 != r1):
            self.roots.append(math.sqrt(r2))
            self.roots.append(-self.roots[-1])
    
    def print_roots(self):
        if (len(self.roots) == 0):
            print('Уравнение не имеет действительных корней')
        else:
            print('Корни уравнения: ', end='')
            for j in self.roots:
                print(j, end=' ')
            print('')   



my_eqt = Eqt()
my_eqt.get_roots()
my_eqt.print_roots()




