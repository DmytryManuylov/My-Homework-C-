//Написать метод, возвращающий минимальное из трёх чисел.
//Дмитрий Мануйлов

Console.WriteLine("Эта программа выбирает минимальное число из трёх.");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int min = num1;

if (num2 < num1 && num2 < num3)
min = num2;
else
min = num3;
Console.WriteLine("Наименьшее число {0}", min);               