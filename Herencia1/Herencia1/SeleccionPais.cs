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
        private static int contFut, contMas, contEntr;
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
            if(AltaSeleccion(s1))
                if (s1.GetType().Name == "Futbolista")
                {
                    contFut++;
                }
                else if (s1.GetType().Name == "Masajista")
                {
                    contMas++;
                }
                else if (s1.GetType().Name == "Entrenador")
                {
                    contEntr++;
                }
           
            Console.WriteLine("El miembro de la seleccion " + s1.GetType().Name + " ha sido añadido.");
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
                    return true;
                }
                else if (s1.GetType().Name == "Masajista" && Masajista.GetContMas() < 4)
                {
                    return true;
                }
                else if (s1.GetType().Name == "Futbolista")
                {
                    return true;
                }

                Console.WriteLine("no hay capacidad para más participantes del tipo " + s1.GetType().Name + " en la selección de " + GetNombrePais());
                return false;
            }
            else
            {
                return false;
            }
        }

            

            public void BajaSeleccion()
            {
                Console.WriteLine("Inserta el ID del miembro de la selección");
                int idInt = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (SeleccionFutbol x in participantes)

                {
                    if (x.GetId() == idInt)
                    {
                        if (x.GetType().Name == "Futbolista")
                        {
                            contFut--;
                        }
                        else if (x.GetType().Name == "Masajista")
                        {
                            contMas--;
                        }
                        else if (x.GetType().Name == "Entrenador")
                        {
                            contEntr--;
                        }
                        Console.WriteLine("El miembro de la seleccion " + x.GetType().Name + " ha sido eliminado.");
                        participantes.Remove(x);
                    }
                }
            }
            catch (System.InvalidOperationException ex)
            {

            }
                Console.WriteLine("No existe un miembro de la selección con ese numero ID");
            }


        public string PrepararPartido()
        { 
            string result = "";
            foreach (SeleccionFutbol x in participantes)
            {
                if (x.GetType().Name == "Futbolista")
                {
                    result += "El " + x.GetType().Name + " de nombre " + x.GetName() + " " + x.GetAddress();
                    if (x.GetTravel())
                    {
                        if (x.GetConcentrate())
                        {
                            result += " ha viajado, se ha concentrado,";
                            result += x.Accion();
                        }
                        else
                        {
                            result += " ha viajado pero no se ha concentrado. ";
                        }
                    }
                    else
                    {
                        result += " no ha viajado. ";
                    }
                }
                else if (x.GetType().Name == "Masajista")
                {
                    result += "El " + x.GetType().Name + " de nombre " + x.GetName() + " " + x.GetAddress();
                    if (x.GetTravel())
                    {
                        if (x.GetConcentrate())
                        {
                            result += " ha viajado, se ha concentrado,";
                            result += x.Accion();
                        }
                        else
                        {
                            result += " ha viajado pero no se ha concentrado. ";
                        }
                    }
                    else
                    {
                        result += " no ha viajado. ";
                    }
                }
                else if (x.GetType().Name == "Entrenador")
                {
                    result += "El " + x.GetType().Name + " de nombre " + x.GetName() + " " + x.GetAddress();
                    if (x.GetTravel())
                    {
                        if (x.GetConcentrate())
                        {
                            result += " ha viajado, se ha concentrado,";
                            result += x.Accion();
                        }
                        else
                        {
                            result += " ha viajado pero no se ha concentrado. ";
                        }
                    }
                    else
                    {
                        result += " no ha viajado. ";
                    }
                }
            }
            return result;
        }

        public string JugarPartido()
        {
            string result = "";
            foreach (SeleccionFutbol x in participantes)
            {
                if (x.GetType().Name == "Futbolista")
                {
                    result += "El " + x.GetType().Name + " de nombre " + x.GetName() + " " + x.GetAddress();
                    result += x.Tarea();
                }
                else if (x.GetType().Name == "Masajista")
                {
                    result += "El " + x.GetType().Name + " de nombre " + x.GetName() + " " + x.GetAddress();
                    result += x.Tarea();
                }
                else if (x.GetType().Name == "Entrenador")
                {
                    result += "El " + x.GetType().Name + " de nombre " + x.GetName() + " " + x.GetAddress();
                    result += x.Tarea();
                }
            }
            return result;
        }
    }
}
