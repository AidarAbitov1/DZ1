//Напишите программу, которая на вход принимает Положительное (исходя из логики) число (N), 
//а на выходе показывает все чётные числа от 1 до N

Console.Clear();
int n = 0;
while(n <= 0)
{
    Console.Write("Введите положительное число N: ");
    n = int.Parse(Console.ReadLine());
}
Console.Write("Четные числа от 1 до N: " );
for(int i = 1; i <= n; i++)
{
    if(i%2==0)
    {
        Console.Write(i + ", ");
    }
}