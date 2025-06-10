# test
# ВЕНЦИСЛАВ МИРОСЛАВОВ КОЛЕВ
# 10.06.25

###  ЗА ЖЕЛЕВ!
## задачата сортира масива чрез insertion sort и извежда подредения масив, най дълга поредица от най малкото и дължина на масива!
# част от кода
int[] arr3 = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };
int n3 = arr3.Length;


for (int i = 1; i < n3; i++)
{
    int key = arr3[i];
    int j = i - 1;
    while (j >= 0 && arr3[j] > key)
    {
        arr3[j + 1] = arr3[j];
        j--;
    }
    arr3[j + 1] = key;
} 
# снимка как действа кода
[![2025-06-10-102343.png](https://i.postimg.cc/htCsKtgR/2025-06-10-102343.png)](https://postimg.cc/v4VfzMc0)
# Какво трябва да изкара програмата
[![eto22.png](https://i.postimg.cc/xC16KNRC/eto22.png)](https://postimg.cc/f317sL1n)




