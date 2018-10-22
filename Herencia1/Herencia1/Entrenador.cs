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
        private bool dirigEntrena;
        private static int contador;

        public Entrenador()
        {
            contador++;
        }

        public Entrenador(int id, string name, string address, int age, bool travel, bool concentrate, string idFeder, bool dirigEntrena) : base(id, name, address,age,travel, concentrate)
        {
            this.idFeder = idFeder;
            this.dirigEntrena = dirigEntrena;
            contador++;
        }

        public string GetIdFeder()
        {
            return idFeder;
        }
        public bool GetDirigEntrena()
        {
            return dirigEntrena;
        }
        public static int GetContEntr()
        {
            return contador;
        }
        public void SetIdFeder(string idFeder)
        {
            this.idFeder = idFeder;
        }
        public void SetDirigEntrena()
        {
            this.dirigEntrena = dirigEntrena;
        }

        //********************* METODOS *******************************

        //public void DirigirPart()
        //{

        //}

        //public void DirigirEntre()
        //{
        //    Console.WriteLine("El entrenador " + GetName() + GetAddress() + " esta dirigiendo el entrenamiento");
        //}

        //public string ToStringEntrenador()
        //{
        //    return base.ToString() + " y identificador de la federación " + idFeder;
        //}

        public override string ToString()
        {
            string result = "";
            result += base.ToString() + " y identificador de la federación " + idFeder;
            if (GetTravel())
            {
                if (GetConcentrate())
                {
                    if (dirigEntrena)
                    {
                        result += " ha viajado, se ha concentrado y esta  dirigiendo el entrenamiento";
                    }
                    else
                    {
                        result += " ha viajado, se ha concentrado pero no esta dirigiendo el entrenamiento";
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

    }
}
