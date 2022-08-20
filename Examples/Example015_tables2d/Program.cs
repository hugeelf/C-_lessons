// string[,] table = new string [2,5];// двумерный массив, с количестовм строк 2, столбцов 5
// // table [0,0] table [0,1] table[0,2]
// // table [1,0] table [1,1] table [1,2]
// table [1,2] = "слово";
// for (int rows = 0; rows<2; rows++)
// {
//     for (int columns = 0; columns <5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) //указываем количество строк через функционал нахождения длины массива (0)-обращаемся к количеству строк или к первому массиву
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)//указываем количество строк через функционал нахождения длины массива (1)-обращаемся к количеству столбцов или ко второму массиву
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows=0; rows<matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns<matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
