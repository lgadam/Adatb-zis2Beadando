using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazis_beadando.Models.Records
{
    class Laptopok
    {
		private int id;

		public int Id		
		{
			get { return id; }
			set { id = value; }
		}
		private string sorozatszam;

		public string Sorozatszam
		{
			get { return sorozatszam; }
			set { sorozatszam = value; }
		}
		private string tipus;

		public string Tipus
		{
			get { return tipus; }
			set { tipus = value; }
		}
		private string gyartonev;

		public string Gyartonev
		{
			get { return gyartonev; }
			set { gyartonev = value; }
		}
		private string processzor;

		public string Processzor
		{
			get { return processzor; }
			set { processzor = value; }
		}
		private string videokartya;

		public string Videokartya
		{
			get { return videokartya; }
			set { videokartya = value; }
		}
		private int ram;

		public int Ram
		{
			get { return ram; }
			set { ram = value; }
		}
		private bool kepernyomeret;

		public bool Kepernyomeret
		{
			get { return kepernyomeret; }
			set { kepernyomeret = value; }
		}
		private int processzororajel;

		public int Processzororajel
		{
			get { return processzororajel; }
			set { processzororajel = value; }
		}











	}
}
