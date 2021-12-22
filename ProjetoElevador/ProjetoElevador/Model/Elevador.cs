using System;
using System.Collections.Generic;

namespace ProjetoElevador.Model
{
    /// <summary>Class <c>Elevador</c> modela a estrutura de um 
    /// Elevador</summary>
    /// 
    internal class Elevador
    {


        int AndarAtual { get; set; }
        public int TotalDeAndares { get; set; }
        public int Capacidade { get; set; }
        Boolean Subindo { get; init; }
        List<string> Pessoa;
        List<int> AndarDesejado { get; set; }


        /// <summary>
        /// Contrutor do Elevador inicializa com capacidade de 4 pessoas e 
        /// estrutura para 4 andares
        /// </summary>
        /// <param name="capacidade"> Capacidade de passageiros do Elevador</param>
        /// <param name="totalAndares">Total de andares do Elevador</param>
        public Elevador(int capacidade = 4, int totalAndares = 4)
        {
            this.Pessoa = new List<string>();
            this.TotalDeAndares = totalAndares;
            this.Capacidade = capacidade;
            this.AndarAtual = 0;
            this.AndarDesejado = new List<int>();
        }

        /// <summary>
        ///   Informa a quantidade de pessoas do elevador
        /// </summary>
        /// <returns>(int) pessoas no elevador</returns>
        internal int Ocupacao()
        {
            return this.Pessoa.Count;
        }

        /// <summary>
        /// Adicionar uma pessoa no elevador
        /// </summary>
        /// <param name="nome">nome do passageiro</param>
        /// <param name="andar">andar de destino do passageiro</param>
        /// <returns></returns>
        public int Entrar(String nome, int andar)
        {
            Pessoa.Add(nome);
            AndarDesejado.Add(andar);
            return Pessoa.Count;

        }

        /// <summary>
        /// Permite uma pessoa sair do Elevador
        /// </summary>
        /// <returns>nova quantidade de passageiros do elevador</returns>
        public int Sair()
        {

            Pessoa.RemoveAt(0);
            AndarDesejado.RemoveAt(0);
            return Pessoa.Count;

        }


        /// <summary>
        /// Sobe o elevador
        /// </summary>
        /// <returns>novo andar que se encontra o Elevador</returns>
        public int Subir()
        {
            return this.AndarAtual++;
        }

        /// <summary>
        /// Desce o elevador
        /// </summary>
        /// <returns>devolve o novo andar do elevador</returns>
        public int Descer()
        {

            return this.AndarAtual--;

        }

        /// <summary>
        ///   informa posicao atual do elevador
        /// </summary>
        /// <returns>devolve a posicao do elevador</returns>
        public int OndeEsta()
        {
            return this.AndarAtual;
        }
        /// <summary>
        ///   retorna as vagas disponiveis
        /// </summary>
        /// <returns>devolve a quantidade de vagas</returns>
        public int QuantasVagas()
        {
            return this.Capacidade - AndarDesejado.Count;
        }


    }
}
