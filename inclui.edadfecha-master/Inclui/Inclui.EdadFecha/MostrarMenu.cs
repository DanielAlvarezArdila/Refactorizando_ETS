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
        public static void Menu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("          Elija una opción.             ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Introducir nuevas fechas.");
            Console.WriteLine("2 - Calcular la edad de la primera fecha, frente a la fecha actual en años.");
            Console.WriteLine("3 - Calcular la edad de la primera fecha, frente a la fecha actual en días.");
            Console.WriteLine("4 - Calcular la edad de la segunda fecha, frente a la fecha actual en años.");
            Console.WriteLine("5 - Calcular la edad de la segunda fecha, frente a la fecha actual en dias.");
            Console.WriteLine("6 - Calcular la diferencia entre las dos fechas, en años.");
            Console.WriteLine("7 - Calcular la diferencia entre las dos fechas, en dias.");
            Console.WriteLine("8 - Salir del programa.");
        }
        /// <summary>
        /// Muestra el menú de Lenguajes disponibles
        /// </summary>
        /// <param name="idiomas">Lista de Idiomas disponibles</param>
        public static void Lenguaje(string[] idiomas)
		{
            Console.WriteLine("*******************************************************");
            idiomas.ToList().ForEach(idioma => Console.WriteLine(idioma));
            Console.WriteLine("*******************************************************");
        }
    }
}
