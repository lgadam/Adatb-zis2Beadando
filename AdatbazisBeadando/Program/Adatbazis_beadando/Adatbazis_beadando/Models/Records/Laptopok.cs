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
            set
            {
                if (value == null)
                {
                    throw new Exception("Sorozatszám nem lehet null");
                }
                sorozatszam = value;
            }
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
            set
            {
                if (value == null)
                {
                    throw new Exception("Nem lehet null a gyártónév");
                }
                gyartonev = value;
            }
        }
        private string processzor;

        public string Processzor
        {
            get { return processzor; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nem lehet null a processzor");
                }
                processzor = value;
            }
        }
        private string videokartya;

        public string Videokartya
        {
            get { return videokartya; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nem lehet null a videókartya");
                }
                videokartya = value;
            }
        }
        private int ram;

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nem lehet null a ram");
                }
                ram = value;
            }
        }
        private string kepernyomeret;

        public string Kepernyomeret
        {
            get { return kepernyomeret; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nem lehet null a képernyőméret");
                }
                kepernyomeret = value;
            }
        }
        private int processzororajel;

        public int Processzororajel
        {
            get { return processzororajel; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nem lehet null a processzororajel");
                }
                processzororajel = value;
            }
        }
    }
}
