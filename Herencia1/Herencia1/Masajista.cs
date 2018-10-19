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
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private int v5;

        public Masajista()
        {

        }

        public Masajista(int id, string name, string address, int age, string titulacion, int ageExp):base(id, name, address,age)
        {
            this.titulacion = titulacion;
            this.ageExp = ageExp;
        }

        public Masajista(int v1, string v2, string v3, string v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public string GetTitulacion()
        {
            return titulacion;
        }
        public int GetAgeExp()
        {
            return ageExp;
        }
        public void SetTitulacion(string titulacion)
        {
            this.titulacion = titulacion;
        }
        public void SetAgeExp(int ageExp)
        {
            this.ageExp = ageExp;
        }

        //************************** METODOS ***************************

        public void DarMasaje()
        {

        }

        public string ToStringMasajista()
        {
            return base.ToString() + ", cuya titulación es " + titulacion + " con  " + ageExp+ " de experiencia";
        }

    }
}
