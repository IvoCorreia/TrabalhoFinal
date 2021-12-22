using System;

namespace ProjetoElevador.Utils
{
    /// <summary>Class <c>Util</c> apresenta Metodos de Apoio ao 
    /// Projeto</summary>
    /// 
    public class Util
    {

        /// <summary>Este metodo imprime uma resposta
        ///    na tela dentro de uma caixa formatada.</summary>
        /// <param name="info">String com a Mensagem a ser contida na caixa</param>
        public static void PrintInfo(String info)
        {


            Console.WriteLine("┼═══════════════════════┼");
            Console.WriteLine("║\t\t\t║");
            Console.WriteLine("║\t" + info + "\t║");
            Console.WriteLine("║\t\t\t║");
            Console.WriteLine("┼═══════════════════════┼");
        }

        /// <summary>Este metodo imprime uma resposta
        ///    na tela dentro de uma caixa formatada.
        ///    permite a seleção das cores de fundo e
        ///    do texto</summary>
        /// <param name="info">String com a Mensagem a ser contida na caixa</param>
        /// <param name="cor">cor da fonte</param>
        /// <param name="fundo">cor do fundo do console</param>

        public static void PrintInfo(String info, ConsoleColor cor, ConsoleColor fundo = ConsoleColor.Black)
        {

            ConsoleColor Oldbackground = Console.BackgroundColor;
            ConsoleColor Oldforeground = Console.ForegroundColor;

            Console.ForegroundColor = cor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("┼═══════════════════════════════════════┼");
            Console.WriteLine("║\t\t\t\t\t║");
            Console.WriteLine("║\t\t" + info + "\t\t║");
            Console.WriteLine("║\t\t\t\t\t║");
            Console.WriteLine("┼═══════════════════════════════════════┼");
            Console.ForegroundColor = Oldforeground;
            Console.BackgroundColor = Oldbackground;
        }

    }
}
