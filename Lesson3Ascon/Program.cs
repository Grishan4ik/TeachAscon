// See https://aka.ms/new-console-template for more information







int[] Numb_vl = new int[4];
try
{
    // Запрашиваем у пользователя числа и сохраняем их в массив
    Console.Write("Введите число: ");
    Numb_vl[0] = int.Parse(Console.ReadLine());

    Console.Write("Введите число: ");
    Numb_vl[1] = int.Parse(Console.ReadLine());

    Console.Write("Введите число: ");
    Numb_vl[2] = int.Parse(Console.ReadLine());

    Console.Write("Введите число: ");
    Numb_vl[Numb_vl.Length - 1] = int.Parse(Console.ReadLine());


}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    // обработка исключения
}
catch (Exception ex)
{
    Console.WriteLine($"Что то пошло не так: {ex.Message}");
}


// Вычисляем сумму чисел и среднее значение
int sum = Numb_vl[0] + Numb_vl[1] + Numb_vl[2] + Numb_vl[Numb_vl.Length - 1];
int average = (int)sum / Numb_vl.Length;

    // Выводим результат
    Console.WriteLine($"Среднее значение: {average}");


//второе задание
string[] UserName = new string[3];
int[] Age = new int[3];
try
{
    Console.Write("Введите имя первого пользователя");
    UserName[0] = Console.ReadLine();
    Console.Write("Введите имя второго пользователя");
    UserName[1] = Console.ReadLine();
    Console.Write("Введите имя третьего пользователя");
    UserName[2] = Console.ReadLine();


    Console.Write("Введите возраст первого пользователя");
    Age[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите возраст второго пользователя");
    Age[1] = int.Parse(Console.ReadLine());
    Console.Write("Введите возраст третьего пользователя");
    Age[2] = int.Parse(Console.ReadLine());
    foreach (var name in UserName)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Введите имя пожалуйста");
        }


    }
}




catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    // обработка исключения
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.Write("Какого пользователя хотите вывести?");
int index = int.Parse(Console.ReadLine());
if (index < 0 && index < 3)
{

    Console.WriteLine($" Ваш пользователь {UserName[index]} Возраст {Age[index]} ");
}
else
{
    Console.WriteLine("Данного пользователя не существует");
}
