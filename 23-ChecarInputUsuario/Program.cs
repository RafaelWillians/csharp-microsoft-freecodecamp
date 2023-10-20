int numericValue = 0;
//
string? readResult;

bool validEntry = false;
bool validNumber = false;


Console.WriteLine("Digite um número inteiro entre 5 e 10: ");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);

        if (validNumber)
        {
            if(numericValue >= 5 && numericValue <= 10)
            {
                validEntry = true;
                Console.WriteLine($"O número digitado {numericValue} foi aceito com sucesso.");
            }
            else
            {
                Console.WriteLine("Dados inválidos. Tente novamente.");
            }
                        
        }
        else
        {
            Console.WriteLine("Dados inválidos. Tente novamente.");
        }
    }
} while (validEntry == false);