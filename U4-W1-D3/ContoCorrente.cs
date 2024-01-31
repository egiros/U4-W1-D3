using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D3
{
    internal class ContoCorrente
    {

        private bool contoAperto;   
        private int saldo;

        public ContoCorrente()  // costruttore della classe
        {
            contoAperto = false;
            saldo = 0;
        }


        // 1) Metodo Apertura del conto con un versamento iniziale di almeno 1000
        public bool ApriConto(int importoIniziale) 
        {
            if (!contoAperto && importoIniziale >= 1000) 
            {
                contoAperto = true;
                saldo += importoIniziale;
                return true; // Restituisce true se il conto viene aperto con successo
            }
            else
            {
                return false; // Restituisce false se il conto è già aperto o l'importo è inferiore ai 1000
            }
        }

        // 2) Metodo Versamento sul conto
        public bool Versamento(int importo)
        {
            if (contoAperto) //il versamento può essere effettuato solo se il conto è aperto, quindi true
            {
                saldo += importo;
                return true; // Restituisce true se il versamento viene effettuato con successo
            }
            else
            {
                return false; // Restituisce false se il conto non è aperto
            }
        }

        // 3) Metodo Prelievo dal conto
        public bool Prelievo(int importo)
        {
            if (contoAperto && saldo >= importo)
            {
                saldo -= importo;
                return true; // Restituisce true se il prelievo viene effettuato con successo
            }
            else
            {
                return false; // Restituisce false se il conto non è aperto o il saldo è insufficiente
            }
        }

        // Uso il metodo per ottenere il saldo del conto
        public int GetSaldo()
        {
            return saldo;
        }
    }

}
