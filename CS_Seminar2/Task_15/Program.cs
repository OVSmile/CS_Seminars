int number;

while (true) // Блок ввода и проверки на правильность ввода
{
    Console.Write("Helo! Please enter number of the day of the week: ");
    if(int.TryParse(Console.ReadLine(), out number)) 
    {
        break;
    }
    else
        Console.WriteLine("There is no such day of the week");    

}

if (number > 0 &&  number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number} -> Yes, this day is a day off");  
    } 
    else
        Console.WriteLine($"{number} -> No, this day is a weekday");
}