using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptProject
{
    class Program
    {
        private const string codeActionEncrypt = "ENCRYPT";
        private const string codeActionDecrypt = "DECRYPT";

        static void Main(string[] args)
        {
            var action = args[0];
            if (action!= codeActionEncrypt && action != codeActionDecrypt)
                throw new Exception("Incorrect action!");

            var inputFile = args[1];
            if (string.IsNullOrEmpty(inputFile))
                throw new Exception("Empty input file!");

            var outputFile = args[2];
            if (string.IsNullOrEmpty(outputFile))
                throw new Exception("Empty output file!");

            var password = args[3];
            if (string.IsNullOrEmpty(password))
                throw new Exception("Empty password!");

            var encryptor = new MyEncryptor(password);

            if (action.ToUpper() == codeActionEncrypt)
                encryptor.Encrypt(inputFile, outputFile);
            if (action.ToUpper() == codeActionDecrypt)
                encryptor.Decrypt(inputFile, outputFile);

            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
