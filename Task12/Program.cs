int firstNumber = int.Parse(Console.ReadLine()??"0");

int secondNumber = int.Parse(Console.ReadLine()??"0");

int resultNumber = secondNumber % firstNumber;

if(resultNumber == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("некратно, " + resultNumber);
}