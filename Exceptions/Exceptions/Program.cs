using System;
using Exceptions.Models;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try
            try
            {
             
                int num = 3;
                int num1 = 0;
                int num2 = num / num1;
                int[] numbers = new int[3];
                numbers[10] = 15;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            #endregion
            string name = "Lorem";
            string[] names = { "Aqil", "Lorem", "Xalilov" };
            Console.WriteLine(Libaraty.secim(name, names));
            Exception ex1 = new Exception("bu bir xetadir");
            throw ex1;



        }
    }
}
