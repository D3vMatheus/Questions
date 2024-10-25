//1)

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

//2)
string sentence = " EscrevA um programA que verifique, em umA string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre";

int a=0;

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence.ToLower()[i] == 'a')
        a++;
}
Console.WriteLine($"Quantidade de letras a-A na frase é: {a}");

//3)

int sum = 0;
int index = 12;
int k = 1;

do
{
    k = k + 1;
    sum = sum + k;
} while (k < index);

Console.WriteLine($"Valor: {sum}");

