int[] arr = GenArray(10, -100, 100);
PrintArr(arr);
int result = SumOdd(arr);
PrintData("Cумма элементов, стоящих на нечётных позициях: ", result);

int[] GenArray(int len, int minValue, int maxValue) //Генерация массива
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintData(string res, int value) //Вывод результата
{
    Console.WriteLine(res+value);
}

void PrintArr(int[] arr) //Оформление массива
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int SumOdd(int[] arr) //Вычисление суммы нечетных элементов
{
    int result = 0;
    int i = 1;
    while(i < arr.Length)
    {
        result+=arr[i];
        i = i+2;
    }
    return result;

}
