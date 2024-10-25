<h3>1)</h3>

```csharp

Console.WriteLine("Informe um número para saber se ele pertence ou não à sequência de fibonnaci");
string? number = Console.ReadLine();
int intNumber = Int32.Parse(number);

int num1 = 1;
int num2 = 0;
int result = 0;

List<int> fib = new List<int>();
fib.Add(num2);
fib.Add(num1);

do
{
    result = num1 + num2;
    num2 = num1;
    num1 = result;
    fib.Add(result);    


} while (result <= intNumber);

if (fib.Contains(intNumber))
    Console.WriteLine($"{intNumber} pertence à sequência de fibonnaci");
else
    Console.WriteLine($"{intNumber} não pertence à sequência de fibonnaci");
```

<h3>2)</h3>

```csharp
string sentence = " EscrevA um programA que verifique, em umA string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre";

int a=0;

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence.ToLower()[i] == 'a')
        a++;
}
Console.WriteLine($"Quantidade de letras a-A na frase é: {a}");
```

<h3>3)</h3>

```csharp

int sum = 0;
int index = 12;
int k = 1;

do
{
    k = k + 1;
    sum = sum + k;
} while (k < index);

Console.WriteLine($"Valor: {sum}");

```

<h3>4)</h3>

```csharp

/*
a - 1, 3, 5, 7, 9, 11, 13 -> Números ímpares;

b - 2, 4, 8, 16, 32, 64, 128, 256, 512 -> 2^n onde 'n' é o próximo número seguindo a sequência convencional 1, 2, 3... n;

c - 0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 -> n^n onde 'n' é um número elevado a ele mesmo 1¹, 2², 3³... n^n;

d - 4, 16, 36, 64, 100, 144, 196, 256  2n^n -> números pares elevados a 'n' onde é o próximo número da sequência numérica convencional 1, 2, 3... n;

e - 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 -> sequência de fibonnaci onde o próximo número é igual a soma dos dois últimos números

f - 2,10, 12, 16, 17, 18, 19, 20, 21, 22, 23 -> números primos e compostos (até 3 números compostos consecutivos)
2 primo
10, 12, 16, composto
17 primo
18 composto
19 primo
20, 21, 22 composto
23 primo
*/

```

<h3>5)</h3>

```csharp

/*
 * Acendo o interruptor 1 e espero cerca de 15 minutos
 * Apago o interruptor 1
 * Acendo o interruptor 2
 * Verifico as salas:
 *      se a lâmpada estiver apagada e fria é a sala referente ao interruptor que não foi aceso;
 *      se a lâmpada estiver apagada e quente é a sala referente ao interruptor que foi aceso e apagado antes de verificar as salas;
 *      se a lâmpada estiver acesa é a sala referente ao interruptor que foi aceso antes da verificação.
 */
```
