        double vla, vlb, vlr;
        string sexo;

        Console.WriteLine("Exercício 28");
        Console.WriteLine();

        Console.WriteLine("Digite o sexo (M ou F): ");
        sexo = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite o peso: ");
        vla = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite a altura: ");
        vlb = double.Parse(Console.ReadLine());
        Console.WriteLine();


        if (sexo == "M")
        {
            vlr = vla / (vlb * vlb);

            if (vlr < 20)
            {
                Console.WriteLine("IMC = " + vlr + "- Abaixo do Peso");
            }
            else
            {
                if (vlr >= 25)

                {
                    Console.WriteLine("IMC = " + vlr + "- Acima do Peso");
                }
                else
                {
                    Console.WriteLine("IMC = " + vlr + "- Peso ideal");
                }
            }
        }
        else
        {
            vlr = vla / (vlb * vlb);

            if (vlr < 19)
            {
                Console.WriteLine("IMC = " + vlr + "- Abaixo do Peso");
            }
            else
            {
                if (vlr >= 24)

                {
                    Console.WriteLine("IMC = " + vlr + "- Acima do Peso");
                }
                else
                {
                    Console.WriteLine("IMC = " + vlr + "- Peso ideal");
                }
            }
        }

        Console.WriteLine();
        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();
        