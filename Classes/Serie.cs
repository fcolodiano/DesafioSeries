namespace DesafioSeries
{
    using System;

    public class Serie : EntidadeBase
    {
        //Atributos 
        public Genero Genero { get; private set; }
        private string Titulo
        {
            get; set;
        }

        private string Descricao
        {
            get; set;
        }

        private int Ano
        {
            get; set;
        }


        //Construtor
        public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano;

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