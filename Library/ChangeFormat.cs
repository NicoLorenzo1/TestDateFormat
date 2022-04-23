using System;

namespace DateFormat
{
    public class ChangeFormat
    {
        public static String changeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        /// <summary>
        /// Metodo que recibe la fecha en formato DD/MM/YYYY y retorna la fecha en formato MM-YYYY-DD
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string changeFormat2(string year)
        {
            return year.Substring(3, 2) + "-" + year.Substring(6) + "-" + year.Substring(0, 2);
        }

        /// <summary>
        /// Metodo que recibe la fecha en formato DD/MM/YYY y retorna la fecha en formato DD-YYYY-MM
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string changeFormat3(string year)
        {
            return year.Substring(0, 2) + "-" + year.Substring(6) + "-" + year.Substring(3, 2);
        }

        //string testDate4 = "1977-11-10";
        //string expected = "10/11/1977";
        public static string changeFormat4(string year)
        {
            return year.Substring(8) + "/" + year.Substring(5,6) + "/" + year.Substring(0, 4);
        }
    }
}