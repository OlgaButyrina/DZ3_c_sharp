int InputNumber(string a)
{
System.Console.Write(a);
return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату x первой точки: ");
int y1 = InputNumber("Введите координату y первой точки: ");
int z1 = InputNumber("Введите координату z первой точки: ");
int x2 = InputNumber("Введите координату x второй точки: ");
int y2 = InputNumber("Введите координату y второй точки: ");
int z2 = InputNumber("Введите координату z второй точки: ");

double result = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2)), 2);

System.Console.WriteLine($"Расстояние между точками = {result}");
