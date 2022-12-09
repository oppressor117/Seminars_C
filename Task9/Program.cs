
//Создаем экземляр класса рандомайзера
System.Random numberSintezator = new System.Random();
//Вариант 1
//Получаем новое случайное число
int number = numberSintezator.Next(10,100);

//Выводим данные в консоль
//Console.WriteLine(number);

//Получаем первое и второе число по-отдельности
int firstNumber = number/10; // 72 72/10=7,2 так как int двойка убирается
int secondNumber = number%10; // 72 72%10=2

//Сравниваем числа
if(firstNumber > secondNumber)
{
//    Console.WriteLine(firstNumber);
}
else
{
//    Console.WriteLine(secondNumber);
}

//Вариант 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNumber = ((int)digits[0]-48); 
secondNumber = ((int)digits[1]-48);

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);

//Варинат 3 много буковок, с массивом
//У