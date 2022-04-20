using System;

namespace inclui.edadfecha
{
    /// <summary>
    /// Clase inicial en la cual tendremos el menu y 
    /// las llamadas a las funciones del programa
    /// </summary>
    class Program
    {
        /*                          ¡LEER ANTES DE TRABAJAR!
         *                          
         *          Cada vez que creemos (NUEVO), modifiquemos o eliminemos*(ELIMINADO) 
         *          una función original, dejar reflejado con un estado en el SUMMARY.
         *          Ejemplo: el Program.Continuar ha sido (MODIFICADO) para 
         *          que haga una cosa más que el original.
         *          
         *          *En vez de eliminar, comentar la parte a eliminar (si es
         *          una variable insignificante, eliminar directamente), 
         *          siendo lo recomendado en las funciones/los métodos. 
         *          Para dar constancia  de que existió, pero está inutilizado.
         *          
         *          TL;DR: no eliminar funciones, poner si es NUEVO, MODIFICADO
         *          o ELIMINADO en el summary para que sea visible la mejora del
         *          código, de NUESTRO código.
         * 
         */



        static void Main(string[] args)
        {

            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio();
            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio();
            DatosAnio.InformacionAnio fechaActual = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Today,
                antesCristo = false
            };

            int opcion;
            int diferenciaAnio;
            int diferenciaDias;
            bool leido = false;
            do
            {
                if (leido)
                {
                    MostrarMenu.Menu();
                    opcion = OpcionesMenu.LeerOpciones();
                }
                else
                {
                    opcion = 1;
                }
                switch (opcion)
                {
                    case 1:
                        primeraFecha = CSComprobaciones.SolicitarFecha("Introduzca la primera fecha");
                        segundaFecha = CSComprobaciones.SolicitarFecha("Introduzca la segunda fecha");
                        leido = true;
                        break;
                    case 2:
                        diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, fechaActual);
                        Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", primeraFecha.fecha, fechaActual.fecha, diferenciaAnio);
                        break;
                    case 3:
                        diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, fechaActual);
                        Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", primeraFecha.fecha, fechaActual.fecha, diferenciaDias);
                        break;
                    case 4:
                        diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(segundaFecha, fechaActual);
                        Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", segundaFecha.fecha, fechaActual.fecha, diferenciaAnio);
                        break;
                    case 5:
                        diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(segundaFecha, fechaActual);
                        Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", segundaFecha.fecha, fechaActual.fecha, diferenciaDias);
                        break;
                    case 6:
                        diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
                        Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", primeraFecha.fecha, segundaFecha.fecha, diferenciaAnio);
                        break;
                    case 7:
                        diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
                        Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", primeraFecha.fecha, segundaFecha.fecha, diferenciaDias);
                        break;
                }

                CSComprobaciones.Continuar("");

            } while (opcion != 8);
        }
    }
}
