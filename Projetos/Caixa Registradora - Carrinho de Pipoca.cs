class Program { static void Main(string[] args) 
{ 
int opcao = 5; 
int car; 
int qtddoce; 
int qtdsalgada; 
int total=0; 
int maior=0,carr=0; int menor = 999999999, carr2 = 0; 
int[] doce = new int[21]; 
int[] salgado = new int[21]; 
int totaldoceqtd=0, totalsalgqtd=0, totalsalg=0, totaldoce=0;

for (int x = 0; opcao != 0; x++)
        {
            Console.Clear();
            Console.WriteLine("0. Finalizar.");
            Console.WriteLine("1. Lançar venda.");
            Console.WriteLine("2. Mapa de faturamento.");
            Console.WriteLine("3. Carrinho que mais faturou e quanto foi.");
            Console.WriteLine("4. Carrinho que menos faturou e quanto foi.");
            Console.WriteLine();
            Console.Write("Informe sua opção.: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                do
                {
                    Console.Clear();
                    Console.Write("Digite o carrinho a ser registrado (1..20) .: ");
                    car = int.Parse(Console.ReadLine());

                } while (car < 1 || car > 20);

                Console.Write("Quantos pacotes de pipoca doce o carrinho {0} vendeu?.: ", car);
                qtddoce = int.Parse(Console.ReadLine());
                Console.Write("Quantos pacotes de pipoca salgada o carrinho {0} vendeu?.: ", car);
                qtdsalgada = int.Parse(Console.ReadLine());
                Console.WriteLine();

                doce[car - 1] += qtddoce;
                salgado[car - 1] += qtdsalgada;
                totaldoceqtd = totaldoceqtd + qtddoce;
                totalsalgqtd = totalsalgqtd + qtdsalgada;
                totaldoce = totaldoce + (qtddoce * 3);
                totalsalg = totalsalg + (qtdsalgada * 2);
                total = totaldoce + totalsalg;

                Console.WriteLine("Venda registrada com sucesso !!!");
                Console.Beep();
                Console.WriteLine();
                Console.Write("*** Pressione qualquer tecla para retornar. ***");
                Console.ReadKey();
            }               
            else
            {
                if (opcao == 2)
                {
                        Console.Clear();
                        Console.WriteLine("                     MAPA DE FATURAMENTO");
                        Console.WriteLine("=============================================================");
                        Console.WriteLine("|           |   Pipoca Doce   |   Pipoca Salg   |           |");
                        Console.WriteLine("| Carrinho  |-----------------+-----------------|   Total   |");
                        Console.WriteLine("|           | Qtde |   Valor  | Qtde |   Valor  |           |");
                        Console.WriteLine("|-----------+------+----------+------+----------+-----------|");

                    for (int i = 0; i <= 19; i++)
                    {
                        Console.WriteLine("|     {0,2:0#}    |  {1,3:#0} | {2,8:#,##0.00} |  {3,3:##0} | {4,8:#,##0.00} |  {5,8:#,##0.00} |", i + 1, doce[i], (doce[i]*3).ToString("N2"), salgado[i], (salgado[i]*2).ToString("N2"), ((doce[i] * 3)+(salgado[i] * 2)).ToString("N2"));

                            if ((doce[i] * 3) + (salgado[i] * 2) > maior)
                            {
                                maior = (doce[i] * 3) + (salgado[i] * 2);
                                carr = i + 1;
                            }
                            else

                            if ((doce[i] * 3) + (salgado[i] * 2) != 0)
                            {
                                if ((doce[i] * 3) + (salgado[i] * 2) < menor)
                                {
                                    menor = (doce[i] * 3) + (salgado[i] * 2);
                                    carr2 = i + 1;
                                }
                            }                                 
                    }
                            Console.WriteLine("|-----------+------+----------+------+----------+-----------|");
                            Console.WriteLine("|Total geral|  {0,3:#0} | {1,8:#,##0.00} |  {2,3:##0} | {3,8:#,##0.00} |  {4,8:#,##0.00} |", totaldoceqtd, totaldoce, totalsalgqtd, totalsalg, total);
                            Console.WriteLine("=============================================================");
                            Console.WriteLine();
                            Console.Write("*** Pressione qualquer tecla para retornar. ***");
                            Console.ReadKey();
                }
                else
                {
                    if (opcao == 3)
                    {
                        if (carr == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Não houve registro.");
                            Console.Write("*** Pressione qualquer tecla para retornar. ***");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("O carrinho nº {0}, vendeu R$ {1}", carr, maior.ToString("N2"));
                            Console.Write("*** Pressione qualquer tecla para retornar. ***");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        if (opcao == 4)
                        {
                            if (carr2 == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Não houve registro.");
                                Console.Write("*** Pressione qualquer tecla para retornar. ***");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("O carrinho nº {0}, vendeu R$ {1}", carr2, menor.ToString("N2"));
                                Console.Write("*** Pressione qualquer tecla para retornar. ***");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
        }
}