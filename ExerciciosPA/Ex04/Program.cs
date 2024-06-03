float saldo = 0; 
int contador = 1; 
string opcao;
float deposito;
float saque;

while (contador == 1)
{
    Console.WriteLine("----------------------------");
    Console.WriteLine("Consultar Saldo (Digite A)");
    Console.WriteLine("Sacar (Digite B)");
    Console.WriteLine("Depósito (Digite C)");
    Console.WriteLine("Sair (Digite D)");
    Console.WriteLine("----------------------------");

    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine().ToUpper();

if (opcao == "C")
{
    Console.Write("Digite o valor de depósito: ");
    deposito = float.Parse(Console.ReadLine());
    saldo += deposito;
    Console.WriteLine("Depósito realizado com sucesso");
}

else if (opcao == "A")
{
    Console.WriteLine($"Seu saldo atual é: {saldo}");
}

else if (opcao == "B")
{
    Console.Write("Digite o valor de saque: ");
    saque = float.Parse(Console.ReadLine());

    saldo -= saque;
}

else if (opcao == "D")
{
  Console.WriteLine("Saindo");
  contador = 0;
}

}


