//Считываем данные с консоли
string? inputNumberLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(inputNumberLine!=null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputNumberLine);
    //Условие
    if(inputNumber % 2 == 0)
    {
        Console.WriteLine("Четное");
    }
    else
    {
        Console.WriteLine("Нечетное");
    }
}