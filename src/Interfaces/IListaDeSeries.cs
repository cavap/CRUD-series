using System.Collections.Generic;

namespace crud_series.src.Interfaces
{
    public interface IListaDeSeries<T>
    {
        bool Inserir(T cId);
        T Buscar(int id);
        bool Atualizar(int id, T cId);
        string Excluir(int id);
        List<T> GetLista();
        int ProximoId();
    }
}