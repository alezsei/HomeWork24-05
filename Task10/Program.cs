int inNum(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    
}

void Task10()
{
    int num1 = inNum("Введите число");
    if (num1 > 99 && num1 < 1000)
    {
        Console.WriteLine($"Вторая цифра трехзначного числа {num1} равна { num1/10%10}");
    }
    else
    {
        Console.WriteLine("Введено неверное число");
    }
}
Task10();