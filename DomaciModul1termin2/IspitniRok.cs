using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
	class IspitniRok
	{
		private int _id = 0;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _naziv = "Naziv roka nije definisan";

		public string Naziv
		{
			get { return _naziv; }
			set { _naziv = value; }
		}
		private string _pocetak = "Pocetak roka nije definisan";

		public string Pocetak
		{
			get { return _pocetak; }
			set { _pocetak = value; }
		}
		private string _kraj = "Kraj roka nije definisan";

		public string Kraj
		{
			get { return _kraj; }
			set { _kraj = value; }
		}

		public IspitniRok() { }
		public IspitniRok(int id)
		{
			Id = id;
		}
		public IspitniRok(int id, string naziv)
		{
			Id = id;
			Naziv = naziv;
		}
		public IspitniRok(int id, string naziv, string pocetak)
		{
			Id = id;
			Naziv = naziv;
			Pocetak = pocetak;
		}
		public IspitniRok(int id, String naziv, String pocetak, String kraj)
		{
			this.Id = id;
			this.Naziv = naziv;
			this.Pocetak = pocetak;
			this.Kraj = kraj;
		}


		public string PreuzmiTekstualnuReprezentacijuKlase()
		{
			return $"Ispitni rok br. {Id} pod nazivom {Naziv} pocinje {Pocetak} i zavrsava {Kraj}.";
		}

		public bool Isti(object obj)
		{
			if (obj == null || !(obj is IspitniRok))
				return false;
			IspitniRok noviRok = (IspitniRok)obj;
			return this.Id == noviRok.Id && this.Naziv == noviRok.Naziv;
		}
	}
}
