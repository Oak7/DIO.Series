namespace Gabiflix
{
    public class Serie : EntidadeBase
    {
        //atributos
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}

        //métodos
        public Serie (int id, Genero genero, string Titulo, string Descricao, int Ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
        }

        //public override string ToString()
       // {

       // }
        
    }
}