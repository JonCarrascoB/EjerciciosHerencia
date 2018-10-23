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
        private static int contMas;
        

        public Masajista()
        {
            contMas++;
        }

        public Masajista(int id, string name, string address, int age, bool travel, bool concentrate, string titulacion, int ageExp, bool darMasajes):base(id, name, address,age,travel,concentrate)
        {
            this.titulacion = titulacion;
            this.ageExp = ageExp;
            this.darMasajes = darMasajes;
            contMas++;
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
        public static int GetContMas()
        {
            return contMas;
        }
        public void SetTitulacion(string titulacion)
        {
            this.titulacion = titulacion;
        }
        public void SetAgeExp(int ageExp)
        {
            this.ageExp = ageExp;
        }
        public void SetDarMAsajes(bool darMasajes)
        {
            this.darMasajes = darMasajes;
        }

        //************************** METODOS ***************************

        //public void DarMasaje()
        //{
        //    Console.WriteLine("El masajista " + GetName() + GetAddress() + " esta dando el masaje");
        //}

        //public string ToStringMasajista()
        //{
        //    return base.ToString() + ", cuya titulación es " + titulacion + " con  " + ageExp+ " de experiencia";
        //}

        public override string ToString()
        {
            string result = "";
            result += base.ToString() + ", cuya titulación es " + titulacion + " con  " + ageExp + " de experiencia";
            if (GetTravel())
            {
                if (GetConcentrate())
                {
                    if (darMasajes)
                    {
                        result += " ha viajado, se ha concentrado y esta dando un masaje";
                    }
                    else
                    {
                        result += " ha viajado, se ha concentrado pero no esta dando masajes";
                    }
                }
                else
                {
                    result += " ha viajado pero no se ha concentrado";
                }
            }
            else
            {
                result += " no ha viajado";
            }
            return result;

        }
        public override string Accion()
        {
            if (GetDarMasajes())
            {
            return base.Accion() + " va a dar masajes. ";
            }
            return base.Accion() + " no da masajes. ";
        }
        public override string Tarea()
        {
            if (GetDarMasajes())
            {
                return base.Accion() + " va a dar masajes. ";
            }
            return base.Accion() + " no da masajes. ";
        }
    }
}
