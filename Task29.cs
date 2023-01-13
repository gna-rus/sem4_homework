/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
void InputNumber(int count) //ввод значений, проверка на int, заполнение массива
{
    int i = 0;
    int[] arr = new int[count+1]; // обьявление массива
    while (i < count)
    {
        Console.WriteLine($"Введите число №{i + 1}");
        bool flag = int.TryParse(Console.ReadLine(), out int num); //ввод значения с клавиатуры и проверка на int
        if (flag == true)
        {
            i++;
            arr[i] = num; // заполнение массива
        }
        else Console.WriteLine("Ошибка ввода");
    }
    PrintArr(arr, count); //передача массива и его размера в функцию вывода на экран значений
}

void PrintArr(int[] arr, int count) //функция вывода массива на экран
{
    Console.Write($"["); // выводим "["
    for (int i = 1; i < count; i++)
    {
        Console.Write($"{arr[i]}, "); // выводим все элементы + "," (кроме крайнего элемента)
    }
    Console.Write($"{arr[count]}]"); // выводим крайний элемент и "]"
}

int count = 8; // задаем кол-во элементов в массиве
InputNumber(count); // передаем количество элементов в функцию введению значений в массив


