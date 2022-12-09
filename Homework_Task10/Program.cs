int inputNumber = int.Parse(Console.ReadLine()??"0");

if((inputNumber<1000)&&(inputNumber>99))
{
    int resultNumber = (inputNumber/10)%10;

    Console.WriteLine(resultNumber);

}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
