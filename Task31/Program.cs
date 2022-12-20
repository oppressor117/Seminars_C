{
    int positiveSum = 0;
    int negativeSum = 0;

    int[] testArr = GenArray(12, -9, 9);
    NegativePositiveSum(testArr);
    Print1DArr(testArr);
    PrintData("Сумма положительных чисел в массиве:", positiveSum);
    PrintData("Сумма отрицательных чисел в массиве:", negativeSum);


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

    void PrintData(string res, int value)
    {
        Console.WriteLine(res + value);
    }

    void NegativePositiveSum(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                positiveSum += arr[i];
            }
            else
            {
                negativeSum += arr[i];
            }
        }
    }
    void Print1DArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }
}
