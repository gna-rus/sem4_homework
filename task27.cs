/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();

int InputNumber() //ввод значений и проверка
{
    while (true)
    {
        int num;
        Console.WriteLine($"Введите число");
        bool flag = int.TryParse(Console.ReadLine(), out num);
        if (flag == true) return num;
        Console.WriteLine("Ошибка ввода");
    }
}

int RezultGetNums(int nums) //подсчет суммы цифр в числе
{
    int rez = 0; // обьявление результируещего значения
    int digr;
    while (nums > 0) //цикл для дробления цифры на числа
    {
        digr = nums % 10;
        rez = rez + digr;
        nums = nums / 10;
    }
    return rez;
}

int nums = InputNumber(); //обращение к вводу

Console.WriteLine(RezultGetNums(nums)); //вывод результата
