        float va, vb, vc;

        Console.WriteLine("Exercício 27");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Digite o 1º valor.: ");
        va = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o 2º valor.: ");
        vb = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o 3º valor.: ");
        vc = float.Parse(Console.ReadLine());
        Console.WriteLine();

        // if( va == Math.sqrt((vb * vb) + (vc * vc) || vb == Math.sqrt((va * va) + (vc * vc) || vc == Math.sqrt((vb * vb) + (va * va))

        if ((va * va) == (vb * vb) + (vc * vc) || (vb * vb) == (va * va) + (vc * vc) || (vc * vc) == (vb * vb) + (va * va))
        {
            Console.WriteLine("Forma um triângulo retângulo");
        }
        else
        {
            Console.WriteLine("Não Forma um triângulo retângulo");
        }

        Console.WriteLine();
        Console.WriteLine(" *** Pressione Qualquer Tecla para Finalizar o Programa ***");
        Console.ReadKey();