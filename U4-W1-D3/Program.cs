using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                ContoCorrente conto = new ContoCorrente();

                Console.WriteLine("Benvenuto in EPIC-BANCA! \nSeleziona un'opzione: \n\n");
                Console.WriteLine("1. Apri conto");
                Console.WriteLine("2. Versamento");
                Console.WriteLine("3. Prelievo");
                Console.WriteLine("4. Esci");


                bool esci = false;  // questa variabile serve per uscire dal ciclo

                while (!esci)
                {
                   

                    Console.Write("\n\nInserisci l'opzione desiderata: \n");
                    int scelta = Convert.ToInt32(Console.ReadLine());

                    switch (scelta)
                    {
                        case 1:
                            Console.Write("\nInserisci l'importo iniziale: ");
                            int importoIniziale = Convert.ToInt32(Console.ReadLine());

                            if (conto.ApriConto(importoIniziale))
                            {
                                Console.WriteLine("\nConto aperto con successo.");
                            }
                            else
                            {
                                Console.WriteLine("\nImpossibile aprire il conto. \nControlla l'importo iniziale o verifica se il conto è già aperto.");
                            }
                            break;

                        case 2:
                            Console.Write("\nInserisci l'importo da versare: ");
                            int importoVersamento = Convert.ToInt32(Console.ReadLine());

                            if (conto.Versamento(importoVersamento))
                            {
                                Console.WriteLine($"\nVersamento di {importoVersamento} euro effettuato. \nNuovo saldo: {conto.GetSaldo()} euro.");
                            }
                            else
                            {
                                Console.WriteLine("\nImpossibile effettuare il versamento. \nControlla se il conto è aperto.");
                            }
                            break;

                        case 3:
                            Console.Write("\nInserisci l'importo da prelevare: ");
                            int importoPrelievo = Convert.ToInt32(Console.ReadLine());

                            if (conto.Prelievo(importoPrelievo))
                            {
                                Console.WriteLine($"\nPrelievo di {importoPrelievo} euro effettuato. Nuovo saldo: {conto.GetSaldo()} euro.");
                            }
                            else
                            {
                                Console.WriteLine("\nImpossibile effettuare il prelievo. Controlla se il conto è aperto o se il saldo è sufficiente.");
                            }
                            break;

                        case 4:
                            esci = true;
                            Console.WriteLine("\nArrivederci!");
                            break;

                        default:
                            Console.WriteLine("\nOpzione non valida. Riprova.");
                            break;
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
