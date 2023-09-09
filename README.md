# C# Certification with freeCodeCamp Challenge

Olá! Este repositório terá alguns exercícios da certificação C# da Microsoft em conjunto com o freeCodeCamp. A certificação trata de conceitos básicos do C# , como uso de variáveis, tipos de dados, estruturas de controle, uso de condições. No final, terá uma prova no site do freeCodeCamp para certificar o conhecimento.

## Regras e Convenções - variáveis

- Podem ter caracteres alfanuméricos e sublinhado. Símbolo de cerquilha/sustenido `#` ou cifra `$` não são permitidos.

- Precisam começar com uma letra alfabética ou sublinhado, não um número.

- Case-sensitive, o que significa que `string Value;` e `string value;` são duas variáveis diferentes.

- Não podem ser uma palavra-chave do C#. Por exemplo, não podemos usar as seguintes declarações de variável: `decimal decimal;` ou `string string;`.

## Convenções de codificação

- Devem usar minúsculas concatenadas, que é um estilo de escrita que usa uma letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente. Por exemplo, `string thisIsCamelCase;`.

- Devem sempre começar com uma letra alfabética. Os desenvolvedores usam o sublinhado para uma finalidade especial, portanto, não iremos inicialmente usar.

- Devem ser descritivos e sugestivos, no contexto do aplicativo. Escolha um nome para a variável que represente o tipo de dados que ela manterá.

- Devem ser uma ou mais palavras inteiras unidas. Não use contrações ou abreviações, pois o nome da variável (e, consequentemente, a finalidade dela) pode não ficar claro para terceiros que lerem o seu código.

- Não podem incluir o tipo de dados da variável. Você poderá ser aconselhado a usar um estilo como `string strValue;`. Esse conselho não é mais atual.

Alguns exemplos de declarações de variáveis:

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

Ao declarar variável como "var", é necessário inicializá-lo e o tipo será de acordo com o tipo do dado inicializado. Se inicializar com string, será do tipo sting por exemplo.

## Sufixos literais

Para especificar ao compilador que deseja trabalhar com aquele valor, com determinado tipo.

|     |         |
| --- | ------- |
| F   | float   |
| M   | decimal |
| D   | double  |

## Sequencias de escape

|     |                                                                                  |
| --- | -------------------------------------------------------------------------------- |
| \n  | Pula linha.                                                                      |
| \t  | Insere tab.                                                                      |
| \\  | Insere barra invertida.                                                          |
| \"  | Insere aspas.                                                                    |
| \u  | Inserir caractere Unicode (UTF-16) correspondente ao código digitado em seguida. |

## Outros exemplos

|                     |                                                                                                                                                                                                                                                                 |
| ------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| @                   | Literal de cadeia de caracteres textual. Serve para dar saída também nos espaços que constarem no texto ou nas barras invertidas, para sair precisamente o que foi digitado, sem precisar digitar as sequências de escape. Precisa inserir o @ antes das aspas. |
| +                   | Serve também para concatenar strings.                                                                                                                                                                                                                           |
| $"{variável} texto" | Interpolação de caracteres. Permite economizar tempo, para digitar strings, combinando cadeia de caracteres literal e variáveis.                                                                                                                                |

### Dicas

- Evitar variáveis intermediárias.

- É possível combinar literais textuais e interpolação, inserindo $@ antes das aspas.

- Com conversões implícitas, como por exemplo sair uma string em que há uma soma dentro dos parênteses, o uso de parênteses () permite resolver primeiro o que estiver dentro, tornando a somar os valores dentro dele, para então dar saída como string do resultado.

## Exemplo para converter valor int em decimal

int first = 7;

int second = 5;

decimal quotient = (decimal)first / (decimal)second;

Console.WriteLine(quotient);

## Operadores de atribuição composta

|     |                                       |
| --- | ------------------------------------- |
| =   | Atribuir o valor especificado.        |
| +=  | Também adiciona o valor especificado. |
| -=  | Também subtrai o valor especificado.  |
| ++  | Adiciona 1.                           |
| --  | Subtrai 1.                            |

Podem também ser usados antes de informar a variável. Se usados antes, é aplicada a operação antes de trazermos o valor.

Se depois, vai ser feita a operação depois de puxarmos o valor da variável.

int value = 1;

value++;

Console.WriteLine("First: " + value); // mostra 2

Console.WriteLine("Second: " + value++); // mostra 2, mas a variável fica em 3

Console.WriteLine("Third: " + value); // mostra 3

Console.WriteLine("Fourth: " + (++value)); // mostra 4

### 

## Classes com ou sem estado

|                           |            |                                    |
| ------------------------- | ---------- | ---------------------------------- |
| Com estado (ou stateful)  | Não-static | Precisa instanciar (criar objeto). |
| Sem estado (ou stateless) | static     | Não precisa instanciar.            |

## Diferença entre Parâmetros e Argumentos

|            |                                                 |
| ---------- | ----------------------------------------------- |
| Parâmetros | Quando passamos variáveis na chamada do método. |
| Argumentos | Quando passamos valores ao chamar o método.     |

## Operadores lógicos

|     |     |
| --- | --- |
| \|  | OR  |
| &&  | AND |