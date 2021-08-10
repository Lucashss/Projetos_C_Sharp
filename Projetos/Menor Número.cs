        double n1, n2;

        Console.WriteLine("Menor número");
        Console.WriteLine();

        Console.WriteLine("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());

        if (n1 < n2)
        {
            Console.WriteLine("O valor {0} digitado é o menor número", n1.ToString());
        }
        else
        {
            Console.WriteLine("O valor {0} digitado é o menor número", n2.ToString());

        }
        Console.WriteLine();
        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();