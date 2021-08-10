        double valor1, valor2, valor3;

        Console.WriteLine("Exercício 26");
        Console.WriteLine();
        Console.Write("Digite o primeiro Valor: ");
        valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o segundo Valor: ");
        valor2 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o terceiro Valor: ");
        valor3 = double.Parse(Console.ReadLine());
        Console.WriteLine();



        if (valor1 + valor2 > valor3 && valor2 + valor3 > valor1 && valor1 + valor3 > valor2)
        {
            if (valor1 == valor2 && valor1 == valor3)
            {
                Console.WriteLine("O Triangulo é Equilatero");
            }
            else
            {
                if (valor1 != valor2 && valor1 != valor3 && valor2 != valor3)
                {
                    Console.WriteLine("O Triangulo é Escaleno");
                }
                else
                {
                    Console.WriteLine("O Triangulo é Isosceles");
                }

            }
        }
        else
        {
            Console.WriteLine("Não é um Triangulo");
        }
        Console.WriteLine();
        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();