// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


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
Console.WriteLine("-> Определим, все четные числа от 1 до *N* <-");

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int even = 2;

while(num > 1)
{
    if(even <= num)
    {
        Console.WriteLine(even);
        even = even + 2;
    }
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
