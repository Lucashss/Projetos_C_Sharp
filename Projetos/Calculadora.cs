        double n1, n2;
        string operacao;

        Console.WriteLine("Exercício do dia 31/08");
        Console.WriteLine();

        Console.Write("Digite a operação desejada (utilize os símbolos +, -, * ou /): ");
        operacao = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (operacao == "+")
        {
            double soma;

            soma = n1 + n2;

            Console.WriteLine("O valor da soma dos dois valores é: {0}", soma.ToString());
        }
        else
        {
            if (operacao == "-")
            {
                double subtracao;

                subtracao = n1 - n2;

                Console.WriteLine("O valor da subtração dos dois valores é: {0}", subtracao.ToString());
            }
            else
            {
                if (operacao == "*")
                {
                    double multiplicacao;

                    multiplicacao = n1 * n2;

                    Console.WriteLine("O valor da multiplicação dos dois valores é: {0}", multiplicacao.ToString());
                }
                else
                {
                    if (operacao == "/" && n1 != 0 && n2 !=0)
                    {
                        double divisao;

                        divisao = n1 / n2;

                        Console.WriteLine("O valor da divisão dos dois valores é: {0}", divisao.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir um valor por 0");
                    }
                }
            }

        }
        Console.WriteLine();
        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();
