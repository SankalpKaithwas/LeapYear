

Console.WriteLine("Enter a year:");
int year = int.Parse(Console.ReadLine());

// Using DateTime Function
if (DateTime.IsLeapYear(year))
{
    Console.WriteLine(year + " is a a leap year");
}
else
{
    Console.WriteLine("{0} is not a leap year", year);
}


