import math

def hipotenusa(n):
    i = 1
    while(i <= n):
        j = 1
        while(j <= n):
            a = i
            b = j
            c = int(math.sqrt((a ** 2) + (b ** 2)))
            if (c > a) and (c > b) and (c < (a + b)):
                if ((a ** 2) + (b ** 2) == c ** 2):
                    if(c == n):
                        return c
            j = j +1
        i = i + 1

    return 0

def soma_hipotenusas(n):
    soma = 0
    old = 0
    i = 1
    for i in range(1,n+1):
        result = hipotenusa(i)
        if(result > old):
            old = result
            soma = soma + result

    return soma
