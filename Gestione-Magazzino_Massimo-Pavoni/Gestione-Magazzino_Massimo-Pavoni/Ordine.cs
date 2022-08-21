using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Magazzino_Massimo_Pavoni
{
    class Ordine
    {
        private int codiceFornitore;
        private string cognomeFornitore, nomeFornitore;
        private int codiceProdotto;
        private string nomeProdotto;
        private int quantitaBloccoOrdine, numeroOrdini;

        #region Proprietà
        public int CodiceFornitore => codiceFornitore;
        public string CognomeFornitore => cognomeFornitore;
        public string NomeFornitore => nomeFornitore;
        public int CodiceProdotto => codiceProdotto;
        public string NomeProdotto => nomeProdotto;
        public int QuantitaBloccoOrdine => quantitaBloccoOrdine;
        public int NumeroOrdini => numeroOrdini;
        #endregion

        //costruttore
        public Ordine(int _codiceFornitore, string _cognomeFornitore, string _nomeFornitore,
            int _codiceProdotto, string _nomeProdotto, int _quantitaBloccoOrdine, int _numeroOrdini)
        {
            codiceFornitore = _codiceFornitore;
            cognomeFornitore = _cognomeFornitore;
            nomeFornitore = _nomeFornitore;
            codiceProdotto = _codiceProdotto;
            nomeProdotto = _nomeProdotto;
            quantitaBloccoOrdine = _quantitaBloccoOrdine;
            numeroOrdini = _numeroOrdini;
        }
    }
}
