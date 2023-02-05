System.Console.WriteLine("Введите, пожалуйста, пятизначное число: ");
string X = Console.ReadLine();

int n = X.Length;

if (n == 5)
{
    if (X[0] == X[4] || X[1] == X[3])
    {
        System.Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Введенное число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введено не пятизначное число");
}