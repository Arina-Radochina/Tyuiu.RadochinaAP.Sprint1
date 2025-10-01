using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RadochinaAP.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            foreach (char c in text)
            {
                if (c < 'а' || c > 'я') return false;
            }
            return true;
        }
    }
}
