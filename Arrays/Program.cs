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

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 100);
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());
int CloseInSize(int[] array, int X)
{
    int[] tempArray = new int[array.Length + 1];
    tempArray[tempArray.Length - 1] = X;
    for (int i = 0; i < tempArray.Length - 1; i++)
        tempArray[i] = array[i];
    for (int i = 0; i < tempArray.Length; i++)
    {
        for (int j = 0; j < tempArray.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    int indexX = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] == X)
        {
            indexX = i;
            break;
        }
    }
    int closeInSize = 0;
    if (indexX == tempArray.Length - 1)
        closeInSize = tempArray[indexX - 1];
    int closeInSize2 = 0;
    if (indexX != tempArray.Length - 1)
    {
        closeInSize = tempArray[indexX - 1];
        closeInSize2 = tempArray[indexX + 1];
    }
    if (closeInSize > closeInSize2) return closeInSize;
    if (closeInSize < closeInSize2) return closeInSize = closeInSize2;
    if (closeInSize == closeInSize2) return closeInSize;

    return closeInSize;
}

int closeInSize = CloseInSize(array, X);
Console.WriteLine($"\nБлижайшее число равно: {closeInSize}");