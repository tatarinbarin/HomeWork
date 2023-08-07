// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Здравствуйте, меня зовут Scrappy");
Console.WriteLine("Вычислительная машина XXI в.");
Console.WriteLine("Я, Ваш *незаменимый помощник*!!!");
Console.WriteLine("Давайте познакомимся c Вами ^_^");
Console.WriteLine("Пожалуйста представьтесь, как Вас зовут???");
string name = Console.ReadLine();
if(name == "Ринат")
{
    Console.WriteLine("О, это же наш любимый Ринат !!! ");
}
else
{
    Console.WriteLine($"Сердечно привествую Вас, {name} ! ");
}

Console.WriteLine("Давайте проведём одну небольшую операцию...");
Console.WriteLine("-> Определим, является ли число чётным (без остатка), либо нет <-");

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int even = num % 2;

if(even == 0)
{
    Console.WriteLine("Данное число, является четным, т.к. не имеет остатка");
}
else
{
    Console.WriteLine("Данное число, является нечетным, т.к. имеет остаток ");
    Console.WriteLine($"Остаток введенного числа равен: {even}");
}

Console.WriteLine("*Scrappy* завершает свою работу...");

if(name == "Ринат")
{
    Console.WriteLine("Ринат, я буду очень сильно скучать по тебе...");
}
else
{
    Console.WriteLine($"Рад был помочь Вам, {name} ! ^_^");
}



