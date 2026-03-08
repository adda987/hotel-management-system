using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW_SFETCUA_1064_WF
{
    [Serializable]
    public abstract class Persoana
    {
        private int cod;
        private char sex;


        public Persoana()
        {
            cod = 0;
            sex = 'M';
        }
        public Persoana(int cod, char sex)
        {
            this.cod = cod;
            this.sex = sex;
        }   

        public int Cod { get => cod;set => cod = value; }
        public char Sex { get => sex;set => sex = value; }

        public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " + sex;
        }
    }
}
