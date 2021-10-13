using System;
using System.Collections.Generic;
using CadastroFilmes.Series.Interfaces;

namespace CadastroFilmes.Series
{
	public class SeriesRepositorio : IERepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

        public List<Serie> lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
		{
			return listaSerie.Count;
		}

        public int proximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}

        public Serie retornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}