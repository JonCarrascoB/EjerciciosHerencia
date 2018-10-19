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

        public Futbolista()
        {

        }
        public Futbolista (int id, string name, string address, int age, int dorsal, string demark) :base(id, name,address,age)
        {
            this.dorsal = dorsal;
            this.demark = demark;
        }

        public int GetDorsal()
        {
            return dorsal;
        }
        public string GetDemark()
        {
            return demark;
        }

        public void SetDorsal (int dorsal)
        {
            this.dorsal = dorsal;
        }
        public void SetDemark(string demark)
        {
            this.demark = demark;
        }

        //*********************** METODOS ***************************
        public void JugarPartido()
        {

        }

        public void Entrenar()
        {

        }

        public string ToStringFutbolista()
        {
            return base.ToString() + ", dorsal " +dorsal+ " y juega en la demarcación " +demark;
        }

    }
}
