int inputNumber1 = int.Parse(Console.ReadLine()??"0");
int inputNumber2 = int.Parse(Console.ReadLine()??"0");

//bool firstResultNumber = (firstNumber/secondNumber==secondNumber);
//bool secondResultNumber = (secondNumber/firstNumber==firstNumber);

//if(firstResultNumber) Console.WriteLine(firstNumber, "квадрат", secondNumber);
//if(secondResultNumber) Console.WriteLine(secondNumber, "квадрат", firstNumber);
//if(!firstResultNumber&&!secondResultNumber) Console.WriteLine("нет квадрата");

void TestSQRT(int inputNumber1, int inputNumber2)
{
    bool result = (inputNumber1/inputNumber2==inputNumber2);

    if(result==true) Console.WriteLine("Число "+inputNumber1+" является квадратом числа "+inputNumber2);
    else Console.WriteLine("Число "+inputNumber1+" не является квадратом числа "+inputNumber2);
}
TestSQRT(inputNumber1, inputNumber2);
TestSQRT(inputNumber2, inputNumber1);
