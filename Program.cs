using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class BugerKing
    {
        
        static void Main(string[] args)
        {
            double vlt = 0, total = 0;
            int a,op,i=1;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t\tMENU");
                Console.WriteLine("\nSelecione um Combo:\n");
                Console.WriteLine("\n1 - Para 1x Combo WHOPPER                                          			R$19,90\n");
                Console.WriteLine("\n2 - Para 1x Cheddar Duplo + 1x Batata Suprema + 1x Free Refill     			R$19,90\n");
                Console.WriteLine("\n3 - Para 1x Combo WHOPPER + 1x Cheedar                        				R$24,90\n");
                Console.WriteLine("\n4 - Para 2x Combo WHOPPER + 1x Batata Média + 1x Free Refill   				R$26,90\n\n");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nVoce selecionou 1x Combo WHOPPPER\n");
                        c1++;
                        vlt = vlt + 19.90;
                        Console.WriteLine("\nDeseja Pedir mais um Combo? (1 - Sim / 0 - Nao) ");
                        a = Convert.ToInt16(Console.ReadLine());

                        if (a == 1)
                        {
                            continue;
                            
                        }

                        else
                        {
                            i = 0;
                        }
                    break;

                    case 2:
                    Console.WriteLine("\nVoce selecionou 1x Cheddar Duplo + 1x Batata Suprema + 1x Free Refill\n");
                    c2++;
                    vlt = vlt + 19.90;
                    Console.WriteLine("\nDeseja Pedir mais um Combo? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;

                    }

                    else
                    {
                        i = 0;
                    }
                    break;

                    case 3:
                    Console.WriteLine("\nVoce selecionou 1x Combo WHOPPER + 1x CheedarR\n");
                    c3++;
                    vlt = vlt + 24.90;
                    Console.WriteLine("\nDeseja Pedir mais um Combo? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;

                    }

                    else
                    {
                        i = 0;
                    }
                    break;

                    case 4:
                    Console.WriteLine("\nVoce selecionou 2x Combo WHOPPER + 1x Batata Média + 1x Free Refill\n");
                    c4++;
                    vlt = vlt + 26.90;
                    Console.WriteLine("\nDeseja Pedir mais um Combo? (1 - Sim / 0 - Nao) ");
                    a = Convert.ToInt16(Console.ReadLine());

                    if (a == 1)
                    {
                        continue;
                        
                    }

                    else
                    {
                        i = 0;
                    }
                    break;                 
                    default:
                    Console.WriteLine("\nValor inválido");
                    i = 0;
                    break;
                }

                


            }while (i != 0);
            total = total + vlt;
            Console.WriteLine("\nQuantidade de Combos Vendidos:");
            Console.WriteLine("1o Combo: " + c1);
            Console.WriteLine("2o Combo: " + c2);
            Console.WriteLine("3o Combo: " + c3);
            Console.WriteLine("1o Combo: " + c4);
            Console.WriteLine("\nValor Total: R$" + total);
            Console.WriteLine("\n\nPrecissione Enter para Sair");
            Console.ReadLine();
        }
    }
}
