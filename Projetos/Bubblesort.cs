class Program { 
static void bubblesort(int[] bubble) { 
for (int i = 1; i < bubble.Length; i++) 
for (int a = 0; a < bubble.Length - 1; a++) 
if (bubble[a] < bubble[a + 1]) troca(bubble, a); 
} 

static void troca(int[] sort, int primeiro) { 
int aux; 
aux = sort[primeiro]; 
sort[primeiro] = sort[primeiro + 1]; 
sort[primeiro + 1] = aux; 
} 

static void Main(string[] args) {
 //63. Armazenar vinte valores em um vetor. Após a digitação, exibir os valores em ordem decrescente.

int[] ordem = new int[20];

        for (int i = 0; i < ordem.Length; i++)
        {
            Console.Write("Digite o {0}º valor.: ", i + 1);
            ordem[i] = int.Parse(Console.ReadLine());
        }

        bubblesort(ordem);
        Console.WriteLine();
        Console.WriteLine("Os valores em ordem decrescente são:");
        Console.WriteLine();
        foreach (int o in ordem)
        Console.Write(o + " ");
        Console.ReadKey();

//Nota P2 Através da P1.

        double p1, media;

        Console.WriteLine("Exercício 31");
        Console.WriteLine();
        Console.Write("Digite o valor da P1: ");
        p1 = double.Parse(Console.ReadLine());
        Console.WriteLine();

        media = (15 - p1) / 2;

        Console.WriteLine("Você precisa tirar {0} para ser aprovado", media.ToString("N2"));

        Console.WriteLine();
        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();

//Calculo da média do aluno.

        double p1, p2, media;

        Console.WriteLine("Exercício 30");
        Console.WriteLine();
        Console.Write("Digite o valor da P1: ");
        p1 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o valor da P2: ");
        p2 = double.Parse(Console.ReadLine());
        Console.WriteLine();

        media = (p1 + (2 * p2)) / 3;
        
        Console.WriteLine("Sua média é {0}", media.ToString("N2"));
        Console.WriteLine();

        if (media >= 5)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
        Console.WriteLine();
        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();

//Calcular e exibir a velocidade final de automóvel em km/h.

        double vi, a, t, vf;

        Console.WriteLine("Exercício 29");
        Console.WriteLine();
        Console.Write("Digite o valor da aceleração (em m/s²): ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o valor da velocidade inicial (em m/s): ");
        vi = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o período (em segundos): ");
        t = double.Parse(Console.ReadLine());
        Console.WriteLine();

        vf = (vi + (a * t)) * 3.6;

        Console.WriteLine("A velicidade final do automóvel é: {0}", vf.ToString("N2"));

        if (vf <= 40)
        {
            Console.Write("Veículo muito lento");
        }
        else
        {
            if (vf > 40 && vf <= 60)
            {
                Console.Write("Velocidade permitida");
            }
            else
            {
                if(vf > 60 && vf <= 80)
                {
                    Console.Write("Velocidade de cruzeiro");
                }
                else
                {
                    if (vf > 80 && vf <= 120)
                    {
                        Console.Write("Veículo rápido");
                    }
                    else
                    {
                        Console.Write("Veículo muito rápido");
                    }
                }
            }
        }
    }

        


        Console.WriteLine();
        Console.WriteLine("*** Precione Qualquer tecla Para Finalizar o Programa ***");
        Console.ReadKey();
}