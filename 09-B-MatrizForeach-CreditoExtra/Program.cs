// Inicializando variáveis.
int[] sophiaNota = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewNota = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaNota = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganNota = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyNota = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisNota = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericNota = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorNota = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

int[] alunoNota = new int[10];

int quantidadeAvaliacao = 5;

string[] nomeAluno = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

string letraGrauAluno = "";


// Cabeçalho
Console.WriteLine($"Student\t\tExam Score\tOverall\tGrade\t\tExtra Credit\n");


/*
    Primeiro foreach para checar nome a nome, usar como nota atual
    para base nos cálculos a seguir. 
*/



foreach (string nome in nomeAluno)
{
    string alunoAtual = nome;

    if (alunoAtual == "Sophia")
        alunoNota = sophiaNota;

    else if (alunoAtual == "Andrew")
        alunoNota = andrewNota;

    else if (alunoAtual == "Emma")
        alunoNota = emmaNota;

    else if (alunoAtual == "Logan")
        alunoNota = loganNota;

    else if (alunoAtual == "Becky")
    alunoNota = beckyNota;

    else if (alunoAtual == "Chris")
        alunoNota = chrisNota;

    else if (alunoAtual == "Eric")
        alunoNota = ericNota;

    else if (alunoAtual == "Gregor")
        alunoNota = gregorNota;

    else
        continue;

    int somaNotaAvaliacao = 0;
    int contadorNotaAvaliacao = 0;
    int quantidadeCreditoExtra = 0;
    
    decimal mediaNotaAlunoAtual = 0;
    decimal somaCreditoExtra = 0;
    decimal pontoCreditoExtra = 0;
    decimal mediaCreditoExtra = 0;
    decimal notaTotal = 0;    


    /*
        Segundo foreach, para percorrer por todas as notas de cada um.
    */
    foreach (int pontuacao in alunoNota)
    {
        contadorNotaAvaliacao += 1;

        if (contadorNotaAvaliacao <= quantidadeAvaliacao)
        {
            // Soma a pontuação das avaliações normais.
            somaNotaAvaliacao += pontuacao;
        }
        else
        {
           // Soma a pontuação somente das atividades extras.
            somaCreditoExtra += pontuacao;
            quantidadeCreditoExtra++;

        }
    }

    // Exam Score
    mediaNotaAlunoAtual = (decimal)(somaNotaAvaliacao) / quantidadeAvaliacao;

    // Extra Credit
    mediaCreditoExtra = (decimal)(somaCreditoExtra) / quantidadeCreditoExtra;

    // Extra Credit (quantidade de pontos)
    pontoCreditoExtra = (decimal) (somaCreditoExtra / 10) / quantidadeAvaliacao;

    // Overall
    notaTotal = mediaNotaAlunoAtual + pontoCreditoExtra;

    // (Não-otimizado) Para atribuir letra de nota ao aluno, de acordo com a nota.
    if (notaTotal >= 97)
        letraGrauAluno = "A+";
    else if (notaTotal >= 93)
        letraGrauAluno = "A";
    else if (notaTotal >= 90)
        letraGrauAluno = "A-";
    else if (notaTotal >= 87)
        letraGrauAluno = "B+";
    else if (notaTotal >= 83)
        letraGrauAluno = "B";
    else if (notaTotal >= 80)
        letraGrauAluno = "B-";
    else if (notaTotal >= 77)
        letraGrauAluno = "C+";
    else if (notaTotal >= 73)
        letraGrauAluno = "C";
    else if (notaTotal >= 70)
        letraGrauAluno = "C-";
    else if (notaTotal >= 67)
        letraGrauAluno = "D+";
    else if (notaTotal >= 63)
        letraGrauAluno = "D";
    else if (notaTotal >= 60)
        letraGrauAluno = "D-";
    else
        letraGrauAluno = "F";

    //Saída de cada aluno e suas notas.     
    Console.WriteLine($"{alunoAtual}\t\t{mediaNotaAlunoAtual}\t\t{notaTotal}\t{letraGrauAluno}\t{mediaCreditoExtra} ({pontoCreditoExtra} pts)");
}

