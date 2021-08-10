class Program
{
    const int qts = 3;
    static string[] nome = new string[qts];
    static string[] sexo = new string[qts];
    static int[] idade = new int[qts];

    static void listaPessoas()
    {
        //Armazenar o nome, sexo e idade de cem pessoas. Consistir as entradas no sentido de aceitar apenas “F”
        //ou “M” para o sexo e valores positivos para a idade.Após a digitação dos dados, exibir os dados de todas
        //as pessoas com idade superior a vinte anos. No final da listagem, exibir a quantidade de pessoas que
        //foram listadas e a porcentagem que este valor representa em relação ao total de pessoas digitadas.


        for (int i = 0; i < nome.Length; i++)
        {
            Console.Write("Digite seu Nome.: ");
            nome[i] = Console.ReadLine();

            do
            {
                Console.Write("Digite seu Sexo (F ou M).: ");
                sexo[i] = Console.ReadLine().ToUpper();
            } while (sexo[i] != "F" && sexo[i] != "M");
            do
            {
                Console.Write("Digite sua Idade.: ");
                idade[i] = int.Parse(Console.ReadLine());
            } while (idade[i] < 0);
        }
    }

    static void maior20()
    {
        double porc;
        int pessoas = 0;

        for (int i = 0; i < nome.Length; i++)
        {
            if (idade[i] > 20)
            {
                Console.Write("Nome: {0}\nSexo: {1}\nIdade: {2}\n\n", nome[i], sexo[i], idade[i]);
                pessoas++;
            }
        }
        porc = (pessoas * 100) / qts;
        Console.WriteLine();
        Console.WriteLine("Foram listadas {0} pessoas na lista de maiores de 20 anos.", pessoas);
        Console.WriteLine();
        Console.WriteLine("A quantidade listada, representa {0}% da quantidade total de pessoas listadas.", porc);
    }

    static void Main(string[] args)
    {
        listaPessoas();
        Console.WriteLine();
        maior20();
        Console.WriteLine();
        Console.Write("*** Pressione qualquer tecla para finalizar o programa. ***");
        Console.ReadKey();
    }
}