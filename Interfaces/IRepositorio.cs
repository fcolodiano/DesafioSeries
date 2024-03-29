using System.Collections.Generic;

namespace DesafioSeries.Interfaces
{
    public interface IRepositorio <T>
    {
        List<T> Lista();
        
        T RetornaPorId(int Id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);
        
        int ProximoId();
         
    }
}