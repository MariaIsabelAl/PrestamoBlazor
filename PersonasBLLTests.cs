using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamoBlazor.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using PrestamoBlazor.Models;

namespace PrestamoBlazor.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Personas p = new Personas();
            bool paso = false;
            p.PersonaId = 0;
            p.Nombre = "Jose Alberto";
            p.Fecha = DateTime.Now;
            p.Cedula = "40225550022";
            p.Direccion = "Calle Duarte #50";
            p.Telefono = "8099637885";
            p.Balance = 0;
            paso = PersonasBLL.Guardar(p);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = PersonasBLL.Eliminar(1);
            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Personas personas;
            personas = PersonasBLL.Buscar(2);
            Assert.IsNotNull(personas);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Personas>();
            lista = PersonasBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = PersonasBLL.Existe(2);
            Assert.AreEqual(paso, true);
        }
    }
}