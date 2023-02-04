/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            if (j == (arrayPrint.GetLength(1) - 1))
                Console.WriteLine(String.Format("{0,5}]", arrayPrint[i, j]));
            else
                Console.Write(String.Format("{0,5} ", arrayPrint[i, j]));
        }
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

//Получение позиции столбца от пользователя
int GetColumnsPosition()
{
    Console.Write("В каком столбце ищем? ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Нельзя совершить поиск. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

//Получение позиции строки от пользователя
int GetRowsPosition()
{
    Console.Write("В какой строке ищем? ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Нельзя совершить поиск. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

//Поиска элемента по столбцу и строке   
void FindElement(int[,] array2d, int row, int column)
{
    if (row > array2d.GetLength(0) || column > array2d.GetLength(1))
    {
        Console.WriteLine($"Элемента на позиции {row}, {column} не существует");
        return;
    }
    else
    {
        Console.WriteLine($"Элемента на позиции {row}, {column} => {array2d[row - 1, column - 1]}");
        return;
    }
}

Console.WriteLine("Программа генерирует двумерный массив из случайных целых чисел в количестве и диапазоне, которое вводит пользователь.");
Console.WriteLine("После программа показывает значение элемента массива по введённым координатам от пользователя.");
int m = GetRowsLengthArray();
int n = GetColumnsLengthArray();
int min = GetMinMax("минимума");
int max = GetMinMax("максимума");

int[,] random2dArray = CreateRandom2DArray(m, n, min, max);
PrintArray(random2dArray);

int rowsPosition = GetRowsPosition();
int columnsPosition = GetColumnsPosition();

FindElement(random2dArray, rowsPosition, columnsPosition);

Author();