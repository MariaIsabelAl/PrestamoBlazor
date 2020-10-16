using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamoBlazor.BLL;
using PrestamoBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamoBlazorTests.BLL
{
    [TestClass()]
    public class MoraBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Moras mora = new Moras();
            mora.MoraId = 0;
            mora.Fecha = DateTime.Now;
            mora.Total = 10;
            mora.MoraDetalles.Add(new MoraDetalles
            {
                MoraDetalleId = 0,
                MoraId = mora.MoraId,
                PrestamoId = 1,
                Valor = 10
            });

            Assert.IsTrue(MoraBLL.Guardar(mora));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Moras mora;
            mora = MoraBLL.Buscar(1);
            Assert.IsNotNull(mora);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Moras>();
            lista = MoraBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = MoraBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = MoraBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }
    }
}
