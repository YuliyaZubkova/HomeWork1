/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string number1 = Console.ReadLine();
int numberOne = Convert.ToInt32(number1);

Console.WriteLine("Введите второе число: ");
string number2 = Console.ReadLine();
int numberTwo = Convert.ToInt32(number2);

Console.WriteLine("Введите третье число: ");
string number3 = Console.ReadLine();
int numberThree = Convert.ToInt32(number3);

if(numberOne > numberTwo && numberOne > numberThree)
{
        Console.WriteLine("Максимальное число: "+numberOne);
}
   
if(numberTwo > numberOne && numberTwo > numberThree)
    {
        Console.WriteLine("Максимальное число: "+numberTwo);
    }
if(numberThree > numberOne && numberThree > numberTwo)
    {
        Console.WriteLine("Максимальное число: "+numberThree);
    } 
if(numberOne == numberTwo && numberTwo == numberThree)
{
 Console.WriteLine("Все числа равны");   
}