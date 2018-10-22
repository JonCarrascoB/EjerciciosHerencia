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
        private bool travel;
        private bool concentrate;

        private Object a;
        private String b;




        public SeleccionFutbol()
        {
            contador++;
        }

        public SeleccionFutbol (int id, string name, string address, int age, bool travel, bool concentrate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
            this.travel = travel;
            this.concentrate = concentrate;
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
        public bool GetTravel()
        {
            return travel;
        }
        public bool GetConcentrate()
        {
            return concentrate;
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
        public void SetTRavel(bool travel)
        {
            this.travel = travel;
        }
        public void SetConcentrate(bool concentrate)
        {
            this.age = age;
        }


        //*********************** METODOS ********************************



        public void Concentrarse()
        {
            Console.WriteLine("El jugador " + GetName() + GetAddress() + " se ha concentrado");
        }

        public void Viajar()
        {
            Console.WriteLine("El jugador " + GetName() + GetAddress() + " ha viajado");
        }

        //public string ToString()
        //{
        //    return "El miembro de la selección con identificador " + id + ", nombre " + name + ", apellidos " + address + ", edad " + age;
        //}


        public override string ToString()
        {
            string result = "";
            result += "El miembro de la selección con identificador " + id + ", nombre " + name + ", apellidos " + address + ", edad " + age;
            if (travel)
            {
                if (concentrate)
                {
                    result += " ha viajado y se ha concentrado";
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
