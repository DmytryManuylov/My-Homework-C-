/* Отобразите числа от -N до N*/
//Дмитрий Мануйлов

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш ряд чисел от -N до N: ");

if (n < 0)
{
    for( int i = n; i <= -n; i++)
    {
        Console.WriteLine(i);
    }    
}   
else if (n == 0)
{
    Console.WriteLine("Введите другое число ");
}

else
{
    for( int i = -n; i <= n; i++)
    {
        Console.WriteLine(i);
    }    
}