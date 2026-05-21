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
