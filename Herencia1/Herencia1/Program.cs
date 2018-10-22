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

            Futbolista fut1 = new Futbolista(001, "Iker", "Casillas",30,true, false, 01,"Portero", false);
            Futbolista fut2 = new Futbolista(002, "Josep", "Pique", 26, true, true, 04, "Defensa", false);
            Futbolista fut3 = new Futbolista(003, "Iker", "Helguera", 29,true, true, 15, "Mediocampista", true);
            Futbolista fut4 = new Futbolista(004, "Cristiano", "Ronaldo", 21, false, false, 14, "Delantero", false);
            Masajista mas1 = new Masajista(036, "Luis", "Delgado Meco", 62, true,true,"Medico", 30, true);
            Masajista mas2 = new Masajista(037, "Mariano", "Fichas Enteras", true, true, "Fisioterapeuta", 15, false);
            Masajista mas3= new Masajista(037, "Ana Maria", "Perez Encientro", false, true, "Fisioterapeuta", 15, false);
            Entrenador ent1 = new Entrenador(050, "Javier", "Clemente", 69, true, true, "JC007",true);
            Entrenador ent2 = new Entrenador(050, "Ander", "Garitano", 69, true, false, "AG089", false);


            //********************** Mostrar el numero de registrados *****************************
            
            Console.WriteLine(SeleccionFutbol.GetContador());

            //**************** Mostrar listas de clases hijas **************************
            //List<Futbolista> futbols = new List<Futbolista>();
            //futbols.Add(fut1);
            //futbols.Add(fut2);
            //futbols.Add(fut3);
            //futbols.Add(fut4);
            //List<Masajista> masaj = new List<Masajista>();
            //masaj.Add(mas1);
            //masaj.Add(mas2);
            //List<Entrenador> entren = new List<Entrenador>();
            //entren.Add(ent1);
            //entren.Add(ent2);
            //foreach (Futbolista x in futbols)
            //{
            //        Console.WriteLine(x.ToStringFutbolista());
            //}
            //foreach (Masajista x in masaj)
            //{
            //    Console.WriteLine(x.ToStringMasajista());
            //}
            //foreach (Entrenador x in entren)
            //{
            //    Console.WriteLine(x.ToStringEntrenador());
            //}

            //COmo hacer una unica lista:
            List<SeleccionFutbol> laRoja = new List<SeleccionFutbol>();
            {
                fut1,fut2,fut3,fut4,mas1,mas2,ent1,ent2
            };
           

            foreach(SeleccionFutbol x in laRoja)
            {
                Console.WriteLine(laRoja.ToString());
            }



            fut1.Viajar();

            




            Console.ReadLine();
        }
    }
}
