        float altura;
        float menorAltura = 15;
        float maiorAltura = 0;
        
        for (int contador = 1; contador <= 15; contador++)
        {

            Console.Write($"Digite a altura da {contador}° pessoa: ");
            altura = float.Parse(Console.ReadLine());


            if (altura > maiorAltura)
            {
                maiorAltura = altura;
            }
            
            if (altura < menorAltura)
            {
            
                menorAltura = altura;
            }
        
        }
        
        Console.WriteLine($"A menor altura do grupo é: {menorAltura}");

        Console.WriteLine($"A maior altura do grupo é: {maiorAltura}");
