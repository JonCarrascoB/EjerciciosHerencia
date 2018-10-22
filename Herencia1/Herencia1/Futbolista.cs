using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Futbolista:SeleccionFutbol
    {
        private int dorsal;
        private string demark;
        private bool entrena;

        public Futbolista()
        {

        }
        public Futbolista (int id, string name, string address, int age, bool travel, bool concentrate, int dorsal, string demark, bool entrena) :base(id, name,address,age, travel, concentrate)
        {
            this.dorsal = dorsal;
            this.demark = demark;
            this.entrena = entrena;
        }

        public int GetDorsal()
        {
            return dorsal;
        }
        public string GetDemark()
        {
            return demark;
        }
        public bool GetEntrena()
        {
            return entrena;
        }

        public void SetDorsal (int dorsal)
        {
            this.dorsal = dorsal;
        }
        public void SetDemark(string demark)
        {
            this.demark = demark;
        }
        public void SetEntrena (bool entrena)
        {
            this.entrena = entrena;
        }

        //*********************** METODOS ***************************
        public void JugarPartido()
        {

        }

        public void Entrenar()
        {
            Console.WriteLine("El jugador " + GetName() + GetAddress() + " esta entrenando");
        }

        //public string ToStringFutbolista()
        //{
        //    return base.ToString() + ", dorsal " +dorsal+ " y juega en la demarcación " +demark;
        //}

        public override string ToString()
        {
            string result = "";
            result += base.ToString() + ", dorsal " + dorsal + " y juega en la demarcación " + demark;
            if (entrena)
            {
                result += " esta entrenando";
            }
            else
            {
                result += "no esta entrenando";
            }
            return result;
        }

    }
}
