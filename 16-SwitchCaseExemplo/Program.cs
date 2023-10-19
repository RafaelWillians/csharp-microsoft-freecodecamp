
string fruit = "CHERRY";

// Switch, normalizando a string, para sempre corresponder a caixa baixa dos cases abaixo.
switch (fruit.ToLower())
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}