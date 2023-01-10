int ReadData(string line) 
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine()??"0");
}

double[,] Fill2DArray(int countRow, int countColumn) //Универсальный метод генерации и заполнения двумерного массива
{
        double [,] array = new double[countRow, countColumn];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++) 
        {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                }
        }
        return array; 
}

void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите кол-во строк: ");
int column = ReadData("Введите кол-во столбцов: ");
double[,] array = Fill2DArray(row, column);
Print2DArrayColor(array);
