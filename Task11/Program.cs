//Создаем экземляр класса рандомайзера
System.Random numberSintezator = new System.Random();

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

//int firstNumber = number/100;
//int thirdNumber = number%10;

//int resultNumber = firstNumber*10+thirdNumber; 
int resultNumber = (number/100)*10 + number%10;

Console.WriteLine(resultNumber);
