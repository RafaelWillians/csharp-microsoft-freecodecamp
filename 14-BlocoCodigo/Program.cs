
/* 
// Código antigo.

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

// Dará erro de compilação a linha abaixo. Value está apenas dentro do escopo do if acima.

Console.WriteLine($"Outside of code block: {value}");
 */

/* 
// Outro exemplo.

bool flag = true;

// Necessário inicializar para funcionar.
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
// Neste exemplo não dará erro. Declarada value fora do bloco if.
Console.WriteLine($"Outside of code block: {value}");
 */

/* 
// Terceiro exemplo.

bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}

// Pode ser sem o bloco, se for uma única linha.
bool flag = true;
if (flag)
    Console.WriteLine(flag);

 */

/* 
// Quarto exemplo.

// Por convenção, não é recomendado fazer da forma abaixo, por dificultar a leitura.
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/

// Forma recomendada.
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");



