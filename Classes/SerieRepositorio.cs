using System;
using System.Collections.Generic;
using Gabiflix.Interfaces;

namespace Gabiflix
{
    public class SerieRepositorio : IRepositorio<Serie>
    /*a classe SerieRepositorio está implementando um IRepositorio de série*/
    {
        /*Tem que implementar os métodos da interface*/
        public void Atualiza(int Id, Serie objeto)
        {
            ListaSerie[Id] = objeto;
        }

        public void Excluir(int Id)
        {
            ListaSerie[Id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return ListaSerie[Id];
        }
        /*criando uma lista dentro do repositório*/
        private List<Serie> ListaSerie = new List<Serie>();

    }
}