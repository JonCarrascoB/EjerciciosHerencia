using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Masajista:SeleccionFutbol
    {
        private string titulacion;
        private int ageExp;
        private bool darMasajes;
        

        public Masajista()
        {

        }

        public Masajista(int id, string name, string address, int age, bool travel, bool concentrate, string titulacion, int ageExp, bool darMasajes):base(id, name, address,age,travel,concentrate)
        {
            this.titulacion = titulacion;
            this.ageExp = ageExp;
            this.darMasajes = darMasajes;
        }


        public string GetTitulacion()
        {
            return titulacion;
        }
        public int GetAgeExp()
        {
            return ageExp;
        }
        public bool GetDarMasajes()
        {
            return darMasajes;
        }
        public void SetTitulacion(string titulacion)
        {
            this.titulacion = titulacion;
        }
        public void SetAgeExp(int ageExp)
        {
            this.ageExp = ageExp;
        }
        public void SetDarMAsajes()
        {
            this.darMasajes = darMasajes;
        }

        //************************** METODOS ***************************

        public void DarMasaje()
        {
            Console.WriteLine("El masajista " + GetName() + GetAddress() + " esta dando el masaje");
        }

        //public string ToStringMasajista()
        //{
        //    return base.ToString() + ", cuya titulación es " + titulacion + " con  " + ageExp+ " de experiencia";
        //}

        public override string ToString()
        {
            string result = "";
            result += base.ToString() + ", cuya titulación es " + titulacion + " con  " + ageExp + " de experiencia";
            if (darMasajes)
            {
                result += " esta dando un masaje a un jugador";
            }
            else
            {
                result += "no esta trabajando, el muy haragan";
            }
            return result;
            
        }

    }
}
