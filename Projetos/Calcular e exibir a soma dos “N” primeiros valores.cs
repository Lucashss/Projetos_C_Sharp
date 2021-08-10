//42. Calcular e exibir a soma dos “N” primeiros valores da seqüência abaixo. O valor “N” será digitado,
        //deverá ser positivo, mas menor que cem. Caso o valor não satisfaça a restrição, enviar mensagem de erro
        //e solicitar o valor novamente.
        //A seqüência: 2, 5, 10, 17, 26, ....
            

            Console.WriteLine("Exercício 42");

        int n, n1 = 2, n2 = 3, n3 = 0, soma = 2;


        do
        {
            Console.WriteLine("Digite a quantidade da sequencia a ser somada: ");
            n = int.Parse(Console.ReadLine());
        }
        while(n < 0 || n >= 100);


        Console.Clear();
        Console.WriteLine("{0}", n1);


        for (int i = 0; i <= n; i++)
        {


            n3 = n1 + n2;

            Console.WriteLine("{0}", n3);

            n1 = n3;

            n2 = n2 + 2;

            soma = soma + n3;

        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("O Valor da soma dos valores é: {0}", soma);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();