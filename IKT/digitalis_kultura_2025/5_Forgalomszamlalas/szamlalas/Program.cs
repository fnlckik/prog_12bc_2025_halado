//Console.WriteLine("alma");

// F1
string path = "../../../../meres.txt";
using StreamReader sr = new(path);
List<int> measurements = [.. sr.ReadLine()!.Split(", ").Select(e => int.Parse(e))]; // ToList()
//List<int> T = [1, 2, 3, 4, 5, 6];
//Console.WriteLine(String.Join(";", T[2..5])); // 2. indextől 4. indexig: 3;4;5

// F2
int amount = measurements.Where(e => e > 0).Sum();
Console.WriteLine("2. feladat");
Console.WriteLine($"Összesen {amount} kerékpárost számoltak.");

// F3
Console.WriteLine("\n3. feladat");
Console.WriteLine("Óránkénti mérések:");
int s = 0;
for (int i = 0; i < measurements.Count; i++)
{
	if (measurements[i] != -1) s += measurements[i];
	if (i % 4 == 3)
	{
        Console.WriteLine($"{6 + i / 4} órától {s} kerékpáros");
		s = 0;
	}
}

// F4
Console.WriteLine("\n4. feladat");
int maxValue = measurements.Max();
int index = measurements.IndexOf(maxValue);
int time = 6 * 60; // percben a kezdési idő
time += (index + 1) * 15;
int hour = time / 60;
int min = time % 60;
Console.WriteLine($"Az áthaladók maximális száma: {maxValue}; a rögzítés időpontja: {hour}:{min}.");