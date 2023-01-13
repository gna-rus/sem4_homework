/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();
int InputNumber(ref int count) //ввод значений и проверка
{
    count++;
    while (true)
    {
        int num;
        Console.WriteLine($"Введите число №{count}");
        bool flag = int.TryParse(Console.ReadLine(), out num);
        if (flag == true) return num;
        Console.WriteLine("Ошибка ввода");
    }
}
int MathHw(int A, int B) // проведение расчетов
{
    int rez = Convert.ToInt32(Math.Pow(A, B));
    return rez;
}
int count = 0; //счетчик для именования переменных
int num1 = InputNumber(ref count);
int num2 = InputNumber(ref count);
int rez = MathHw(num1, num2);

Console.Write(rez); // вывод результата на экран




