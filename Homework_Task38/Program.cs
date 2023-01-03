double[] arr = GenArray(10, -100, 100);
PrintArr(arr);
double min = Min(arr);
double max = Max(arr);

Console.WriteLine($"min = {min}, max = {max}, max - min = {max - min}");

double[] GenArray(int len, int minValue, int maxValue) //Генерация массива
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        var val = new Random().Next(minValue, maxValue + 1);
        arr[i] = Convert.ToDouble(val);
    }
    return arr;
}

void PrintArr(double[] arr) //Оформление массива
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

double Min(double[] arr) //Вычисление
{
    double min = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<min) min = arr[i];
    }
    return min;
}

double Max(double[] arr) //Вычисление
{
    double max = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}


// double MinMax(double[] arr) //Вычисление
// {
//     double min = 0;
//     double max = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i]>max) max = arr[i];
//         if(arr[i]<min) min = arr[i];
//     }

//     Console.WriteLine();
//     Console.WriteLine(min);
//     Console.WriteLine(max);
//     Console.WriteLine();


//     return max - min;
// }
