

void PrintDoubleMatr(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
            {
                Console.Write($"{matr[m, n]}\t");
            }
    Console.WriteLine();
    }
}
//Показать двумерный массив размером m×n заполненный вещественными числами
void FillDoubleMatr(double[,] matr)
{
    Random random = new Random();
for (int m = 0; m < matr.GetLength(0); m++)
    {
    for (int n = 0; n < matr.GetLength(1); n++)
        matr[m,n] = random.NextDouble() * 100;//[1; 10)
    }
}

void PrintMatrix(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
            {
                Console.Write($"{matr[m, n]}\t ");
            }
    Console.WriteLine();
    }
}
//Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillMatrix_M_N(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int n = 0; n < matr.GetLength(1); n++)
        matr[i,n] = i+n; //Aₘₙ = m+n
    }
}
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void EvenX2Array(int[,] matr)
{
for (int m = 0; m < matr.GetLength(0); m++)
    {
    for (int n = 0; n < matr.GetLength(1); n++)
        if (m%2==0 && n%2==0)
            matr[m,n] *= matr[m,n]; 
    }
}
//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
string Position(int[,] matrix, int value)
{
    string result = string.Empty;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(0); n++)
           {
            if (value == matrix[m, n]) 
                result = $"(Первое вхождение элемента в двумерном массиве на позиции => [{m}, {n}])";
                    if(result != string.Empty)
                        return result;
           } 
    }
    if (result == string.Empty) 
        result = "Такого элемента нет в двумерном массиве";
    return result;
}
//В матрице чисел найти сумму элементов главной диагонали
int SumDiagonal(int[,] matr)          // if(m==n)
{
int sum = 0;
    for(int m = 0; m < matr.GetLength(0); m++)
        sum = sum + matr[m,m]; 
    return sum;    
}
//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
string Pmatrix(int[,] matr)
{
    string result = string.Empty;
    float P = 0;
    for (int n = 0; n < matr.GetLength(1); n++)
        {
        for (int m = 0; m < matr.GetLength(0); m++)
            {
                P += matr[m,n];
            }
        P=P/matr.GetLength(0);  
        result += ($"Cреднее арифметическое столбца {n}  равен {P}  "); 
        P=0;
        }      
return result;
}
//Написать программу, которая обменивает элементы первой строки и последней строки
void Change(int[,] matrix)
{
    int temp = 0;
    int m = 0;
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
            {
                temp = matrix[m,n];
                matrix [m,n] = matrix[matrix.GetLength(0)-1, n];
                matrix [matrix.GetLength(0)-1, n] = temp;
            }

    }
}
//В прямоугольной матрице найти строку с наименьшей суммой элементов.
int MinSumI(int[,] matr,int m)
{
    int summin = 0;
    for (int n = 0; n < matr.GetLength(1); n++)
        summin += matr[m,n];
    return summin;   
}
//
int MinSumJ(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < matr.GetLength(0); m++)
    {
    if (m == 0) 
            {
                sum += MinSumI(matr,m);
                minSum += MinSumI(matr,m); 
            }
            else sum += MinSumI(matr,m);
    if (sum < minSum)
    {
        minSum = sum;
        minNum = m;
    }
        sum = 0;
    }
    return minNum;
}
void Fillmatrix(int[,] matr, int n, int m)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = random.Next(m, n);//[1; 10)
    }
}

//Показать двумерный массив размером m×n заполненный вещественными числами
Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrixdouble = new double[m, n];
FillDoubleMatr(matrixdouble);
Console.WriteLine();
PrintDoubleMatr(matrixdouble);

Console.ReadKey();
Console.Clear();

//Задать двумерный массив следующим правилом: Aₘₙ = m+n
int[,] matrix = new int[m,n];
FillMatrix_M_N(matrix);
Console.WriteLine();
PrintMatrix(matrix);

Console.ReadKey();
Console.Clear();

// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
PrintMatrix(matrix);
Console.WriteLine();
EvenX2Array(matrix);
Console.WriteLine();
PrintMatrix(matrix);

Console.ReadKey();
Console.Clear();

//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите значение value: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Position(matrix,value);
Console.Write(Position(matrix,value));

Console.ReadKey();
Console.Clear();

//В матрице чисел найти сумму элементов главной диагонали
PrintMatrix(matrix);
Console.WriteLine();
if (m==n)Console.WriteLine($"Сумма элементов главной диагонали равна {SumDiagonal(matrix)}");
else Console.WriteLine($" Рассчет суммы элементов главной диагонали невозможен");

Console.ReadKey();
Console.Clear();

//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
PrintMatrix(matrix);
Console.WriteLine();
Console.Write($"{Pmatrix(matrix)}\t");

Console.ReadKey();
Console.Clear();

//Написать программу, которая обменивает элементы первой строки и последней строки

PrintMatrix(matrix);
Console.WriteLine();
Change(matrix);
Console.WriteLine();
PrintMatrix(matrix);

Console.ReadKey();
Console.Clear();
int[,] matrix1 = new int[4, 6];

Fillmatrix(matrix1, n, m);
Console.WriteLine();
PrintMatrix(matrix1);

    
Console.WriteLine($" Индекс строки {MinSumJ(matrix1)}");
