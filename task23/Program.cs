System.Console.WriteLine("Введите, пожалуйста, число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    System.Console.Write(Math.Pow(i, 3) + ", ");
}
System.Console.Write(Math.Pow(N, 3));