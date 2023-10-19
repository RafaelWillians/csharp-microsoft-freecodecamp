/* 
// Exemplo 1
Random random = new Random();
int current = 0;

do
{
    // Sempre será executado esse bloco pelo menos uma vez.
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
 */


/* 
// Exemplo 2

Random random = new Random();
int current = random.Next(1, 11);


// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

 */


// Exemplo 3

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

