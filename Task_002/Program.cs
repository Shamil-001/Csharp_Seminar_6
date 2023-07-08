//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

void PrintX(double x)
{
    System.Console.WriteLine("Точка пересечения: " + x + "; " + -x);
}

double k1 = ReadInt("k1 = ");
double b1 = ReadInt("b1 = ");
double k2 = ReadInt("k2 = ");
double b2 = ReadInt("b2 = ");
double x = FindX(k1, b1, k2, b2);
PrintX(x);