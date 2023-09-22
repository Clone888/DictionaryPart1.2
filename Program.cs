string[] list = File.ReadAllLines("../../../Husdjur.csv");

Dictionary<string, int> animal = new Dictionary<string, int>();

string name = string.Empty;
int age = 0;

List<int> petAge = new List<int>();

foreach (string petName in list)
{
    string[] split = petName.Split(",");

    if (int.TryParse(split[1], out age))
    {
        animal.Add(split[0].ToLower(), age);
        name += split[0] + " ";
        petAge.Add(age);
    }
    else
    {
        Console.WriteLine("Something went wrong");
    }
}
Console.WriteLine(petAge[1]);




/*

Console.WriteLine();
Console.WriteLine("Choose a name: ");



bool isRunning = true;

string? input = Console.ReadLine().ToLower();

while (isRunning)
{
    if (animal.ContainsKey(input))
    {
        Console.WriteLine("Birthyear of " + input + " is " + (2023 - animal[input]));
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Name dosent exist, try again");
        isRunning = true;
        input = Console.ReadLine().ToLower();

    }
}




//Console.WriteLine(split[0]);

*/
