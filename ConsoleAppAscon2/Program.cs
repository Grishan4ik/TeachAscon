//Задание 1. Сначала сделал отдельно. Решил объединитьsв
Console.Write("Напишите Фамилию полностью пожалуйста");

string? surname = Console.ReadLine();
Console.Write("Напишите ваше имя пожалуйста");
string? name = Console.ReadLine();

Console.Write("Напишите ваше отчество");
string? Dsurname = Console.ReadLine();

Console.WriteLine($"Меня зовут {surname} {name} {Dsurname}");

//Задание 2

Console.Write("Введите первое значение");
string? FirstNumb = Console.ReadLine();
int FirstNumber = int.Parse(FirstNumb);
Console.Write("Введите второе значение");
string? SecondNumb = Console.ReadLine();
int SecondNumber = int.Parse(FirstNumb);

Console.Write("Укажите математическое действие");
string? MathSumbol = Console.ReadLine();

//string Math = "+ - * /";
//int MathNumber = int.Parse(Math);
switch (MathSumbol)
{
    case "+":
        Console.WriteLine($" {FirstNumber + SecondNumber}");
        break;
    case "-":
        Console.WriteLine($" {FirstNumber} - {SecondNumber}");
        break;
    case "*":
        Console.WriteLine($" {FirstNumber} * {SecondNumber}");
        break;
    case "/":
        Console.WriteLine($" {FirstNumber} / {SecondNumber}");
        break;
}

