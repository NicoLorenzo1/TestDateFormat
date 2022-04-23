using System;

namespace DateFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            string testDate4 = "1977-11-10";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat.changeFormat(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat.changeFormat2(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat.changeFormat3(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate4, ChangeFormat.changeFormat4(testDate4));


        }
    }
}
