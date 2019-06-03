using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Anagrafe
{
    class Program
    {
        static void Main(string[] args)

        {
            string scelta;
            string[] nome;
            string[] cognome;
            string[] CF;
            int i;
            string prova;
            Console.Write("Premere I per inserire dati, premere D per visualizzare i dati, E per modificare i dati \n");
            scelta = Console.ReadLine();
            if (scelta == "I")
            {
                Console.WriteLine("Inserire informazioni prova");
                prova = Console.ReadLine();



                Console.WriteLine("Inserire numero di persone");
                i = Convert.ToInt32(Console.ReadLine());
                for (int n = 0; n < i; n++)
                {
                    Console.WriteLine("Inserire nome");
                    nome = new string[i];
                    cognome = new string[i];
                    CF = new string[i];
                    nome[n] = Console.ReadLine();
                    Console.WriteLine("Inserire cognome");
                    cognome[n] = Console.ReadLine();
                    Console.WriteLine("Inserire Codice Fiscale");
                    CF[n] = Console.ReadLine();



                    //Fase sostituzione dati

                    string text = File.ReadAllText(@"C:\Users\Stage1\Desktop\Prove Stage\Dati.txt");
                    text = text.Replace("some text", "new value");
                    File.WriteAllText("test.txt", text);

                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Nome", "Cognome", "CF"));
                    Console.WriteLine("-------------------------------");
                    using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@"C:\Users\Stage1\Desktop\Prove Stage\Dati.txt", true))
                    {
                        file.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", nome[n], cognome[n], CF[n]));
                    }
                    for (int d = 0; d <= n; d++)
                    {
                        int[] dati;
                        dati = new int[i];
                        dati[d] = d;

                        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", nome[d], cognome[d], CF[d]));
                    }
                }

                


                Console.WriteLine("Press enter to close...");
                Console.ReadLine();


                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Stage1\Desktop\Prove Stage\testo.txt", true))
                {
                    file.WriteLine("Prova:" + prova + " " + string.Format("{0:HH:mm:ss tt}", DateTime.Now));

                }


                // cancellare i dati nel file seguente a seconda della richiesta e della aggiunta di nuovi dati

            }
            else if (scelta == "D")
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Nome", "Cognome", "CF"));
                Console.WriteLine("-------------------------------");
                string[] lines = File.ReadAllLines(@"C:\Users\Stage1\Desktop\Prove Stage\Dati.txt");

                foreach (string line in lines)
                Console.WriteLine(line);

                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
            else if (scelta == "E")
            {
                Console.WriteLine("Scegliere i dati da modificare");
                int delete;
                
                string[] lines = File.ReadAllLines(@"C:\Users\Stage1\Desktop\Prove Stage\Dati.txt");

                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Nome", "Cognome", "CF"));
                Console.WriteLine("-------------------------------");
                foreach (string line in lines)
                    Console.WriteLine(line);
                delete = Convert.ToInt32(Console.ReadLine());
                string newNome;
                Console.WriteLine("Inserire nuovo nome");
                newNome = Console.ReadLine();
                string newCognome;
                Console.WriteLine("Inserire nuovo cognome");
                newCognome = Console.ReadLine();
                string newCF;
                Console.WriteLine("Inserire nuovo Codice Fiscale");
                newCF = Console.ReadLine();
                string finalString;
                string conferma;
                Console.WriteLine("Confermare?");
                conferma = Console.ReadLine();
                if (conferma == "si")
                {
                    finalString = String.Format("{0,-10} | {1,-10} | {2,5}", newNome, newCognome, newCF);

                    string[] arrLine = File.ReadAllLines(@"C:\Users\Stage1\Desktop\Prove Stage\Dati.txt");
                    arrLine[delete-1] = finalString;
                    File.WriteAllLines(@"C:\Users\Stage1\Desktop\Prove Stage\Dati.txt", arrLine);
                }

                
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
           


        }
    }
    
}
