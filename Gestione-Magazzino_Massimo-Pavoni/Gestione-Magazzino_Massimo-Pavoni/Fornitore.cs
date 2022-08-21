using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Magazzino_Massimo_Pavoni
{
    class Fornitore
    {
        private int codice;
        private string ragioneSociale, cognome, nome, ruolo;

        #region Proprietà
        public int Codice => codice;
        public string RagioneSociale => ragioneSociale;
        public string Cognome => cognome;
        public string Nome => nome;
        public string Ruolo => ruolo;
        #endregion

        //costruttore
        public Fornitore(int _codice, string _ragioneSociale, string _cognome, string _nome, string _ruolo)
        {
            codice = _codice;
            ragioneSociale = _ragioneSociale;
            cognome = _cognome;
            nome = _nome;
            ruolo = _ruolo;
        }
    }
}
