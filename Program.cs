// // Task1
// //Массив целых чисел
// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 3;
// //arr[5] = 5;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// //заполнение массива при создании
// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
// int[] arr3 = { 1, 2, 3, 4, 5 };
// // Python
// // arr=[1,2,3,4,5]

// //Task2
// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// //while (i < n)
// while (i < arr.Length)
// {
//     arr[i] = i + 1;
//     //System.Console.Write(arr[i]);
//     //System.Console.Write(" ");
//     //лаконичнее:
//     System.Console.Write($"{arr[i]} ");
//     i++;
// }

// //Task3
// //Пусть дан массив на некоторое количество целых чисел, например, 10 штук.
// //Требуется найти в массиве четные числа и вывести их на экран. 
// // int[] arrT3 = {9,5,7,1,15,36,3,1,1,7};
// int n = 10;
// int[] arr4 = { 1, 5, 4, 6, 9, 3, 2, 5, 4, 1 };
// int i = 0;

// while (i < n)
// {
//     //лишнееб ошибка arr4[i] = i + 1;
//     if (arr4[i] % 2 == 0)
//     {
//         Console.Write($"{arr4[i]} ");
//     }
//     i = i + 1;
// }

//Task4
//максимально тяжелая гиря из 100
using System.ComponentModel.DataAnnotations;

int n = 5;
int[] arrТ4 = { 7000, 5000, 200, 1, -7000 };
int i = 0;
int max = arrТ4[0];

while (i < n)
{
    if (arrТ4[i] > max)
    {
        max = arrТ4[i];
    }
    i++;
}
Console.WriteLine(max);

max = arrТ4[0];
for (int j = 0; j < n; j++)
{
    if (arrТ4[j] > max)
    {
        max = arrТ4[j];
    }
}
Console.WriteLine(max);

max = arrТ4[0];
foreach (int e in arrТ4)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);