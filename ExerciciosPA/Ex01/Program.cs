int numDigitado;
int soma = 0;



Console.Write("Digite um número inteiro: ");
numDigitado = int.Parse(Console.ReadLine());



 
for (int contador = 1; contador <= numDigitado; contador++)
{
soma += numDigitado;
}

Console.WriteLine($"A soma de 1 até {numDigitado} é: {soma}");