// Código otimizado já feito anteriormente no diretório Extra\FizzBuzz, com modificações para mostrar todos os números na saída.

for(int i =0; i<=100; i++)
{
    // A linha abaixo vai servir para checar se é divisível por 3 ou 5 e atribuir FizzBuzz, sem precisar de if's.
    string fizzBuzz = (i%3==0 && i%5==0) ? " - FizzBuzz" : 
        (i%5==0) ? " - Buzz" : 
            (i%3==0) ? " - Fizz" : "";

    Console.WriteLine($"{i}{fizzBuzz}");
}