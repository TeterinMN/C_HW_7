Console.Clear();
int m = 3;
int n = 4;
double[,] array = new double[m, n];

Random rand = new Random();
// Заполнение массива случайными числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = (rand.NextDouble() * 20) - 10;
    }
}

// Вывод массива на экран
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0:0.0} ", array[i, j]);
    }
    Console.WriteLine();
}