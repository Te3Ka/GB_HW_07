/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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
void PrintArray(float[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayPrint[i,j]}, ");
        }
        Console.WriteLine();
    }
}

//Создание случайного двумерного массива
float[,] CreateRandom2DArray(int m, int n, float min, float max)
{
    float[,] array2D = new float[m, n];
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i,j] = random.NextSingle() * (max - min) + min;
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
float GetMinMax(string minOrMax)
{
    Console.Write($"Введите значение {minOrMax}: ");
    float.TryParse(Console.ReadLine(), out float result);
    return result;
}

Console.WriteLine("Программа генерирует массив из случайных вещественных чисел в количестве и диапазоне, которое вводит пользователь.");
int m = GetColumnsLengthArray();
int n = GetRowsLengthArray();
float min = GetMinMax("минимума");
float max = GetMinMax("максимума");
PrintArray(CreateRandom2DArray(m, n, min, max));

Author();