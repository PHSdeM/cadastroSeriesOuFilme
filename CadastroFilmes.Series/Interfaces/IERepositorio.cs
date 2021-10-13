using System.Collections.Generic;

namespace CadastroFilmes.Series.Interfaces
{
    public interface IERepositorio<T>
    {
        List<T> lista();
        T retornaPorId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualiza(int id, T entidade);
        int proximoId();        
    }
}