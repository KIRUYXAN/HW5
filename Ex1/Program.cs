//Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов,
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.
using System.Text.RegularExpressions;

Console.WriteLine("NReg или Reg");
string a = "Reg"; //Console.ReadLine();
if (a == "NReg" || a == "nreg")
    if (NReg()) Console.WriteLine("\nЛогин корректен");

if (a == "Reg" || a == "reg")
    if (Reg()) Console.WriteLine("\nЛогин корректен");



    bool NReg()
{
    string log = "";
    int f;
    int l;
    do
    {
        Console.WriteLine("Введите логин");
        log = Console.ReadLine();
        f = Convert.ToInt32(log[0]);
        l = log.Length;
        //if () Console.WriteLine("Логин может содержать только буквы латинского алфавита или цифры\n");

       //if () Console.WriteLine("Превый символ не может быть цыфрой\n");

        if (l < 2 || 10 < l) Console.WriteLine("В логине должно быть от 2 до 10 символов\n");

    } while ((l < 2 || 10 < l));
    return true;
}
bool Reg()
{
    Regex EngNum;
    Regex FNum;
    Regex MinMax;
    string log;
    string f;
    do
    {
        Console.WriteLine("Введите логин");
        log = Console.ReadLine();
        f = Convert.ToString(log[0]);
        EngNum = new Regex(@"[^A-Za-z0-9]");
        FNum = new Regex(@"[0-9]");
        MinMax = new Regex("[A-Za-z0-9]{2,10}");
        if (EngNum.IsMatch(log)) Console.WriteLine("Логин может содержать только буквы латинского алфавита или цифры\n");
        else if (FNum.IsMatch(f)) Console.WriteLine("Превый символ не может быть цыфрой\n");
        else if (!MinMax.IsMatch(log)) Console.WriteLine("В логине должно быть от 2 до 10 символов\n");

    } while (EngNum.IsMatch(log) || FNum.IsMatch(f) || !MinMax.IsMatch(log));
    return true;
}

