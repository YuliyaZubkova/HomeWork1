/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/ 

Console.WriteLine("Введите первое число: ");
string number1 = Console.ReadLine();
int numberOne = Convert.ToInt32(number1);

Console.WriteLine("Введите второе число: ");
string number2 = Console.ReadLine();
int numberTwo = Convert.ToInt32(number2);

if(numberOne > numberTwo)
{
    Console.WriteLine("Большее число - "+numberOne);
    Console.WriteLine("Меньшее число - "+numberTwo);
}

if(numberOne < numberTwo)
{
    Console.WriteLine("Большее число - "+numberTwo);
    Console.Write("Меньшее число - "+numberOne);
}
if(numberOne == numberTwo)
{
    Console.WriteLine("Числа равны");
}