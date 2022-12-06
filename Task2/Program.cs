
//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(num1Line!=null&&num2Line!=null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    if(num2 * num2 == num1)
    {
        Console.WriteLine("Первое число квардрат второго");
    }
    else
    {
        Console.WriteLine("Первое число не квардрат второго");
    }
}
