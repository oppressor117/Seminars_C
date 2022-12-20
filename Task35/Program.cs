int[] arr = GenArray(123, -100, 100);
PrintArr(arr);

int result = CountElem(arr, 10, 99);
PrintData("Количество элементов массива, значения которых лежат в отрезке [10, 99] составляет ", result);


void PrintData(string res, int value)
{
    Console.WriteLine(res+value);
}

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int CountElem(int[] arr, int min, int max)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min&&arr[i] < max)
        {
            res++; //количество
        }
    }
    return res;

}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
