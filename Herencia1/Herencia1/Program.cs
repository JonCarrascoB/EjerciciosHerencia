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

            Futbolista fut1 = new Futbolista(001, "Iker", "Casillas",30,true, false, 01,"Portero", false, true);
            Futbolista fut2 = new Futbolista(002, "Josep", "Pique", 26, true, true, 04, "Defensa", false, true);
            Futbolista fut3 = new Futbolista(003, "Iker", "Helguera", 29,true, true, 15, "Mediocampista", true, true);
            Futbolista fut4 = new Futbolista(004, "Sergio", "Ramos", 35, true, true, 03, "Defensa", true, false);
            Futbolista fut5 = new Futbolista(005, "Julen", "Guerrero", 52, true, true, 13, "Delantero", true, false);
            Futbolista fut6 = new Futbolista(006, "Cristiano", "Ronaldo", 21, false, false, 14, "Delantero", false, true);
            Masajista mas1 = new Masajista(036, "Luis", "Delgado Meco", 62, true,true,"Medico", 30, true);
            Masajista mas2 = new Masajista(037, "Mariano", "Fichas Enteras", 40, true, true, "Fisioterapeuta", 15, false);
            Masajista mas3 = new Masajista(037, "Ana Maria", "Perez Encientro", 36, false, true, "Fisioterapeuta", 15, false);
            Entrenador ent1 = new Entrenador(050, "Javier", "Clemente", 69, true, true, "JC007",true);
            Entrenador ent2 = new Entrenador(052, "Ander", "Garitano", 46, true, false, "AG089", false);
            Entrenador ent3 = new Entrenador(054, "Rafael", "Benitez", 51, true, false, "AR070", false);


            //********************** Mostrar el numero de registrados *****************************

            //Console.WriteLine(SeleccionFutbol.GetContador());

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
            //List<SeleccionFutbol> laRoja = new List<SeleccionFutbol>()
            //{
            //    fut1,fut2,fut3,fut4,mas1,mas2,mas3,ent1,ent2
            //};



            SeleccionPais s1 = new SeleccionPais("España");
            s1.AñadirPartic(fut1);
            s1.AñadirPartic(fut2);
            s1.AñadirPartic(fut3);
            s1.AñadirPartic(fut4);
            s1.AñadirPartic(fut5);
            s1.AñadirPartic(fut6);
            s1.AñadirPartic(mas1);
            s1.AñadirPartic(mas2);
            s1.AñadirPartic(ent1);
            s1.AñadirPartic(ent2);
            s1.AltaSeleccion(mas3);
            s1.AltaSeleccion(ent3);

            foreach (SeleccionFutbol x in s1.GetParticipante())
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("El numero de miembros de la seleción es " + s1.GetParticipante().Count());

            //s1.BajaSeleccion();

            //foreach (SeleccionFutbol y in s1.GetParticipante())
            //{
            //    Console.WriteLine(y.ToString());
            //}
            //Console.WriteLine("El numero de miembros de la seleción es " + s1.GetParticipante().Count());

            //Console.WriteLine(s1.PrepararPartido());

            //Console.WriteLine(s1.JugarPartido());

            Console.Clear();

            int elec = -1;
            do
            {
                Console.WriteLine("Elija la opción deseada");
                Console.WriteLine("1. Alta participante");
                Console.WriteLine("2. Baja participante");
                Console.WriteLine("3. Mostrar Seleccion");
                Console.WriteLine("4. Preparar Partido");
                Console.WriteLine("5. Jugar Partido");
                Console.WriteLine("6. Salir");

                try
                {
                    elec = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No es un parametro permitido");
                }

                switch (elec)
                {
                    case 1:

                        s1.AñadirPartic();

                        break;
                    case 2:
                        s1.BajaSeleccion();

                        break;
                    case 3:
                        s1.BajaSeleccion();

                        break;
                    case 4:
                        s1.BajaSeleccion();

                        break;
                    case 5:
                        s1.BajaSeleccion();

                        break;
                    case 6:
                        
                        Console.WriteLine("Que tenga usted un buen día");

                        break;
                }

            } while (elec != 6);

            Console.ReadLine();
        
        
        }

        public void AltaSeleccion()
        {
            Console.WriteLine("Inserte el tipo de miembro de la selección");
            string type = Console.ReadLine();
            if (type == "Futbolista")
            {
                Console.WriteLine("Inserte el numero de ID");
                int id = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
