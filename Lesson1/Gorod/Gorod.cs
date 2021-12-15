//Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//Дмитрий Мануйлов


Console.WriteLine("Как Вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Ваша фамилия?");
string familia = Console.ReadLine();
Console.WriteLine("Ваш город проживания?");
string gorod = Console.ReadLine();
Console.WriteLine($"Вас зовут - {name} {familia};Ваш город проживания - {gorod}");
