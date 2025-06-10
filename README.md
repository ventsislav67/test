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
![ето](https://i.ibb.co/q3JdVDjQ/your-image.jpg)
# Какво трябва да изкара програмата
![Снимка](https://postimg.cc/p5bBfTBY.jpg)



