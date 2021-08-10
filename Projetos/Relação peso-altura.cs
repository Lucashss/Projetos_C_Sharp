
        float alt, peso, result;

        Console.WriteLine("Relação peso/altura");
        Console.WriteLine();

        Console.Write("Digite o seu Peso.: ");
        peso = float.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Digite a sua Altura.: ");
        alt = float.Parse(Console.ReadLine());
        Console.WriteLine();

        result = peso / (float)Math.Pow(alt, 2);

        if (result < 20)
        {
            Console.WriteLine("Você está Abaixo do Peso");
        }

        else
        {
            if (result >= 25)

            {
                Console.WriteLine("Você está Acima do Peso");
            }
            else
            {
                Console.WriteLine("Você está no Peso Ideal");
            }

        }

        Console.WriteLine();
        Console.WriteLine("*** Pressione Qualquer Tecla para Finalizar o Programa ***");
        Console.ReadKey();