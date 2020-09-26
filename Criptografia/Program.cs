using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do Programa!");

            string[] keys = File.ReadAllLines(@"C:\Users\Adm\Desktop\Faculdade\SegurançaDaInformação\Criptografia\Chaves_de_Criptografia.txt");

            var correctKeys = new List<string>();

            var monoBitTeste = new MonoBitTest();
            var pokerTest = new PokerTest();
            var theRunsTests = new TheRunsTest();
            var longRunTest = new LongRunTest();

            for (int i = 0; i < 20; i++)
            {
                var key = keys[i].Trim('\'');

                string binarystring = string.Join(string.Empty,
                  key.Select(
                    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                  )
                );

                Console.WriteLine($"Analisando a {i + 1}º chave");

                var isValidMonoBit = monoBitTeste.Validate(binarystring);
                Console.WriteLine($"Passou no teste do MonoBit: {isValidMonoBit}");

                var isValidPokerTest = pokerTest.Validate(binarystring);
                Console.WriteLine($"Passou no teste do Poker: {isValidPokerTest}");

                var isValidRunsTests = theRunsTests.Validate(binarystring);
                Console.WriteLine($"Passou no teste do The Runs Tests: {isValidRunsTests}");

                var isValidLongRun = longRunTest.Validate(binarystring);
                Console.WriteLine($"Passou no teste do Long Run: {isValidLongRun}");

                if(isValidMonoBit && isValidPokerTest && isValidRunsTests && isValidLongRun)
                {
                    correctKeys.Add((i + 1).ToString());
                }

                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }

            Console.WriteLine("Índice das keys que estão corretas:");

            foreach (var key in correctKeys)
            {
                Console.WriteLine(key.ToString());
            }
        }
    }
}
