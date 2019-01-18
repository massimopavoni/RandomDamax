using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Magazzino_Massimo_Pavoni
{
    class Prodotto
    {
        private int codiceFornitore, codiceProdotto;
        private string nome;
        private double prezzoUnitario;
        private int quantitaInMagazzino, scortaMinima, quantitaBloccoOrdine;

        #region Proprietà
        public int CodiceFornitore => codiceFornitore;
        public int CodiceProdotto => codiceProdotto;
        public string Nome => nome;
        public double PrezzoUnitario => prezzoUnitario;
        public int QuantitaInMagazzino => quantitaInMagazzino;
        public int ScortaMinima => scortaMinima;
        public int QuantitaBloccoOrdine => quantitaBloccoOrdine;
        #endregion

        //contruttore
        public Prodotto(int _codiceFornitore, int _codiceProdotto, string _nome, double _prezzoUnitario,
            int _quantitaInMagazzino, int _scortaMinima, int _quantitaBloccoOrdine)
        {
            codiceFornitore = _codiceFornitore;
            codiceProdotto = _codiceProdotto;
            nome = _nome;
            prezzoUnitario = _prezzoUnitario;
            quantitaInMagazzino = _quantitaInMagazzino;
            scortaMinima = _scortaMinima;
            quantitaBloccoOrdine = _quantitaBloccoOrdine;
        }

        #region Metodi
        //vende prodotti
        public double Vendi(int _quantita)
        {
            if ((_quantita <= 0) || (_quantita > quantitaInMagazzino)) throw new ArgumentException("La quantità richiesta deve essere "
                + "maggiore di 0 e minore o uguale al numero di prodotti conservati in magazzino.");
            quantitaInMagazzino -= _quantita;
            return _quantita * prezzoUnitario;
        }
        //controlla scorta minima
        public Ordine ControllaScorta(int _numeroOrdiniPrecedenti)
        {
            if (quantitaInMagazzino < scortaMinima)
            {
                do
                {
                    quantitaInMagazzino += quantitaBloccoOrdine;
                    _numeroOrdiniPrecedenti++;
                } while (quantitaInMagazzino < scortaMinima);
            }
            //crea ordine da sostituire
            Fornitore _fornitoreProdotto = Magazzino.Fornitori.Find(_f => _f.Codice == codiceFornitore) as Fornitore;
            return new Ordine(codiceFornitore, _fornitoreProdotto.Cognome, _fornitoreProdotto.Nome, codiceProdotto,
                nome, quantitaBloccoOrdine, _numeroOrdiniPrecedenti);
        }
        #endregion
    }
}
