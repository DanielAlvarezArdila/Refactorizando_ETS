using System;
using System.Collections.Generic;
using System.Linq;

namespace inclui.edadfecha
{
	/// <summary>
	/// Clase inicial en la cual tendremos el menu y 
	/// las llamadas a las funciones del programa (MODIFICADO)
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
			//(MODIFICADO)
			string[] idioma = EscogerLenguaje();
			Funcionamiento(idioma);
		}

		/// <summary>
		/// Indica al usuario el Idioma del Programa a escoger (NUEVO, INCOMPLETO)
		/// </summary>
		public static string[] EscogerLenguaje()
		{
			string[] auxIdioma = new string[0];
			//HACER COMPROBACION DE CUANTOS FICHEROS EXISTEN (RETURN List<string> IDIOMAS)

			//Lo que debe conteners idiomas (para un mostrado más sencillo y rápido) --> "\t- Español: esp"
			string[] idiomasDetectados = { "ES", "EN", "FR" };//de 3, como ejemplo
			bool salida = false;
			do
			{
				MostrarMenu.Lenguaje(idiomasDetectados);
				auxIdioma = OpcionesMenu.LeerOpcionesLenguaje("Choose an Option: ", idiomasDetectados);        //NO TRADUCIR

				if (auxIdioma.Length > 0)
				{
					salida = true;
				}
				Console.Clear();
			} while (!salida);

			return auxIdioma;
		}

		/// <summary>
		/// Llama al .funcionamiento del Programa (NUEVO)
		/// </summary>
		/// <param name="idiomas">Idioma Elegido</param>
		private static void Funcionamiento(string[] idiomas)
		{
			DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio { Modificado = false };
			DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio { Modificado = false };
			DatosAnio.InformacionAnio fechaActual = new DatosAnio.InformacionAnio
			{
				fecha = DateTime.Today,
				antesCristo = false,
				Modificado = true
			};

			int opcion;
			int diferenciaAnio;
			int diferenciaDias;
			
			do
			{
				MostrarMenu.Menu(idiomas);
				opcion = OpcionesMenu.LeerOpciones();
				string mensajeError = "";
				bool leido = ((primeraFecha.Modificado) && (segundaFecha.Modificado));
				switch (opcion)
				{
					case 1:
						primeraFecha = CSComprobaciones.SolicitarFecha(idiomas[10],idiomas);
						segundaFecha = CSComprobaciones.SolicitarFecha(idiomas[11],idiomas);

						break;
					case 2:
						if (leido) 
						{
							diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, fechaActual);
							Console.WriteLine(idiomas[12], primeraFecha.fecha.ToShortDateString(), fechaActual.fecha.ToShortDateString(), diferenciaAnio);
						}
						else
						{
							mensajeError = (idiomas[13]);
						}
						break;
					case 3:
						if (leido)
						{
						diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, fechaActual);
						Console.WriteLine(idiomas[14], primeraFecha.fecha.ToShortDateString(), fechaActual.fecha.ToShortDateString(), diferenciaDias);
						}
						else
						{
							mensajeError = (idiomas[15]);
						}
						break;
					case 4:
						if (leido)
						{
							diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(segundaFecha, fechaActual);
							Console.WriteLine(idiomas[16], segundaFecha.fecha.ToShortDateString(), fechaActual.fecha.ToShortDateString(), diferenciaAnio);
						}
						else
						{
							mensajeError =(idiomas[17]);
						}						
						break;
					case 5:
						if (leido)
						{
							diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(segundaFecha, fechaActual);
							Console.WriteLine(idiomas[18], segundaFecha.fecha.ToShortDateString(), fechaActual.fecha.ToShortDateString(), diferenciaDias);
						}
						else
						{
							mensajeError = (idiomas[19]);
						}
						break;
					case 6:
						if (leido)
						{
							diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
							Console.WriteLine(idiomas[20], primeraFecha.fecha.ToShortDateString(), segundaFecha.fecha.ToShortDateString(), diferenciaAnio);
						}
						else
						{
							mensajeError = (idiomas[21]);
						}
						break;
					case 7:
						if (leido)
						{
							diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
							Console.WriteLine(idiomas[22], primeraFecha.fecha.ToShortDateString(), segundaFecha.fecha.ToShortDateString(), diferenciaDias);
						}
						else
						{
							mensajeError = (idiomas[23]);
						}
						break;
					case 8:
						{
							idiomas = EscogerLenguaje();
							break;
						}
				}
				CSComprobaciones.Continuar(mensajeError,idiomas);

			} while (opcion != 9);
		}
	}
}
