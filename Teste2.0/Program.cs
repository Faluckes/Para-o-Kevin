using System;
using System.IO;
using System.Text;

namespace Teste2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var enderecoArquivo = "Testando.txt";
            var enderecoArquivo2 = "Bonus.txt";

            Console.WriteLine("Aperte enter para ver algo");
            Console.ReadLine();


            using (var fluxoDeArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);

                }
                Console.WriteLine("\nAperte Enter para ver o bonus!");

                Console.ReadLine();
            }
            using (var fluxoDeArquivo2 = new FileStream(enderecoArquivo2, FileMode.Open))
            using (var leitor2 = new StreamReader(fluxoDeArquivo2))
            {
                while (!leitor2.EndOfStream)
                {
                    var linha2 = leitor2.ReadLine();
                    Console.WriteLine(linha2);
                }


                Console.ReadLine();
            }
            static void EscreverBuffer(byte[] buffer, int bytelidos)
            {
                var utf8 = Encoding.UTF32;
                var texto = utf8.GetString(buffer, 0, bytelidos);




            }
        }
    }
}