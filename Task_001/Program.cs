/*Головоломка с n ферзями — это задача разместить n ферзей на шахматной доске размером n x n так,
чтобы никакие два ферзя не атаковали друг друга. По заданному целому числу n найти все различные
решения головоломки с n ферзями. Вы можете вернуть ответ в любом порядке. Каждое решение содержит
отдельную конфигурацию доски для размещения n ферзей, где «Q» и '.' оба обозначают ферзя и пустое
место соответственно.*/

string[,] chess = ArrayCreation("Введите размер шахматной доски N: ");
FillArray(chess);
PrintArray(chess);

string[,] ArrayCreation(string text)
{
    Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    string[,] array = new string[n, n];
    return array;
}

void FillArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i < array.GetLength(0) / 2)
        {
            array[i, 2 * i + 1] = "Q";
        }
        else
        {
            array[i, 2 * i + 1 - array.GetLength(0)] = "Q";
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != "Q")
            {
                array[i, j] = "_";
            }
        }
    }
}

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}