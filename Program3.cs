int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool isWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Ошибка это не день недели!");
    return false;
}
int weekDay = Prompt("Введите день(цифру) недели:");
if (ValidateWeekday(weekDay))
{
    if (isWeekend(weekDay))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}