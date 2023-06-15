Console.WriteLine("Введите любое число => ");
string inputedString = Console.ReadLine();
int number = Convert.ToInt32(inputedString);

if (number %2 == 0)
{
    Console.WriteLine($"Число'{number}' четное");
}
else
{
    Console.WriteLine($"Число '{number}' нечётное");
}