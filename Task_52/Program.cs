Console.Clear();
int[,] array = new int[,]
{
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
};

int lines = array.GetLength(0);
int columns = array.GetLength(1);
double[] averages = new double[columns];

for (int j = 0; j < columns; j++)
{
    int sum = 0;

    for (int i = 0; i < lines; i++)
    {
        sum += array[i, j];
    }

    averages[j] = (double)sum / lines;
}

Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < columns; j++)
{
    double average = Math.Round(averages[j], 1);
    Console.Write(average + "; ");
}

Console.WriteLine();