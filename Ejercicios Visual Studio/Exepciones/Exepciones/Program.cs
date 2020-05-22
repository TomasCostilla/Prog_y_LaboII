using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    class Program
    {
        static void Main(string[] args)
        {

			try
			{
                Console.WriteLine("Escriba un numero: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba un numero: ");
                int y = int.Parse(Console.ReadLine());
                int k = x / y;
            }
			catch (FormatException e)
			{
                Console.WriteLine(e.Message);
			}
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
