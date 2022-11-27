// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
//
// int counter = 0;

// for (int i = 1; i <= 20; i++)
// {
//     if (i % 3 == 0)
//     {
//         counter += i;
//     }
// }
// Console.WriteLine(counter);
//
// var names = new List<string> { "<name>", "Ana", "Felipe"};
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
//     
// }
//
// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Ana");
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// Console.WriteLine($"My name is {names[0]}.");
// Console.WriteLine($"I've added {names[2]} and {names[3]} to the List.");
// Console.WriteLine($"The List has {names.Count} people in it");
//
// var index = names.IndexOf("Felipe");
// if (index != -1)
//     Console.WriteLine($"the name {names[index]} is at index {index}");
// var notFound = names.IndexOf("Not Found");
// Console.WriteLine($"when an item is not found, IndexOf returns {notFound}");
//
// names.Sort();
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

var fibonacciNumbers = new List<int> {1, 1};

var previous = fibonacciNumbers[fibonacciNumbers.Count-1];
var previois2 = fibonacciNumbers[fibonacciNumbers.Count-2];

fibonacciNumbers.Add(previous + previous+2);
foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}



