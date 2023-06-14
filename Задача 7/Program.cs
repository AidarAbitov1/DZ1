/* Программа, которая принимает на вход 
трехзначное число и выдает последнюю цифру этого числа */

Console.Clear() ;
Console.WriteLine("Введите трехзначное число") ;
int number = int.Parse(Console.ReadLine()) ;
Console.WriteLine(number%10) ;
