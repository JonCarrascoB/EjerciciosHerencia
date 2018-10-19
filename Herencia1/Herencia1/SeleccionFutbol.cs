using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class SeleccionFutbol
    {
        private int id;
        private string name;
        private string address;
        private int age;
        private static int contador;

        public SeleccionFutbol()
        {
            contador++;
        }

        public SeleccionFutbol (int id, string name, string address, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
            contador++;
        }

        //************************ GET y SET *************************************
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public int GetAge()
        {
            return age;
        }
        public static int GetContador()
        {
            return contador;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        //*********************** METODOS ********************************

        

        public void Concentrarse()
        {

        }

        public void Viajar()
        {

        }

        public string ToString()
        {
            return "El miembro de la selección con identificador " + id + ", nombre " + name + ", apellidos " + address + ", edad " + age;
        }

    }
}
