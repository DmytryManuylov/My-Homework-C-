/*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.*/
// Дмитрий Мануйлов

Console.Write("Введите имя: ");
string name = Console.ReadLine();

Console.Write("Введите фамилию: ");
string surename = Console.ReadLine();

Console.Write("Введите возраст: " );
int age = Convert.ToInt32((Console.ReadLine()));

Console.Write("Введите рост в см: ");
int height = Convert.ToInt32((Console.ReadLine()));
double heightM = Convert. ToDouble(height/100); ///вот тут не получается

Console.Write("Введите вес в кг: ");
double weight = Convert.ToInt16((Console.ReadLine()));

Console.Write(name + " " + surename + " " + "Вам " + age + " лет" + "; " + "Ваш рост: " + heightM + " метра и " + "вес " + weight + "кг" );
Console.Write($"{1}{2}Вам{3}лет; Ваш рост: {4}метра и вес{5}",name,surename,age,heightM,weight);//и тут
Console.WriteLine($"{name}{surname} Вам {age} лет; Рост:{heightM} Вес: {weight}"); //и тут
