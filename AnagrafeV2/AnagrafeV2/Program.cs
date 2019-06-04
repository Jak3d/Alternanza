using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagrafeV2
{

    class Program
    {
        static void Main(string[] args)
        {
            #region variabili
            string scelta;
            string loop="y";
            string check = "";
            string nome, cognome;
            string ricerca = "";
            string continua;
            int nPersone;
            #endregion

            List<persona> listP = new List<persona>();

            while (loop == "y" || loop == "Y"){
                Console.Write("Premere I per inserire dati, premere D per visualizzare i dati, E per modificare i dati \n");
                scelta = Console.ReadLine();
                #region inserimento
                while (scelta == "i" || scelta == "I") {
                    Console.WriteLine("Inserire numero persone da aggiungere"); // controllo dato > 0 
                    nPersone = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < nPersone; i++)
                    {
                        listP.Add( new persona { nome = "", cognome = "", CF = ""});
                    }
                    for ( int i = 0; i < listP.Count; i++)
                    {
                        Console.WriteLine("Inserire Nome");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserire Cognome");
                        cognome = Console.ReadLine();
                        Console.WriteLine("Inserire Codice Fiscale");
                        check = Console.ReadLine();
                        ricerca = check;
                        if (listP.Exists(x => x.CF == ricerca))
                        {
                            Console.WriteLine("Codice Fiscale già presente");
                        }
                        else
                        {
                            listP[i].nome = nome;
                            listP[i].cognome = cognome;
                            listP[i].CF = check;
                        }
                        
                    }
                    Console.WriteLine("Inserire nuova persona? Y/N");
                        continua = Console.ReadLine();
                        if (continua == "y" || continua == "Y")
                        {
                            
                        }
                        else
                        {
                            scelta = "Exit";
                        }
                    


                }
                #endregion
                if (scelta == "D" || scelta == "d")
                {
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Nome", "Cognome", "CF"));
                    Console.WriteLine("-------------------------------");
                    foreach (persona dato in listP)
                    {
                        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", dato.nome, dato.cognome, dato.CF));
                    }
                }
                Console.WriteLine("Tornare alla scelta? Y/N");
                loop = Console.ReadLine();
            }
        }
    }
}
