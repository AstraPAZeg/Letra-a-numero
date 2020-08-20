using Microsoft.VisualStudio.TestTools.UnitTesting;
using Número_a_letra.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumero2Letra_get()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int numero = 182;
            string esperado = "CIENTO OCHENTA Y DOS 00";

            //Act
            string resultado=literalController.literal_get(numero);
            //Assert
            Assert.AreEqual(esperado,resultado);
        }
        [TestMethod]
        public void TestNumero2Letra_post()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int numero = 182;
            string esperado = "CIENTO OCHENTA Y DOS 00";

            //Act
            string resultado = literalController.literal_post(numero);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
