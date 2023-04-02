Console.Clear();
int[,] array = new int[,]
{
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
};

Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер строки: ");
int lines = int.Parse(Console.ReadLine()!);

if (lines < 0 || lines >= array.GetLength(0) || columns < 0 || columns >= array.GetLength(1))
{
    Console.WriteLine("Такой позиции нет");
}
else
{
    Console.WriteLine("Элемент с заданной позицией: " + array[lines, columns]);
}