using System;

namespace inclui.edadfecha
{
    /// <summary>
    /// Clase inicial en la cual tendremos el menu y 
    /// las llamadas a las funciones del programa
    /// </summary>
    class Program
    {
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

                CSComprobaciones.Continuar();

            } while (opcion != 8);
        }
    }
}
