using System;
using DIO_PJ_CRUD.Enum;

namespace DIO_PJ_CRUD.Classes
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }


        public override string ToString()
        {
            string retorno = "";
            //Environment.NewLine = Nova linha, independente do SO
            retorno += $"Gênero: {this.Genero} {Environment.NewLine}";
            retorno += $"Titulo: {this.Titulo} {Environment.NewLine}";
            retorno += $"Descrição: {this.Descricao} {Environment.NewLine}";
            retorno += $"Ano de inicio: {this.Ano}";

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

    }

}