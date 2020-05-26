using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int k;
            try
			{
                Console.WriteLine("Escriba un numero: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba un numero: ");
                y = int.Parse(Console.ReadLine());
                k = x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Pulse para continuar...");
            }


        }
    }
}
