/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    // Aqui quebra o bloco, depois que i chega a 7.
    if (i == 7) break;
}

Console.WriteLine();

// Exemplo 2

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
 */

// Exemplo 3

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David") names[i] = "Sammy";
}


foreach (var name in names)
{
    Console.WriteLine(name);
}