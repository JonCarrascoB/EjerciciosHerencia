using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Entrenador:SeleccionFutbol
    {
        private string idFeder;

        public Entrenador()
        {

        }

        public Entrenador(int id, string name, string address, int age, string idFeder) : base(id, name, address,age)
        {
            this.idFeder = idFeder;
        }

        public string GetIdFeder()
        {
            return idFeder;
        }
        public void SetIdFeder(string idFeder)
        {
            this.idFeder = idFeder;
        }

        //********************* METODOS *******************************

        public void DirigirPart()
        {

        }

        public void DirigirEntre()
        {

        }

        public string ToStringEntrenador()
        {
            return base.ToString() + " y identificador de la federación " + idFeder;
        }

    }
}
