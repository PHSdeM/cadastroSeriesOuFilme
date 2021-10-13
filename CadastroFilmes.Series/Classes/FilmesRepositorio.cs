using System;
using System.Collections.Generic;
using CadastroFilmes.Series.Interfaces;

namespace CadastroFilmes.Series
{
	public class FilmesRepositorio : IERepositorio<Filme>
	{
        private List<Filme> listaFilme = new List<Filme>();
		public void Atualiza(int id, Filme objeto)
		{
			listaFilme[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaFilme[id].Excluir();
		}

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Filme objeto)
		{
			listaFilme.Add(objeto);
		}

		public List<Filme> Lista()
		{
			return listaFilme;
		}

        public List<Filme> lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
		{
			return listaFilme.Count;
		}

        public int proximoId()
        {
            throw new NotImplementedException();
        }

        public Filme RetornaPorId(int id)
		{
			return listaFilme[id];
		}

        public Filme retornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}