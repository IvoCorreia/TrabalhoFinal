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

        public Elevador(int capacidade = 4, int totalAndares = 4)
        {
            this.Pessoa = new List<string>();
            this.TotalDeAndares = totalAndares;
            this.Capacidade = capacidade;
            this.AndarAtual = 0;
            this.AndarDesejado = new List<int>();
        }

        internal int Ocupacao()
        {
            return this.Pessoa.Count;
        }

        //retorna quantidade de pessoas no elevador
        public int Entrar(String nome, int andar)
        {
            Pessoa.Add(nome);
            AndarDesejado.Add(andar);
            return Pessoa.Count;

        }

        // retorna quantide de pessoas no elevador
        public int Sair()
        {

            Pessoa.RemoveAt(0);
            AndarDesejado.RemoveAt(0);
            return Pessoa.Count;

        }
        //Retorna o Novo Andar 
        public int Subir()
        {
            return this.AndarAtual++;
        }

        //Retorna o Novo Andar 
        public int Descer()
        {

            return this.AndarAtual--;

        }

        // informa posicao atual do elevador
        public int OndeEsta()
        {
            return this.AndarAtual;
        }
        // retorna vagas disponiveis
        public int QuantasVagas()
        {
            return this.Capacidade - AndarDesejado.Count;
        }


    }
}
