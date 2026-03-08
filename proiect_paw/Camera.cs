using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PROIECT_PAW_SFETCUA_1064_WF

{
    [Serializable]
    public class Camera : IComparable, ICloneable
    {
        private int numar;
        private string tip;
        private double pret;


        public Camera()
        {
            numar = 0;
            tip = "Necunoscut";
            pret = 0.0f;
        }
        public Camera(int n, string t, double p)
        {
            numar = n;
            tip = t;
            pret = p;
        }
        public int Numar { get => numar; set => numar = value; }
        public double Pret { get => pret; set => pret = value; }
        public string Tip { get => tip; set => tip = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }




        //sortare camere dupa pret iar apoi dupa tip
        public int CompareTo(object obj)
        {
            Camera c = (Camera)obj;
            if (this.pret < c.pret)
                return -1;
            else if (this.pret > c.pret) return 1;
            else return string.Compare(this.Tip, c.Tip);
        }

        public override string ToString()
        {
            return "Camera cu numarul " + numar + " este de tipul " + tip + " si are pretul " + pret+"\t";
        }

        //conversie la double pentru a obtine pretul camerei 

        public static explicit operator double(Camera c)
        {
            return c.Pret;
        }


    }
}
