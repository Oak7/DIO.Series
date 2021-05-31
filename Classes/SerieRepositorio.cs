using System;
using System.Collections.Generic;
using Gabiflix.Interfaces;

namespace Gabiflix
{
    public class SerieRepositorio : IRepositorio<Serie>
    /*a classe SerieRepositorio está implementando um IRepositorio de série*/
    {
        /*criando uma lista dentro do repositório*/
        private List<Serie> listaSerie = new List<Serie>();

        
        /*Tem que implementar os métodos da interface*/
        public void Atualiza(int Id, Serie objeto)
        {
            listaSerie[Id] = objeto;
        }

        public void Exclui(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
        
    }
}