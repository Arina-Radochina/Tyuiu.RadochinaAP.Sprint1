using Tyuiu.RadochinaAP.Sprint1.Task6.V14.Lib;

namespace Tyuiu.RadochinaAP.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        // Теперь CheckLowerCaseRusLetters прямо здесь:
        public static bool CheckLowerCaseRusLetters(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            foreach (char c in text)
            {
                if (c < 'а' || c > 'я') return false;
            }
            return true;
        }

        [TestMethod]
        public void ValidString_ReturnsTrue()
        {
            string strTest = "привет";
            string expected = "True";
            string actual = CheckLowerCaseRusLetters(strTest).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidString_ReturnsFalse()
        {
            string strTest = "Привет";
            string expected = "False";
            string actual = CheckLowerCaseRusLetters(strTest).ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}