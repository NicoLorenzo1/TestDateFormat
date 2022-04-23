using System;

namespace DateFormat
{
    public class ChangeFormatClass
    {

        /// <summary>
        /// Método "changeFormat" que recibe la fecha en el formato DD-MM-YYYY y la devuelve en el formato YYYY-MM-DD
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        /// <summary>
        /// Metodo "changeFormatMYD" que recibe la fecha en formato DD/MM/YYYY y retorna la fecha en formato MM-YYYY-DD
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string ChangeFormatMYD(string year)
        {
            return year.Substring(3, 2) + "-" + year.Substring(6) + "-" + year.Substring(0, 2);
        }

        /// <summary>
        /// Metodo "changeFormatDYM" que recibe la fecha en formato DD/MM/YYY y retorna la fecha en formato DD-YYYY-MM
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string ChangeFormatDYM(string year)
        {
            return year.Substring(0, 2) + "-" + year.Substring(6) + "-" + year.Substring(3, 2);
        }


        /// <summary>
        /// La funcón del método "changeFormatDMY" es convertir la fecha del formato YYYY-MM-DD al formato DD/MM/YYYY
        /// en este caso se uso la función "Split" para hacer un metodo diferente a los anteriores.
        /// <param name="year"></param>
        /// <returns></returns>
        public static string ChangeFormatDMY(string year)
        {
            String[] testDate4 = year.Split("-");
            Array.Reverse(testDate4);
            return string.Join("/", testDate4);

        }
    }
}