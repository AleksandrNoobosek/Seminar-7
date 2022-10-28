
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
int MinSumN(int[,] matr,int t)
{
    int summin = 0;
    for (int x = 0; x < matr.GetLength(1); x++)
        summin += matr[t,x];
    return summin;   
}
//В прямоугольной матрице найти строку с наименьшей суммой элементов.
int MinSumJ(int[,] matr,int min)
{
    int sum = 0;
    int result = 0;
    for (int t = 1; t < matr.GetLength(0); t++)
    {
        sum = MinSumN(matr,t);
    if (min > sum) 
        {
            min=sum;
            result = t;
        }
    }   
    return result;
}
// заполнение под 
void Fillmatrix(int[,] matr)
{
    Random random = new Random();
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
            matr[m, n] = random.Next(1,10);//[1; 10)
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

// В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Write("Введите размер массива m: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите размер массива n: ");
int j = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix1 = new int[i, j];
Fillmatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix1);

int t = 0;
int min = MinSumN(matrix1,t);

if (i!=j)Console.WriteLine($" Cтрока с наименьшей суммой элементов {MinSumJ(matrix1,min)}");
else Console.WriteLine($" Поиск Cтроки с наименьшей суммой элементов невозможен");

Console.ReadKey();
Console.Clear();
