import math
import sys


def get_args():
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
            return [a, b, c, D]


def get_roots(a, b, c, D):
    res_roots = []
    r1 = (-b + D) / (2 * a)
    r2 = (-b - D) / (2 * a)
    print(r1, ' ', r2)
    if (r1 >= 0):
        res_roots.append(math.sqrt(r1))
        res_roots.append(-res_roots[-1])
        
    if (r2 >= 0 and r2 != r1):
        res_roots.append(math.sqrt(r2))
        res_roots.append(-res_roots[-1])
    
    return res_roots


def print_roots(roots):
    if (len(roots) == 0):
        print('Уравнение не имеет действительных корней')
    else:
        print('Корни уравнения: ', end='')
        for j in roots:
            print(j, end=' ')
        print('')



args = get_args()
roots = get_roots(args[0], args[1], args[2], math.sqrt(args[3]))
print_roots(roots)

