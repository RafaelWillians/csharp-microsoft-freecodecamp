
Random randomNumber = new Random();
int coinFlip = randomNumber.Next(1,100);

Console.WriteLine($"{(coinFlip % 2 == 0 ? "Heads" : "Tails")}");

// Apenas para mostrar o valor da variável coinFlip.
// Console.WriteLine(coinFlip);