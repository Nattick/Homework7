public class Shares1
{
    public static int Input(string message)
    {
        Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static double[,] Matrix(int a, int b)
    {
        double[,] matrix = new double[a, b];
        return matrix;
    }

    public static int[,] MatrixInt(int a, int b)
    {
        int[,] matrix = new int[a, b];
        return matrix;
    }

    public static void FillMatrixRandomInt(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = new Random().Next(1,10);
                Console.Write(matrix[i, j]+" ");
            }
            Console.WriteLine();
        }
    }

        public static void Sred(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        double summ = 0;
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < row; j++)
            {
                summ = summ + matrix [j,i];
            }
            Console.Write(Math.Round(summ/columns, 2) + "; ");
            summ = 0;
        }
    }

    public static void FillMatrixRandom(Double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        Random rand = new Random();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = Math.Round(rand.Next(-100, 101) * 0.1, 1);
                Console.Write("{0,6:F1}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    }

