//Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов,
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.
using System.Text.RegularExpressions;

Regex Rus;
Regex Num;
Regex MinMax;
string log;
do
{
    Console.WriteLine("Введите логин");
    log = Console.ReadLine();
    Rus = new Regex(@"[^A-Za-z0-9]");
    Num = new Regex(@"[0-9] + [A-Za-z0-9]");
    MinMax = new Regex(@"[A-Za-z0-9]{2, 10}");
    Console.WriteLine(Num.IsMatch(log));
    Console.WriteLine(MinMax.IsMatch(log));
    if (Rus.IsMatch(log)) Console.WriteLine("Логин может содержать только буквы латинского алфавита или цифры\n");
    else if (Num.IsMatch(log)) Console.WriteLine("Превый символ не может быть цыфрой");
    else if (!MinMax.IsMatch(log)) Console.WriteLine("В логине должно быть от 2 до 10 символов");

} while (Rus.IsMatch(log) || Num.IsMatch(log) || !MinMax.IsMatch(log));

Console.WriteLine("ДА");
