using System;
using System.Collections.Generic;
using System.Linq;

namespace inclui.edadfecha
{
    /// <summary>
    /// Clase en la cual tendremos una funcion para 
    /// mostrar el menu
    /// </summary>
    class MostrarMenu
    {
        /// <summary>
        /// Funcion que nos mostrara por pantalla como sera el menu
        /// </summary>
        public static void Menu(string[] idiomas)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(idiomas[0]);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(idiomas[1]);
            Console.WriteLine(idiomas[2]);
            Console.WriteLine(idiomas[3]);
            Console.WriteLine(idiomas[4]);
            Console.WriteLine(idiomas[5]);
            Console.WriteLine(idiomas[6]);
            Console.WriteLine(idiomas[7]);
            Console.WriteLine(idiomas[8]);
            Console.WriteLine(idiomas[9]);
        }
        /// <summary>
        /// Muestra el menú de Lenguajes disponibles (NUEVO)
        /// </summary>
        /// <param name="idiomas">Lista de Idiomas disponibles</param>
        public static void Lenguaje(string[] idiomas)
		{
            Console.WriteLine("*******************************************************");
            foreach (string idioma in idiomas)
            {
                Console.WriteLine(idioma);
            }
            Console.WriteLine("*******************************************************");
        }
    }
}
