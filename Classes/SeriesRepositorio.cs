using System.Collections.Generic;
using System;
using projeto.Interfaces;

namespace projeto
{
    public class SeriesRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            listaSeries[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Excluir(); 
        }

        public void Insere(Series entidade)
        {
            listaSeries.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int proximoId()
        {
            return listaSeries.Count;
        }

        public Series retornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}