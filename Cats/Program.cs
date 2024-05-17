using Cats;

//TODO: Try out your skills with inheritance here!
Console.WriteLine("Hello, Cats!");

HouseCat garfield = new("Garfield", 12.0);
garfield.Eat();
Console.WriteLine(garfield.Tired);

HouseCat spike = new HouseCat("Spike");
Console.WriteLine(spike.Weight);
Console.WriteLine(spike.Noise());