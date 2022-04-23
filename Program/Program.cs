using System;

namespace DateFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            string testDate4 = "1977-11-10";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormatClass.ChangeFormat(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormatClass.ChangeFormatMYD(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormatClass.ChangeFormatDYM(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate4, ChangeFormatClass.ChangeFormatDMY(testDate4));


        }
    }
}
