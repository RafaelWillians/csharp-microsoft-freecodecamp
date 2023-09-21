/*
    Este código irá trazer cada caractere da string abaixo para uma matriz charMessage.\
    Depois, irá inverter a ordem dos caracteres na matriz,
    contar quantas letras 'o' possuem na matriz e retornar a quantidade. 
*/

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
string new_message = new String(charMessage);

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage)
{ 
    if (i == 'o') 
    { 
        x++; 
    }
}

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");