// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Здравствуйте, меня зовут Scrappy");
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
Console.WriteLine("-> Найдём максимальное из трёх введёных чисел <-");

Console.WriteLine($"{name}, введите пожалуйста первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{name}, введите пожалуйста второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{name}, введите пожалуйста третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"Максимальное число найдено и равно: {max}");

Console.WriteLine("*Scrappy* завершает свою работу...");

if(name == "Ринат")
{
    Console.WriteLine("Ринат, я буду очень сильно скучать по тебе...");
}
else
{
    Console.WriteLine($"Рад был помочь Вам, {name} ! ^_^");
}

