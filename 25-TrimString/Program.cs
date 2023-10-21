string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string textoCortado = "";
int periodLocation = 0;
int inicioTexto = 0;
int tamanhoSubtexto = 0;
bool checarRemocaoPonto = false;
int tamanhoTexto = 0;


foreach(string myString in myStrings)
{
    textoCortado = myString;
    tamanhoTexto = textoCortado.Length;
    inicioTexto = 0;

    do
    {        
        periodLocation = textoCortado.IndexOf(".");

        if(periodLocation >= 0)
        {
            
            tamanhoSubtexto = periodLocation - inicioTexto;
            textoCortado = textoCortado.Remove(periodLocation, 1);
            Console.WriteLine($"{textoCortado.Substring(inicioTexto, tamanhoSubtexto)}");
            inicioTexto = periodLocation+1;
            checarRemocaoPonto = true;
            tamanhoTexto = tamanhoTexto - tamanhoSubtexto - 2;
        }
        if(checarRemocaoPonto == false && inicioTexto == 0)
        {
            Console.WriteLine($"{myString}");
        }
        if(periodLocation < 0 && checarRemocaoPonto == true)
        {            
            tamanhoSubtexto = tamanhoTexto;
            Console.WriteLine($"{textoCortado.Substring(inicioTexto, tamanhoSubtexto)}");
        }  

    } while(periodLocation >= 0);

}
