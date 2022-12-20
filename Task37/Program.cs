int[] arr = GenArray(123, -100, 100);
PrintArr(arr);
Console.WriteLine();
int[] result = ConvertArray(arr);
PrintArr(result);
Console.WriteLine();

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

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int[] ConvertArray(int[] arr)
{
    int[] outArr = new int[arr.Length/2];
    for(int i = 0; i < arr.Length/2; i++)
    {
        outArr[i] = arr[i]*arr[arr.Length - 1 - i];
    }
    return outArr;
}