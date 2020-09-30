using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamoBlazor.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using PrestamoBlazor.Models;

namespace PrestamoBlazor.BLL.Tests
{
    [TestClass()]
    public class PrestamoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoId = 0;
            prestamo.Fecha = DateTime.Now;
            prestamo.PersonaId = 1;
            prestamo.Concepto = "Salud";
            prestamo.Monto = 1000;
            prestamo.Balance = 1000;
            bool paso = PrestamoBLL.Guardar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = PrestamoBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos prestamo;
            prestamo = PrestamoBLL.Buscar(1);
            Assert.AreEqual(prestamo, prestamo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Prestamos>();
            lista = PrestamoBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = PrestamoBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }
    }
}