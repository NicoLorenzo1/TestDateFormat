using NUnit.Framework;

namespace DateFormat
{

    public class ChangeFormatTest
    {
        [SetUp]
        public void Setup()
        {

        }

        /// <summary>
        /// Test para probar el método "changeFormat" el cual se le ingresa la fecha en formato DD/MM//YYYY y la devuelve 
        /// en el formato YYYY-MM-DD.
        /// </summary>
        [Test]
        public void CorrectCHangeFormat1Test()
        {
            string testDate = "10/11/1977";
            string expected = "1977-11-10";
            Assert.AreEqual(expected, ChangeFormatClass.ChangeFormat(testDate));
        }

        /// <summary>
        /// Test para probar el método "changeFormat2" el cual se le ingresa la fecha en formato DD/MM//YYYY y la devuelve 
        /// en el formato MM-YYYY-DD.
        /// </summary>
        [Test]
        public void CorrectCHangeFormat2Test()
        {
            string testDate = "10/11/1977";
            string expected = "11-1977-10";
            Assert.AreEqual(expected, ChangeFormatClass.ChangeFormatMYD(testDate));
        }

        /// <summary>
        /// Test para probar el método "changeFormat3 el cual se le ingresa la fecha en formato DD/MM//YYYY y la devuelve 
        /// en el formato DD-YYYY-MM.
        /// </summary>
        [Test]
        public void CorrectCHangeFormat3Test()
        {
            string testDate = "10/11/1977";
            string expected = "10-1977-11";
            Assert.AreEqual(expected, ChangeFormatClass.ChangeFormatDYM(testDate));
        }

        /// <summary>
        ///Test para probar el método "changeFormat4" el cual se le ingresa una fecha en formato YYYY-MM-DD y la convierte al formato DD/MM/YYYY.
        /// </summary>
        [Test]
        public void CorrectCHangeFormat4Test()
        {
            string testDate4 = "1977-11-10";
            string expected = "10/11/1977";
            Assert.AreEqual(expected, ChangeFormatClass.ChangeFormatDMY(testDate4));
        }
    }
}