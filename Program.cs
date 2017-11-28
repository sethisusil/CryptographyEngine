using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "+7bzHgG+ftsEws4oWFCg8sIMKz+/KiA7";
            string decryptPassword = password.Decrypt();
            Console.WriteLine("Decrypted Name:-   {0}", decryptPassword);
            Console.Read();
        }
    }
}