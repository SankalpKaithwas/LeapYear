

Console.WriteLine("Enter a year:");

int year = int.Parse(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine(year + "is a leap Year ");
}
else
{
    Console.WriteLine("{0} is not a leap Year ", year);
}


