/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Печать массива на экран
void PrintArray2d(int[,] arrayPrint2d)
{
    for (int i = 0; i < arrayPrint2d.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint2d.GetLength(1); j++)
        {
            if (j == (arrayPrint2d.GetLength(1) - 1))
                Console.WriteLine(String.Format("{0,5}]", arrayPrint2d[i, j]));
            else
                Console.Write(String.Format("{0,5} ", arrayPrint2d[i, j]));
        }
    }
}

//Печать одномерного массива на экран
void PrintArray(float[] arrayPrint)
{
    Console.Write("[");
    for (int index = 0; index < arrayPrint.Length; index++)
    {
        if (index == (arrayPrint.Length - 1))
            Console.WriteLine(String.Format("{0,5:0.00}]", arrayPrint[index]));
        else
            Console.Write(String.Format("{0,5:0.00} ", arrayPrint[index]));
    }
}

//Создание случайного двумерного массива
int[,] CreateRandom2DArray(int m, int n, int min, int max)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = random.Next(min, max + 1);
        }
    }
    return array2D;
}

//Запрос на количество столбцов в массиве
int GetColumnsLengthArray()
{
    Console.Write("Сколько столбцов будет в массиве? ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Массив не может быть создан. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

//Запрос на количество строк в массиве
int GetRowsLengthArray()
{
    Console.Write("Сколько строк будет в массиве? ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Массив не может быть создан. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

//Получение минимума или максимума от пользователя
int GetMinMax(string minOrMax)
{
    Console.Write($"Введите значение {minOrMax}: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

//Создание массива средних арифметических по каждому столбцу
float[] CreateArithmeticMeanArray(int[,] array2d)
{
    float[] resultArray = new float[array2d.GetLength(1)];
    float sum = 0;
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array2d.GetLength(0); j++)
        {
            sum += array2d[j, i];
        }
        resultArray[i] = sum / array2d.GetLength(0);
    }
    return resultArray;
}

Console.WriteLine("Программа генерирует двумерный массив из случайных целых чисел в количестве и диапазоне, которое вводит пользователь.");
Console.WriteLine("После программа считает среднее арифметическое каждого столбца и выводит его на экран.");
int m = GetRowsLengthArray();
int n = GetColumnsLengthArray();
int min = GetMinMax("минимума");
int max = GetMinMax("максимума");

int[,] random2dArray = CreateRandom2DArray(m, n, min, max);
PrintArray2d(random2dArray);
float[] arithmeticMeanArray = CreateArithmeticMeanArray(random2dArray);
Console.WriteLine("Средние арифметические:");
PrintArray(arithmeticMeanArray);

Author();