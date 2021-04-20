using System.Collections.Generic;

namespace Gabiflix.Interfaces
{
    public interface IRepositorio<T>
    {
        //quem for implementar esta interface, vai poder passar este T
      List<T> Lista();
      T RetornaPorId(int Id);
      void Insere(T entidade);
      void Excluir(int Id);
      void Atualiza(int Id, T entidade);
      int ProximoId();

    }
}