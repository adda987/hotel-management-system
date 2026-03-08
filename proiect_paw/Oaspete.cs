using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PROIECT_PAW_SFETCUA_1064_WF

{
    [Serializable]
    public class Oaspete : Persoana,ICloneable, IComparable
    {
        
        private string nume;
        private int varsta;
        private List<Rezervare> rezervari;

        public Oaspete():base()
        {
           
            nume = "Anonim";
            varsta = 0;
            rezervari = new List<Rezervare>();
        }

        public Oaspete(int cod,char sex, string n,int v, List<Rezervare> rezervari):base(cod,sex)
        {
            
            this.nume = n;
            this.varsta = v;
            this.rezervari = rezervari;
        }

        
        public string Nume { get => nume; set => nume = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public List<Rezervare> Rezervare { get => rezervari; set => rezervari = value; }

        public object Clone()
        {
            Oaspete clona = (Oaspete)this.MemberwiseClone(); return clona;
            List<Rezervare> listaClona = new List<Rezervare>();
            foreach (Rezervare r in rezervari)
                listaClona.Add((Rezervare)r.Clone());
            clona.rezervari = listaClona;
            return clona;
        }



        public int CompareTo(object obj)
        {
            Oaspete o = (Oaspete)obj;
            if (strcmp(this.nume, o.nume) > 0)
                return -1;
            else if (strcmp(this.nume, o.nume) < 0)
                return 1;
            else return 0;
            
        }

        private int strcmp(string nume1, string nume2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string rezultat = base.ToString() + " si are numele:" +nume + " si varsta: " + varsta + Environment.NewLine;
            foreach (Rezervare r in rezervari)
                rezultat += r.ToString() + Environment.NewLine;
            return rezultat;
        }

    }
}
