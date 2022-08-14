/*
Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X.
Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N – количество элементов в массиве. 
Во второй строке записаны N целых чисел Ai, разделенные пробелом. Третья строка содержит число X. 
Все числа во входных данных не превосходят 1000 по абсолютной величине.
Выходные данные
В выходной файл OUTPUT.TXT выведите значение элемента массива, ближайшее к X. 
Если таких значений несколько, следует вывести наименьшее среди них.
*/

// Console.Write("\nВведите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1, 100);
// }
// Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

// Console.Write("Введите число: ");
// int X = Convert.ToInt32(Console.ReadLine());

// int[] tempArray = new int[size + 1];
// tempArray[tempArray.Length - 1] = X;
// for (int i = 0; i < tempArray.Length - 1; i++)
//     tempArray[i] = array[i];

// for (int i = 0; i < tempArray.Length; i++)
// {
//     for (int j = 0; j < tempArray.Length - 1; j++)
//     {
//         if (tempArray[j] > tempArray[j + 1])
//         {
//             int temp = tempArray[j];
//             tempArray[j] = tempArray[j + 1];
//             tempArray[j + 1] = temp;
//         }
//     }
// }
// int indexX = 0;
// for (int i = 0; i < tempArray.Length; i++)
// {
//     if (tempArray[i] == X)
//     {
//         indexX = i;
//         break;
//     }
// }

// int closeInSize = 0;
// int closeInSize2 = 0;

// if (indexX == tempArray.Length - 1)
//     closeInSize = tempArray[indexX - 1];
// if (indexX == 0)
//     closeInSize = tempArray[indexX + 1];
//     closeInSize2 = tempArray[indexX + 2];
// if (indexX != tempArray.Length - 1 && indexX != 0)
// {
//     closeInSize = tempArray[indexX - 1];
//     closeInSize2 = tempArray[indexX + 1];
// }

// if (closeInSize > closeInSize2) Console.WriteLine($"Ближайшее число равно: {closeInSize2}");
// if (closeInSize < closeInSize2) Console.WriteLine($"Ближайшее число равно: {closeInSize}");
// if (closeInSize == closeInSize2) Console.WriteLine($"Ближайшее число равно: {closeInSize}");

/*
Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на максимальные. 
Напишите программу, которая заменяет оценки Василия, но наоборот: все максимальные – на минимальные.
Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N – количество оценок в журнале. 
Во второй строке записаны N целых чисел Ai – оценки Василия. Все числа во входных данных не превышают 1000 по абсолютной величине.
Выходные данные
В выходной файл OUTPUT.TXT выведите исправленные оценки, сохранив порядок.
*/

Console.Write("\nВведите количество оценок в журнале: ");
int size2 = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int[size2];

for (int i = 0; i < size2; i++)
{
    array2[i] = new Random().Next(1, 6);
}
Console.WriteLine("Оценки: [" + string.Join(", ", array2) + "]");

int min = 5;
int max = 1;

for (int i = 0; i < size2; i++)
{
    if (array2[i] < min) min = array2[i];
    if (array2[i] > max) max = array2[i];
}

for (int i = 0; i < size2; i++)
{
    if(array2[i]==max) array2[i] = min;
}

Console.WriteLine("Исправленные оценки: [" + string.Join(", ", array2) + "]");