string? inputUsuario = "";
string? funcao = "";
char[] charsTrim = {' ', '.', ',', ';'};
bool validarInput = false;

do
{
    Console.WriteLine("Digitar função (administrador, gerente, usuario): ");

    inputUsuario = Console.ReadLine();
    funcao = inputUsuario!.Trim(charsTrim);
    funcao = funcao.ToLower();
    
    switch (funcao)
    {
        case "administrador": 
        case "gerente":
        case "usuario":
            Console.WriteLine($"Função de ({funcao}) aceita com sucesso.");
            validarInput = true;
        break;
    
        default: 
            Console.WriteLine("Entrada inválida. Digite novamente.\n");
            validarInput = false;
        break;

    }    

} while (validarInput == false);
