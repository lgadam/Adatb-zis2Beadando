using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazis_beadando.Models.Records
{
    class Laptopok
    {
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
            set
            {
                if (value == null)
                {
                    throw new Exception("A típus nem lehet null");
                }
                tipus = value;
            }
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
                if (value < 0 || value > 64)
                {
                    throw new Exception("Valós értéket kell megadni..");
                }
                ram = value;
            }
        }
        private int kepernyomeret;

        public int Kepernyomeret
        {
            get { return kepernyomeret; }
            set
            {
                kepernyomeret = value;
            }
        }
        private int processzororajel;

        public int Processzororajel
        {
            get { return processzororajel; }
            set
            {
                if (value < 1000 || value > 5000)
                {
                    throw new Exception("Valós értéket kell megadni..");
                }
                processzororajel = value;
            }
        }
    }
}
