using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROIECT_PAW_SFETCUA_1064_WF


{
    public class Hotel : ICloneable

    {
        private string numele;
        private string adresa;
        private List<Camera> camere;
        private List<Oaspete> oaspeti;


        public Hotel()
        {
            numele = "Hotel Andreea";
            adresa = "Strada Biruintei 71b";
            camere = new List<Camera>
    {
        new Camera(101, "Single", 200),
        new Camera(102, "Double", 300)
    };
            oaspeti = new List<Oaspete>
    {
        new Oaspete(1010, 'F', "Sfetu Alina", 15,
            new List<Rezervare> { new Rezervare(1, 3), new Rezervare(2, 2) }),
        new Oaspete(1011, 'M', "Sfetcu Denis", 11,
            new List<Rezervare> { new Rezervare(3, 5), new Rezervare(4, 3) })
    };
        }

        
      

        public Hotel(string n, string a, List<Camera> c, List<Oaspete> o)
        {
            numele = n;
            adresa = a;
            camere = new List<Camera>(c);
            oaspeti = new List<Oaspete>(o);
        }

        public string Numele { get => numele; set => numele = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        internal List<Camera> ListaC { get => camere; set => camere = value; }

        internal List<Oaspete> ListaO { get => oaspeti; set => oaspeti = value; }

        public object Clone()
        {
            Hotel clona = (Hotel)MemberwiseClone();
            List<Camera> listaClona = new List<Camera>();
            foreach (Camera c in camere)
                listaClona.Add((Camera)c.Clone());
            clona.ListaC = listaClona;

            List<Oaspete> listaClonaO = new List<Oaspete>();
            foreach (Oaspete o in oaspeti)
                listaClonaO.Add((Oaspete)o.Clone());
            clona.ListaO = listaClonaO;

            return clona;
        }
        public static Hotel operator +(Hotel h, Camera c)
        {
            h.camere.Add(c);
            return h;
        }
        public static Hotel operator +(Camera c, Hotel h)
        {
            return h + c;
        }

        public static Hotel operator +(Hotel h, Oaspete o)
        {
            h.oaspeti.Add(o);
            return h;
        }
        public static Hotel operator +(Oaspete o, Hotel h)
        {
            return h + o;
        }



        //public static explicit operator double(Hotel h)
        //{
        //    double total = 0.0f;
        //    foreach (Camera c in h.camere)
        //        total += c.Pret;
        //    return total / h.camere.Count;
        //}

        public override string ToString()
        {
            string rezultat = "Hotelul are numele: " + numele + " si se afla la adresa " + adresa;
            //rezultat+= " are urmatoarele camere: " + Environment.NewLine;
            //foreach (Camera c in camere)
            //    rezultat += c.ToString() + Environment.NewLine;
            //rezultat += " ------------------------------------------si urmatorii oaspeti: " + Environment.NewLine;
            //foreach (Oaspete o in oaspeti)
            //    rezultat += o.ToString() + Environment.NewLine;
            return rezultat;
        }

       


    }
}
