//40. Exibir os trinta primeiros valores da série de Fibonacci. A série: 1, 1, 2, 3, 5, 8, ...

        Console.WriteLine("Exercício - 40");

        int n = 0, n2 = 1, n3 = 0;

        Console.WriteLine("{0}", n2);

        for (int i=1; i <=30; i++)
        {

            n3 = n + n2;

            Console.WriteLine("{0}", n3);

            n = n2;
            n2 = n3;
        }

        Console.WriteLine();
        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();