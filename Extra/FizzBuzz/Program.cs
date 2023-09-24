using System;
using System.IO;
using System.Collections.Generic;

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



