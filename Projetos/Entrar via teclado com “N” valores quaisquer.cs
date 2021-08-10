//47. Entrar via teclado com “N” valores quaisquer. O valor “N” (que representa a quantidade de números)
     //será digitado, deverá ser positivo, mas menor que vinte. Caso a quantidade não satisfaça a restrição,
     //enviar mensagem de erro e solicitar o valor novamente. Após a digitação dos “N” valores, exibir:
     //   a) O maior valor;
     //   b) O menor valor;
     //   c) A soma dos valores;
     //   d) A média aritmética dos valores;
     //   e) A porcentagem de valores que são positivos;
     //   f) A porcentagem de valores negativos;


        Console.WriteLine("Exercício 47");

        double n, maior = 0, menor = 0, soma = 0, porcP = 0, porcN = 0, nP = 0, nN = 0, media = 0;
         

        do
        {
            Console.WriteLine("Digite a quantidade de números á serem digitados.: ");
            n = double.Parse(Console.ReadLine());
        }
        while (n < 0 || n >= 20);

        Console.WriteLine();


        for (int i = 1; i <= n; i++)
        {
            double n2 = 0;
            Console.WriteLine("Digite o {0}º número.: ", i);
            n2 = double.Parse(Console.ReadLine());

            if (n2 > maior)
            {
                maior = n2;
            }
            else
                menor = n2;

                if(n2 < menor)
            {
                menor = n2;
            }

            soma = soma + n2;


            if (n2 > 0)
                nP++;
            else

            if (n2 < 0)
                nN++;

            media = soma / n;
        }
        porcP = (nP * 100) / n;

        porcN = (nN * 100) / n;



        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("O maior número é: {0}", maior);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("O menor número é: {0}", menor);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("A soma dos números é: {0}", soma);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("A média aritmética dos números é: {0}", media.ToString("N2"));
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("A porcentagem de valores que são positivos é: {0}%", porcP);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("A porcentagem de valores que são negativos é: {0}%", porcN);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();