using System.Collections.Generic;
using crud_series.src.Interfaces;

namespace crud_series.src
{
    public class ListaDeSeries : IListaDeSeries<Serie>
    {
        private List<Serie> listaDeSeries = new List<Serie>();

        public bool Inserir(Serie serie)
        {
            this.listaDeSeries.Add(serie);
            return true;
        }

        public Serie Buscar(int id)
        {
            return this.listaDeSeries[id];
        }

        public bool Atualizar(int id, Serie serie)
        {
            if(id < this.listaDeSeries.Count)
            {
                this.listaDeSeries[id] = serie;
                return true;
            }
            return false;
        }

        public string Excluir(int id)
        {
            return this.listaDeSeries[id].Remover();
        }

        public List<Serie> GetLista()
        {
            return this.listaDeSeries;
        }

        public int ProximoId()
        {
            return this.listaDeSeries.Count;
        }
    }
}