        double n1, n2, n3;

        Console.WriteLine("Exercício 24");
        Console.WriteLine();
        Console.WriteLine("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite o segundo valor: ");
        n3 = double.Parse(Console.ReadLine());
        Console.WriteLine();

        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine("O valor {0} digitado é o maior número", n1.ToString());
        }
        else
        {
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O valor {0} digitado é o maior número", n2.ToString());
            }
            else
            {
                Console.WriteLine("O valor {0} digitado é o maior número", n3.ToString());
            }
        }
        Console.WriteLine();
        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();