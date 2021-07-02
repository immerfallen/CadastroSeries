using System.Collections.Generic;

namespace projeto.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T retornaPorId(int id);
         
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int proximoId();
    }
}