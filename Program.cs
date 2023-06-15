Console.WriteLine("Введите число номер 1 => ");
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);

Console.WriteLine("Введите число номер 2 => ");
string inputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString2);

if (number1 > number2)
{
    Console.WriteLine($"{number1} наибольшее число");
    Console.WriteLine($"{number2} меньшее число");
}