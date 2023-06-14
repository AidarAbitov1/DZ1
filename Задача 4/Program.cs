// Программа для ввода трех чисел и вывода максимального из них

Console.Clear() ;
Console.WriteLine ("Введите первое число") ;
int num1 = int.Parse (Console.ReadLine ()) ;
Console.WriteLine ("Введите второе число") ;
int num2 = int.Parse (Console.ReadLine ()) ;
Console.WriteLine ("Введите третье число") ;
int num3 = int.Parse (Console.ReadLine ()) ; 
int max = num1 ;
if (num1 < num2) 
    {
    max = num2 ;
    }
if (num2 < num3) 
    {
    max = num3 ;
    }
Console.WriteLine (max) ;
