int InText(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task15()
{
    int numday = InText("Введите день недели");
    if (numday > 0 && numday < 8)
    {
        if (numday == 6 || numday == 7)
        {
            Console.WriteLine("Выходной");
        }
        else Console.WriteLine("Не выходной");
    }
    else Console.WriteLine("Нет такого дня недели");

}
Task15();