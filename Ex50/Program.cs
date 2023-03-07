// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

int EnterValueFromUser(string message)
{
    Console.WriteLine(message);

    int value = Convert.ToInt32(Console.ReadLine());

    return value;
}

void FillMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next();
        }
    }
}

bool MatrixArea(int[,] matrix, int m, int n)
{
    if(m <= matrix.GetLength(0) &&
        n <= matrix.GetLength(1)) 
        return true;
        else 
        return false;
}

int[,] matrix = new int[EnterValueFromUser("Please enter number of rows: "),
                        EnterValueFromUser("Please enter number of columns: ")];
FillMatrix(matrix);

int m = EnterValueFromUser("Row number > ");
int n = EnterValueFromUser("Column number > ");

if (MatrixArea(matrix, m, n))
{
    Console.WriteLine($"Here's the element you need > {matrix[m,n]}");
}
else Console.WriteLine("Sorry, no such element here");
