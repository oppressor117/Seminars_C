int[] arr = GenArray(10, 99, 1000);
PrintArr(arr);
int result = CountEven(arr);
PrintData("Количество чётных чисел в массиве: ", result);

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

int CountEven(int[] arr) //Вычисление четных чисел
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        {
            result++;
        }
    }
    return result;
}