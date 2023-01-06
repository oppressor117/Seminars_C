int b1 = ReadData ("Введите b1: ");
int k1 = ReadData ("Введите k1: ");
int b2 = ReadData ("Введите b2: ");
int k2 = ReadData ("Введите k2: ");
CrossPoint(k1,b1,k2,b2);

int ReadData(string msg) //Ввод чисел пользователем
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void CrossPoint(double k1, double b1, double k2, double b2) //Вычисление точки пересечения двух прямых 
{   
    double x = (b1-b2)/(k2-k1); 
    double y = (k2*b1-k1*b2)/(k2-k1); 
    if(k1==k2) 
        {
        Console.Write("Заданные прямые не пересекаются!");
        }
    else 
        {
        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
        } 
 }