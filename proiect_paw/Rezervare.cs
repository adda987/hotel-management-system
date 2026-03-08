using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROIECT_PAW_SFETCUA_1064_WF
{
    [Serializable]
    public class Rezervare : ICloneable
    {
        private int id;
        private int durata;//nr de nopti rezervate 

        public Rezervare()
        {
            id = 0;
            durata = 0;
        }
        public Rezervare(int i, int d)
        {
            this.id = i;
            this.durata = d;
        }
        public int Id { get => id; set => id = value; }
        public int Durata { get => durata; set => durata = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Rezervarea " + id + " are o durata de " + durata + " nopti ";
        }

        //operator +pt a extinde durata  
        public static Rezervare operator +(Rezervare r, int durataNoua)
        {
            r.durata = durataNoua;
            return r;
        }
        public static Rezervare operator +(int durataNoua, Rezervare r)
        {
            return r + durataNoua;
        }





    }


}
