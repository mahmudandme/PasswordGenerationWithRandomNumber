using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
           int length =  Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] symbol = new[] {33, 35,36,37,38,42,95};
            StringWriter stringWriter = new StringWriter();
            for (int i = length; i > 0; i--)
            {

                if (rnd.Next(i, length) == 2)
                {
                    stringWriter.Write((char)rnd.Next(65, 91));
                }
                else if (rnd.Next(i, length) == 3)
                {
                    stringWriter.Write((char)rnd.Next(97, 123));
                }
                else if (rnd.Next(i, length) == 4)
                {
                    stringWriter.Write((char)rnd.Next(48, 58));
                }
                else if (rnd.Next(i, length) == 5)
                {
                    stringWriter.Write((char)rnd.Next(65, 97));
                }
                else
                {
                    stringWriter.Write((char)symbol[rnd.Next(0, 7)]);
                }

                //if (rnd.Next(1,5)==1)
                //{
                //    stringWriter.Write((char)rnd.Next(65,91));
                //}
                //else if (rnd.Next(1, 5) == 2)
                //{
                //    stringWriter.Write((char)rnd.Next(97, 123));  
                //}
                //else if (rnd.Next(1, 5) == 3)
                //{
                //    stringWriter.Write((char)rnd.Next(48,58));
                //}
                //else if (rnd.Next(1, 5) == 4)
                //{
                //    stringWriter.Write((char)rnd.Next(65, 97));
                //}
                //else
                //{
                //    stringWriter.Write((char)symbol[rnd.Next(0,7)]);
                //}
            }
            stringWriter.Write(rnd.Next(0,9));
            stringWriter.Write((char)rnd.Next(65,97));
            Console.WriteLine(stringWriter.ToString());
            Console.ReadKey();
        }
    }
}
