string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
    string[]dayWeek = new string [7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";

    int inputNumber = int.Parse(inputLine);

    string outDayWeek = dayWeek[inputNumber-1];

    Console.WriteLine(outDayWeek);
}
