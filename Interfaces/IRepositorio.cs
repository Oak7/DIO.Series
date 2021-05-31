using System.Collections.Generic;

namespace Gabiflix.Interfaces
{
    public interface IRepositorio<T>
    {
        //quem for implementar esta interface, vai poder passar este T
        //quem implementar esta interface terá que implementar os métodos desta interface
      List<T> Lista();
      T RetornaPorId(int Id);
      void Insere(T entidade);
      void Exclui(int Id);
      void Atualiza(int Id, T entidade);
      int ProximoId();

    }
}