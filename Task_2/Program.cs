/*
    Створiть та опишiть клас «Матриця». 

    Виконайте перевантаження 

    (для додавання матриць), 

    (для віднімання матриць).

    (множення матриць одна на одну, множення матриці на число), 

    (перевірка матриць на рівність), 

    != і Equals. 

    Використовуйте механізм властивостей полів класу і механізм індексаторів. 
 */
using Task_2;

Matrix matrix1 = new Matrix(2, 2);
matrix1[0, 0] = 1;
matrix1[0, 1] = 2;
matrix1[1, 0] = 3;
matrix1[1, 1] = 4;

Matrix matrix2 = new Matrix(2, 2);
matrix2[0, 0] = 5;
matrix2[0, 1] = 6;
matrix2[1, 0] = 7;
matrix2[1, 1] = 8;

Matrix sum = matrix1 + matrix2;
Console.WriteLine("Sum:");
for (int i = 0; i < sum.Rows; i++)
{
    for (int j = 0; j < sum.Columns; j++)
    {
        Console.Write(sum[i, j] + " ");
    }
    Console.WriteLine();
}

Matrix difference = matrix1 - matrix2;
Console.WriteLine("Difference:");
for (int i = 0; i < difference.Rows; i++)
{
    for (int j = 0; j < difference.Columns; j++)
    {
        Console.Write(difference[i, j] + " ");
    }
    Console.WriteLine();
}

Matrix result_1 = matrix1 * 2;
Console.WriteLine("Matrix multiplied by 2:");
for (int i = 0; i < result_1.Rows; i++)
{
    for (int j = 0; j < result_1.Columns; j++)
    {
        Console.Write(result_1[i, j] + " ");
    }
    Console.WriteLine();
}

Matrix result_2 = matrix1 * matrix2;
Console.WriteLine("Matrix multiplied by a matrix:");
for (int i = 0; i < result_2.Rows; i++)
{
    for (int j = 0; j < result_2.Columns; j++)
    {
        Console.Write(result_2[i, j] + " ");
    }
    Console.WriteLine();
}

if (matrix1 == matrix2)
    Console.WriteLine("(==)Matrixes are equal");
else
    Console.WriteLine("(==)Matrixes aren't equal");

if (matrix1 != matrix2)
    Console.WriteLine("(!=)Matrixes aren't equal");
else
    Console.WriteLine("(!=)Matrixes are equal");


Matrix test = new Matrix(3, 4);

Console.WriteLine("Equals: " + matrix1.Equals(matrix2));
Console.WriteLine("Equals: " + matrix1.Equals(test));

