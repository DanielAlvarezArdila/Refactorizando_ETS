using System;
using System.Collections.Generic;
using System.Linq;

namespace inclui.edadfecha
{
    /// <summary>
    /// Clase en al cual tendremos una funcion
    /// donde el usuario debera de elegir que opcion quiere
    /// del menu
    /// </summary>
    class OpcionesMenu
    {
        /// <summary>
        /// Funcion que se encargara de leer el numero del menu
        /// que pulsara el usuario
        /// </summary>
        /// <returns>Devolvera el numero del menu puesto por el usuario</returns>
        public static int LeerOpciones()
        {
            ConsoleKeyInfo tecla;
            int valor = 0;
            do
            {
                tecla = Console.ReadKey(true);
                switch (tecla.KeyChar)
                {
                    case '1': valor = 1; break;
                    case '2': valor = 2; break;
                    case '3': valor = 3; break;
                    case '4': valor = 4; break;
                    case '5': valor = 5; break;
                    case '6': valor = 6; break;
                    case '7': valor = 7; break;
                    case '8': valor = 8; break;
                    case '9': valor = 9; break;
                }

            } while (valor == 0);

            return valor;
        }
        /// <summary>
        /// Funcion que se encargara de leer la tecla
        /// "s" o "n" depende si la fecha es a.C o a.D
        /// </summary>
        /// <returns>Devolvera la tecla pulsada por el usuario</returns>
        public static char LeerOpcionFecha()
        {
            char valor = ' ';
            bool fin = false;
            do
            {
                char tecla = Console.ReadKey(true).KeyChar;
                switch (tecla)
                {
                    case 's': valor = 's'; fin = true; break;
                    case 'n': valor = 'n'; fin = true; break;
                }
            } while (!fin);

            return valor;
        }
        /// <summary>
        /// Lee la opción del usuario al seleccionar el Idioma del Programa (INCOMPLETO)
        /// </summary>
        /// <param name="mensaje">Mensaje a Mostrar</param>
        /// <param name="lenguajes">Array que contiene los idiomas disponibles</param>
        /// <returns>Devuelve TODOS los memnsajes que se muestran por pantalla en el idioma elegido</returns>
        public static string[] LeerOpcionesLenguaje(string mensaje, string[] lenguajes)
        {

            string[] idiomaElegido = new string[0];
            Console.WriteLine("\n" + mensaje);
            string opcion = Console.ReadLine().Trim().ToUpper();

            if (lenguajes.Contains(opcion))
            {
                switch (opcion)
                {
                    /*CARGAR FICHERO EN MEMORIA*/
                    case "ES": idiomaElegido = CSIdiomas.ReadDataFromFile("ES.txt"); break;       //Español
                    case "EN": idiomaElegido = CSIdiomas.ReadDataFromFile("EN.txt"); break;       //Inglés
                    case "FR": idiomaElegido = CSIdiomas.ReadDataFromFile("FR.txt"); break;       //Francés
                    case "DE": idiomaElegido = CSIdiomas.ReadDataFromFile("DE.txt"); break;       //Alemán
                    case "IT": idiomaElegido = CSIdiomas.ReadDataFromFile("IT.txt"); break;       //Italiano
                }
            }
			else
			{
                CSComprobaciones.Continuar("Language not implemented", idiomaElegido);
			}

            return idiomaElegido;
        }
    }
}
