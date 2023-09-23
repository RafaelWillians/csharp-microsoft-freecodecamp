using System;

// Inicializando os vetores das notas e dos nomes dos alunos.
string[] nomeAluno = new string[] {"Sophia", "Andrew", "Emma" , "Logan"};
 
int[] sophiaNota = new int[] {90, 86, 87, 98, 100};
int[] andrewNota = new int[] {92, 89, 81, 96 , 90};
int[] emmaNota = new int[] {90, 85, 87, 98, 68};
int[] loganNota = new int[] {90, 95, 87, 88, 96};

/* 
    Declaração das variáveis da soma, média e letras das notas, 
    além do índice para percorrer pelos vetores usando foreach (sem usar for no momento)
    e a quantidadeNota para a divisão da média.
*/

int[] somaNota = new int [4];

decimal[] mediaNota = new decimal[4];

string[] letraNota = new string[4];

int indice = 0;
int quantidadeNota = 5;

// Preencho o vetor para somar as notas dos alunos.
somaNota[0] = sophiaNota.Sum();
somaNota[1] = andrewNota.Sum();
somaNota[2] = emmaNota.Sum();
somaNota[3] = loganNota.Sum();

// Cabeçalho do output
Console.WriteLine("Student\t\tGrade\n");


/*
    Para cada nota, é calculada a média e atribuída a letra da nota correspondente.
    Necessário comparar explicitamente mediaNota como int, pois caso contrário
    resultará em erro em algumas notas e/ou letraNota não sairá correspondente a
    tabela do exercício.
    Por enquanto, sem usar for ou switch-case.    
*/

foreach(int nota in somaNota)
{
    mediaNota[indice] = (decimal)nota / quantidadeNota;
    if((int)mediaNota[indice] <= 59)
    {
        letraNota[indice] = "F";

    }
    else if((int)mediaNota[indice] >= 60 && (int)mediaNota[indice] <= 62)
    {
        letraNota[indice] = "D-";
    }
    else if((int)mediaNota[indice] >=63 && (int)mediaNota[indice] <= 66)
    {
        letraNota[indice] = "D";
    }
    else if((int)mediaNota[indice] >=67 && (int)mediaNota[indice] <= 69)
    {
        letraNota[indice] = "D+";
    }
    else if((int)mediaNota[indice] >=70 && (int)mediaNota[indice] <= 72)
    {
        letraNota[indice] = "C-";
    }
    else if((int)mediaNota[indice] >=73 && (int)mediaNota[indice] <= 76)
    {
        letraNota[indice] = "C";
    }
    else if((int)mediaNota[indice]  >=77 && (int)mediaNota[indice] <= 79)
    {
        letraNota[indice] = "C+";
    }
    else if((int)mediaNota[indice]  >=80 && (int)mediaNota[indice] <= 82)
    {
        letraNota[indice] = "B-";
    }
    else if((int)mediaNota[indice]  >=83 && (int)mediaNota[indice] <= 86)
    {
        letraNota[indice] = "B";
    }
    else if((int)mediaNota[indice]  >=87 && (int)mediaNota[indice] <= 89)
    {
        letraNota[indice] = "B+";
    }
    else if((int)mediaNota[indice]  >=90 && (int)mediaNota[indice] <= 92)
    {
        letraNota[indice] = "A-";
    }
    else if((int)mediaNota[indice]  >=93 && (int)mediaNota[indice] <= 96)
    {
        letraNota[indice] = "A";
    }
    else if((int)mediaNota[indice]  >=97 && (int)mediaNota[indice] <= 100)
    {
        letraNota[indice] = "A+";
    }
    else
    {
        Console.WriteLine("Erro: nota inválida!");
    }
    Console.WriteLine($"{nomeAluno[indice]}:\t\t{mediaNota[indice]}\t\t{letraNota[indice]}");    
    indice++;
}








