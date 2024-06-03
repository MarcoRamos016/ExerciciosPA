int numDigitado = 0;
int soma = 0;
int numero = 2;

Console.Write("Digite um número inteiro: ");
numDigitado = int.Parse(Console.ReadLine());

do{
{
  if (numero % 2 == 0)
  {
    soma += numero;
    
        numero += 2 ;
  }

}
}while (numero <= numDigitado);
Console.WriteLine($"A soma dos números pares de 2 até {numDigitado} é: {soma}");