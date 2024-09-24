
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

