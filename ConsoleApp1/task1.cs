double SmallPrice = 25;
double LargePrice = 35;
double TaxRate = 0.06;
string ValidationMessage = "This estimate valid for 30 days";
double SmallCount = double.Parse(Console.ReadLine());
double LargeCount = double.Parse(Console.ReadLine());

System.Console.WriteLine($"Number of Small Carpets: {SmallCount}");
System.Console.WriteLine($"Number of Large Carpets: {LargeCount}");
System.Console.WriteLine($"Price per Small Carpet: {SmallPrice:c}");
System.Console.WriteLine($"Price per Large Carpet: {LargePrice:c}");
double Cost = (SmallPrice * SmallCount) + (LargePrice * LargeCount);
System.Console.WriteLine($"cost: {Cost:c}");
double Tax = Cost * TaxRate;
System.Console.WriteLine($"Tax: {Tax:c}");
double Total = Cost + Tax;
Console.WriteLine("================================");
System.Console.WriteLine($"Total estimate: {Total:c}");
System.Console.WriteLine(ValidationMessage);
