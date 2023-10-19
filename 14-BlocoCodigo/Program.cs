bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

/* Dará erro de compilação a linha abaixo. Value está apenas dentro do escopo do if acima.
Console.WriteLine($"Outside of code block: {value}"); */