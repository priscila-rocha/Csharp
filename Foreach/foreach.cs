string[] names = { "Bob", "Conrad", "Grant" };
foreach (string teste in names)
{
    Console.WriteLine(teste);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory");