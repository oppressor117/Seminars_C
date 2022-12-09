int inputNumber = int.Parse(Console.ReadLine()??"0");

int firstResultNumber = inputNumber%7;
int secondResultNumber = inputNumber%23;

if((firstResultNumber == 0)&&(secondResultNumber==0))
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("некратно");
}