using inclui.edadfecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Inclui.EdadFechaTest
{
    [TestClass]
    public class EdadFechaTest
    {
        [TestMethod]
        public void HallarDiferenciaEnAnioFechasDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2010"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/12/2011"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void HallarDiferenciaEnDiasFechasDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2010"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/04/2021"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 4077;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void HallarDiferenciaEnAnioFechasAC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/07/2013"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/03/2015"),
                antesCristo = true
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void HallarDiferenciaEnDiasFechasAC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/03/2011"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2001"),
                antesCristo = true
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 3680;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }


        [TestMethod]
        public void HallarDiferenciaEnAnioFechasSinAnios()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/02/2001"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/2/2002"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void HallarDiferenciaEnDiasFechasSinDias()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/02/2001"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/2/2001"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void HallarDiferenciaEnAnioFechaACyFechaDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2001"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/12/2023"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4024;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void HallarDiferenciaEnDiasFechaACyFechaDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2001"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/12/2023"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 1469371;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
        [TestMethod]
        public void DiferenciasAnioBisiesto()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("28/2/2001"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void DiferenciasFebreroMarzoBisiesto()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("1/3/2003"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void DiferenciasAnioBisiesto2()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2004"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
        [TestMethod]
        public void DiferenciasAnioBisiesto3()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("28/2/2001"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2004"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void DiferenciasAnioBisiesto4()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("28/2/2003"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
        [TestMethod]
        public void DiferenciasAnioBisiestoAntesDeCristo()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("1/5/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("12/4/2003"),
                antesCristo = true
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4008;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
