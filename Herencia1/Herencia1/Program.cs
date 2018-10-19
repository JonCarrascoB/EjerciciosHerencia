using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {

            Futbolista fut1 = new Futbolista(001, "Iker", "Casillas",30,01,"Portero");
            Futbolista fut2 = new Futbolista(002, "Josep", "Pique", 26, 04, "Defensa");
            Futbolista fut3 = new Futbolista(003, "Iker", "Helguera", 29, 15, "Mediocampista");
            Futbolista fut4 = new Futbolista(004, "", "Casillas", 21, 14, "Delantero");
            Masajista mas1 = new Masajista(036, "Luis", "Delgado Meco", 62, "Medico", 30);
            Masajista mas2 = new Masajista(037, "Mariano", "Fichas Enteras", "Fisioterapeuta", 15);
            Entrenador ent1 = new Entrenador(050, "Javier", "Clemente", 69, "JC007");
            Entrenador ent2 = new Entrenador(050, "Ander", "Garitano", 69, "AG089");


            //********************** Mostrar el numero de registrados *****************************
            
            Console.WriteLine(SeleccionFutbol.GetContador());

            //**************** Mostrar listas de clases hijas **************************
            List<Futbolista> futbols = new List<Futbolista>();
            futbols.Add(fut1);
            futbols.Add(fut2);
            futbols.Add(fut3);
            futbols.Add(fut4);
            List<Masajista> masaj = new List<Masajista>();
            masaj.Add(mas1);
            masaj.Add(mas2);
            List<Entrenador> entren = new List<Entrenador>();
            entren.Add(ent1);
            entren.Add(ent2);
            foreach (Futbolista x in futbols)
            {
                    Console.WriteLine(x.ToStringFutbolista());
            }
            foreach (Masajista x in masaj)
            {
                Console.WriteLine(x.ToStringMasajista());
            }
            foreach (Entrenador x in entren)
            {
                Console.WriteLine(x.ToStringEntrenador());
            }




            Console.ReadLine();
        }
    }
}
