
int ReadData(string line) 
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine()??"0");
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

void Print2DArrayColor(int[,] array)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(array[i, j] + "   ".Substring(array[i, j].ToString().Length));
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

double[] AvgColumn(int[,] array)
{   
    double[] avr = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
        {    
            avr[i] = 0.0;
            for(int j = 0; j < array.GetLength(0); j++)
            {
            avr[i] += array[j,i];
            }
            avr[i] = avr[i] / array.GetLength(0);
        }
    return avr;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]+"]");
}

int inputRow = ReadData("Введите кол-во строк: ");
int inputColumn = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Fill2DArray(inputRow, inputColumn, 1, 10);
Print2DArrayColor(arr2D);
double[] avrAr = AvgColumn(arr2D);
PrintArray(avrAr);

