/* 
    Este exemplo é um exercício para aprender a importância de otimizar código.
    Com base no artigo https://stackoverflow.com/questions/11764539/writing-fizzbuzz/39919587
    e no vídeo https://youtu.be/GfNBZ7awHGo

*/
using System;
using System.IO;
using System.Collections.Generic;

// NOVO Código otimizado.

for(int i =0; i<=100; i++)
{
    // A linha abaixo vai servir para checar se é divisível por 3 ou 5 e atribuir FizzBuzz, sem precisar de if's.
    string fizzBuzz = (i%3==0 && i%5==0) ? "FizzBuzz" : 
        (i%5==0) ? "Buzz" : 
            (i%3==0) ? "Fizz" : i.ToString();

    Console.WriteLine($"{fizzBuzz}");
}

 

/* 
    Código antigo, não otimizado pois não há necessidade de ter 2 loops.
    Basta usar apenas o for.

    // Crio map, para preencher tanto com os números, quanto com FizzBuzz.
    Dictionary<int, string> map = new Dictionary<int, string>();

// Apenas para input dos valores. Pode ser aprimorado para apenas usarmos o valor de i.
for(int i =0; i<=100; i++)
{
    string fizzBuzz;

    
    fizzBuzz = (i%3==0 && i%5==0) ? "FizzBuzz" : 
        (i%5==0) ? "Buzz" : 
            (i%3==0) ? "Fizz" : i.ToString();
    map.Add(i,fizzBuzz);
}

// Apenas para saída dos valores.
foreach(var paresMapa in map)
{
    Console.WriteLine($"{paresMapa}");    
}


 */
