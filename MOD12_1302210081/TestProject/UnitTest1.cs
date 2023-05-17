using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MOD12_1302210081.Test
{
    [TestClass]
    public class Form1Test
    {
        [TestMethod]
        public void CariTandaBilangan_InputNegatif_ReturnsNegatif()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            string result = form.CariTandaBilangan(-5);

            // Assert
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void CariTandaBilangan_InputPositif_ReturnsPositif()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            string result = form.CariTandaBilangan(5);

            // Assert
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void CariTandaBilangan_InputNol_ReturnsNol()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            string result = form.CariTandaBilangan(0);

            // Assert
            Assert.AreEqual("Nol", result);
        }
    }
}
