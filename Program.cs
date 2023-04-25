// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Ввод числа с экрана
int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}
// Метод для получения случайных значений массива
int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for(int i=0; i < Length; i++)
    {
        array[i] = random.Next(minValue,maxValue+1);
    }
    return array;
}
// Метод вывода массива
void PrintArray (int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

// Метод подсчета четных чисел
int Even (int [] array)
{
    int result_even =0;
     for(int i=0; i<array.Length; i++)
     {
       if (array[i] % 2 == 0) {result_even++;}
     }
    return result_even;
}



int length = Promt("Длинна массива: ");
int min = 100; //Promt("Начальное значение для диапазона случайного числа: ");
int max = 999; //Promt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray (length, min, max);
PrintArray (array);
int result = Even(array);
Console.WriteLine(result);