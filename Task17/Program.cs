//Вводим данные
//Console.WriteLine("Введите коорлинату X");
//int coordX = int.Parse(Console.ReadLine()??"0");

//Console.WriteLine("Введите коорлинату X");
//int coordY = int.Parse(Console.ReadLine()??"0");

//Метод читает данные от пользователя


int coordX = ReadData ("Введите координату X");
int coordY = ReadData ("Введите координату Y");
PrintQuterTest();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintQuterTest() //Метод определяет четверть по координатам
{
if(coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
if(coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
if(coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
if(coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}


