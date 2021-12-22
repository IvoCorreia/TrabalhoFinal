using ProjetoElevador.Model;
using ProjetoElevador.Utils;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // INICIALIZACAO DO ELEVADOR
            Console.WriteLine("============== SISTEMA DE ELEVADOR ==============");
            Console.WriteLine("Inicialização Padrão: 4 andares e 4  vagas");
            Elevador elevador = new Elevador();
            ConsoleKeyInfo op;


            do
            {
                //IMPRIME MENU DE OPÇOES
                ImprimeStatusMenu(elevador);

                op = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("============== SISTEMA DE ELEVADOR ==============");


                switch (op.Key)
                {
                    //ENTRAR NOVOS PARAMETROS DO ELEVADOR
                    case ConsoleKey.S:

                        Console.WriteLine(" Quantos Andares o Elevador possui?");

                        int newAndares = int.Parse(Console.ReadLine());

                        Console.WriteLine(" Quantos Qual a capacidade de passageiro?");

                        int newCapacidade = int.Parse(Console.ReadLine());

                        elevador.TotalDeAndares = newAndares;
                        elevador.Capacidade = newCapacidade;

                        break;
                    //SUBIR UM ANDAR
                    case ConsoleKey.U or ConsoleKey.UpArrow:

                        if (elevador.OndeEsta() < elevador.TotalDeAndares)
                        {
                            Util.PrintInfo("SUBINDO ", ConsoleColor.Green);
                            elevador.Subir();
                        }
                        else
                        {
                            Util.PrintInfo("ULTIMO ANDAR", ConsoleColor.Red);

                        }

                        break;

                    // DESCER UM ANDAR
                    case ConsoleKey.D or ConsoleKey.DownArrow:


                        if (elevador.OndeEsta() > 0)
                        {

                            Util.PrintInfo("  DESCENDO  ", ConsoleColor.DarkGreen);

                            elevador.Descer();


                        }
                        else
                        {
                            Util.PrintInfo("ANDAR TERREO", ConsoleColor.DarkYellow);
                        }
                        break;

                    // ENTRAR NO ELEVADOR
                    case ConsoleKey.I or ConsoleKey.Enter or ConsoleKey.RightArrow:


                        if (elevador.QuantasVagas() > 0)
                        {

                            Util.PrintInfo("ENTRANDO", ConsoleColor.DarkCyan);

                            elevador.Entrar("passageiro", 1);
                        }
                        else
                        {
                            Util.PrintInfo("OCUPACAO MAX", ConsoleColor.Red);
                        }

                        break;


                    // SAIR DO ELEVADOR
                    case ConsoleKey.O or ConsoleKey.Delete or ConsoleKey.LeftArrow:

                        if (elevador.Ocupacao() > 0)
                        {

                            Util.PrintInfo("  SAINDO  ", ConsoleColor.Cyan);
                            elevador.Sair();
                        }
                        else
                        {
                            Util.PrintInfo("ELEVADOR VAZIO", ConsoleColor.Yellow);
                        }

                        break;

                }



                // sair se escolhida a opção da tecla 'Q' ou [ESC]
            } while (op.Key != ConsoleKey.Q && op.Key != ConsoleKey.Escape);


        }

        /// <summary>
        /// Imprimir menu e status atual do elevador
        /// </summary>
        /// <param name="elevador">Informar elevador para </param>
        private static void ImprimeStatusMenu(Elevador elevador)
        {
            Console.WriteLine("============== SISTEMA DE ELEVADOR ==============");
            Console.WriteLine("Quantas Vagas = " + elevador.QuantasVagas());
            Console.WriteLine("Quantas Pessoas = " + elevador.Ocupacao());
            Console.WriteLine("Quantos Andares = " + elevador.Capacidade);
            Console.WriteLine("Qual Andar Atual = " + elevador.OndeEsta());

            Console.WriteLine("============== SISTEMA DE ELEVADOR ==============");
            Console.WriteLine("Digite uma opção: (__)");
            Console.WriteLine("( S ) para Entrar (TECLA PARA DIREITA OU [ENTER])");
            Console.WriteLine("( O ) para Sair (TECLA PARA ESQUERDA OU [DELETE])");
            Console.WriteLine("( U ) para Subir um Andar (TECLA PARA CIMA)");
            Console.WriteLine("( D ) para Descer um Andar (TECLA PARA BAIXO)");
            Console.WriteLine("( S ) para Definir PADRÕES DO ELEVADOR)");
            Console.WriteLine("( Q ) para Sair do Sistema (TECLA ESC)");
        }
    }
}
