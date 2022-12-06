//Считываем данные с консоли
string? inputNumberLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(inputNumberLine!=null)

{
    //Парсим введенное число
    int inputNumber = int.Parse(inputNumberLine);
    int evenNumber = 2;
    string res = string.Empty;

    while (evenNumber <= inputNumber)
    {
        res = res + evenNumber + ", ";
        evenNumber = evenNumber + 2;
    }

Console.WriteLine(res);

}
