using TemperatureExample;

Console.WriteLine("Absolute zero in F is: " + Temperature.absoluteZeroFahrenheit);

Temperature temp = new();
//will not access static field
Console.WriteLine(temp.absoluteZeroFehrenheit);