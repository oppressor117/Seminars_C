int[] arr = GenArr(8, -100, 100);
PrintData("Сгенерированный массив из 8 элементов: ", arr);

void PrintData(string res, int[] arr) //Метод вывода результата
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int len, int minValue, int maxValue) //Метод генерации массива
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArr(int[] arr) //Метод вывода данных (оформление)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}