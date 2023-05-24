int IntNum(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void Task13()
{
    int num1 = IntNum("Введите число");
    int threenum = num1;
    if (threenum > 99)
    {
        while (threenum > 999)
        {
            threenum = threenum / 10;
        }
        Console.WriteLine($"Третья цифра числа {num1} равна {threenum % 10} "); 
    }
    else
    {
        Console.WriteLine("Третьей цифры числа нет");
    }
}
Task13();
