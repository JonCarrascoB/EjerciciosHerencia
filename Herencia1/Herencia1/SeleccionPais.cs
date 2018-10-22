using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class SeleccionPais
    {
        private string nombrePais;
        private List<SeleccionFutbol> participantes;
        //private int numero;

        public SeleccionPais()
        {
            participantes = new List<SeleccionFutbol>();
            
        }
        public SeleccionPais(string nombrePais)
        {
            this.nombrePais = nombrePais;
            participantes = new List<SeleccionFutbol>();
            

        }

        //****************** GET y SET **********************************
        public string GetNombrePais()
        {
            return nombrePais;
        }
        public void SetNombrePais(string nombrePais)
        {
            this.nombrePais = nombrePais;
        }

        //*************************** METODOS *******************************
        

        public void AñadirPartic(SeleccionFutbol s1)
        {
            participantes.Add(s1);
        }

        public List<SeleccionFutbol> GetParticipante()
        {
            return participantes;
        }

        public bool AltaSeleccion(SeleccionFutbol s1)
        {
            if (participantes.Count < 30)
            {
                
                if (s1.GetType().Name == "Entrenador" && Entrenador.GetContEntr() < 2)
                {
                    SeleccionPais.Add(s1);
                    return true;
                }
                else if (s1.GetType().Name == "Masajista" && Masajista.GetContMas() < 4)
                {
                    SeleccionPais.Add(s1);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("no hay capacidad para más participantes en la selección de " + GetNombrePais());
                return false;
            }
        }
    }
}
