System.Console.WriteLine("Напишите, пожалуйста, пятизначное число: ");
string[] array = { Console.ReadLine() };

int n = array.Length;
int i = 0;

if (n == 5)
{
    while (i<=n)
    {
        if (array[0]==array[4] || array[1]==array[3])
        {
            System.Console.WriteLine("Введенное число является палиндромом");
        }
        else
        {
            System.Console.WriteLine("Введенное число не является палиндромом");
        }
    i++;
    }
}
else
{
    System.Console.WriteLine("Введено не пятизначное число");
}