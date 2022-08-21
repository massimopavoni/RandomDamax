using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gestione_Magazzino_Massimo_Pavoni
{
    static class Magazzino
    {
        private static string percorsoFornitori = @"Fornitori.csv";
        private static List<Fornitore> fornitori = new List<Fornitore>();
        private static int numeroFornitori = 0;
        private static string percorsoProdotti = @"Prodotti.csv";
        private static List<Prodotto> prodotti = new List<Prodotto>();
        private static int numeroProdotti = 0;
        private static List<Ordine> ordiniTotali = new List<Ordine>();
        private static int numeroOrdiniTotali = 0;

        #region Proprietà
        public static List<Fornitore> Fornitori => fornitori;
        public static int NumeroFornitori => numeroFornitori;
        public static List<Prodotto> Prodotti => prodotti;
        public static int NumeroProdotti => numeroProdotti;
        public static List<Ordine> OrdiniTotali => ordiniTotali;
        public static int NumeroOrdiniTotali => numeroOrdiniTotali;
        #endregion

        #region Metodi
        //carica dati
        internal static void CaricaDati()
        {
            if (File.Exists(percorsoFornitori)) //se c'è
            {
                string[] _infoFornitore = new string[5];
                foreach (string _line in File.ReadAllLines(percorsoFornitori).Skip(1)) //da Fornitori.csv saltando intestazione
                {
                    _infoFornitore = _line.Split('|');
                    fornitori.Add(new Fornitore(Convert.ToInt32(_infoFornitore[0]), _infoFornitore[1],
                        _infoFornitore[2], _infoFornitore[3], _infoFornitore[4]));
                    numeroFornitori++;
                }
                fornitori.OrderBy(_f => _f.Codice); //ordinati per codice
            }
            if (File.Exists(percorsoProdotti)) //se c'è
            {
                string[] _infoProdotto = new string[7];
                foreach (string _line in File.ReadAllLines(percorsoProdotti).Skip(1)) //da Prodotti.csv saltando intestazione
                {
                    _infoProdotto = _line.Split('|');
                    prodotti.Add(new Prodotto(Convert.ToInt32(_infoProdotto[0]), Convert.ToInt32(_infoProdotto[1]),
                        _infoProdotto[2], Convert.ToDouble(_infoProdotto[3].Replace(',', '.')), Convert.ToInt32(_infoProdotto[4]),
                        Convert.ToInt32(_infoProdotto[5]), Convert.ToInt32(_infoProdotto[6])));
                    numeroProdotti++;
                }
                prodotti.OrderBy(_p => _p.CodiceProdotto); //ordinati per codiceProdotto
            }
            string _percorsoOrdiniFornitore;
            foreach(Fornitore _f in fornitori) //per ogni fornitore
            {
                _percorsoOrdiniFornitore = @"Ordini/Ordini_Fornitore-" + _f.Codice + "-" + _f.Cognome + "-" + _f.Nome + ".csv";
                if (File.Exists(_percorsoOrdiniFornitore)) //se c'è
                {
                    string[] _infoOrdine = new string[7];
                    foreach (string _line in File.ReadAllLines(_percorsoOrdiniFornitore).Skip(1)) //da Ordini_Fornitore-Cognome-Nome-[Codice].csv
                    {
                        _infoOrdine = _line.Split('|');
                        ordiniTotali.Add(new Ordine(_f.Codice, _f.Cognome, _f.Nome, Convert.ToInt32(_infoOrdine[0]),
                            _infoOrdine[1], Convert.ToInt32(_infoOrdine[2]), Convert.ToInt32(_infoOrdine[3])));
                        numeroOrdiniTotali++;
                    }
                }
            }
            ordiniTotali = ordiniTotali.OrderBy(_o => _o.CodiceProdotto).ToList(); //ordinati per codiceProdotto
        }
        //aggiunge fornitore
        public static void AggiungiFornitore(string _ragioneSociale, string _cognome, string _nome, string _ruolo)
        {
            if (_cognome.Equals("") || _nome.Equals("") || _ruolo.Equals(""))
                throw new ArgumentException("Il nuovo fornitore deve avere obbligatoriamente un cognome, un nome e un ruolo.");
            fornitori.Add(new Fornitore(fornitori[numeroFornitori - 1].Codice + 1, _ragioneSociale, _cognome, _nome, _ruolo));
        }
        //aggiunge prodotto
        public static void AggiungiProdotto(int _codiceFornitore, string _nome, double _prezzoUnitario,
            int _quantitaInMagazzino, int _scortaMinima, int _quantitaBloccoOrdine)
        {
            if (_nome.Equals("") || _prezzoUnitario <= 0 || _quantitaInMagazzino <=0 || _scortaMinima <= 0 || _quantitaBloccoOrdine <= 0)
                throw new ArgumentException("Il nuovo prodotto deve avere obbligatoriamente un nome, inoltre il prezzo, " +
                    "la quantità in magazzino, di scorta minima e di blocco ordine devono essere maggiori di 0.");
            prodotti.Add(new Prodotto(_codiceFornitore, prodotti[numeroProdotti - 1].CodiceProdotto + 1,
                _nome, _prezzoUnitario, _quantitaInMagazzino, _scortaMinima, _quantitaBloccoOrdine));
        }
        //controlla scorte minime prodotti
        internal static void ControllaScorte()
        {
            foreach (Prodotto _p in prodotti)
            {
                if (ordiniTotali.Exists(_o => _o.CodiceProdotto == _p.CodiceProdotto)) //se sono già stati fatti ordini
                {
                    Ordine _ordine = ordiniTotali.Find(_o => _o.CodiceProdotto == _p.CodiceProdotto) as Ordine;
                    ordiniTotali[ordiniTotali.IndexOf(_ordine)] = _p.ControllaScorta(_ordine.NumeroOrdini); //sostituisce esistente
                }
                else
                    ordiniTotali.Add(_p.ControllaScorta(0)); //altrimenti aggiunta
            }
            ordiniTotali.OrderBy(_o => _o.CodiceProdotto); //riordina per codiceProdotto
        }
        //salva modifiche a Fornitori.csv e Prodotti.csv e crea file ordini
        internal static void SalvaDati()
        {
            StreamWriter _writer;
            _writer = new StreamWriter(percorsoFornitori); //aggiorna fornitori
            _writer.WriteLine("COD|RS|COGNOME|NOME|RUOLO");
            foreach (Fornitore _f in fornitori)
                _writer.WriteLine(_f.Codice + "|" + _f.RagioneSociale + "|" + _f.Cognome + "|" + _f.Nome + "|" + _f.Ruolo);
            _writer.Close();
            _writer = new StreamWriter(percorsoProdotti); //aggiorna prodotti
            _writer.WriteLine("COD_FOR|COD_PRO|DENOMINAZIONE|PREZZO|QTA|SCORTA_MIN|QTA_BLO_ORD");
            foreach (Prodotto _p in prodotti)
            {
                _writer.WriteLine(_p.CodiceFornitore + "|" + _p.CodiceProdotto + "|" + _p.Nome + "|" + _p.PrezzoUnitario + "|" +
                    _p.QuantitaInMagazzino + "|" + _p.ScortaMinima + "|" + _p.QuantitaBloccoOrdine);
            }
            _writer.Close();
            foreach (Fornitore _f in fornitori) //per ogni fornitore
            {
                _writer = new StreamWriter(@"Ordini/Ordini_Fornitore-" + _f.Codice + "-" + _f.Cognome + "-" + _f.Nome + ".csv"); //crea file ordini
                _writer.WriteLine("COD_PRO|NOME_PRO|QTA_BLO_ORD|NUM_ORD");
                foreach (Ordine _o in ordiniTotali.Where(_o => _o.CodiceFornitore == _f.Codice).ToList()) //seleziona ordini del fornitore esaminato
                    _writer.WriteLine(_o.CodiceProdotto + "|" + _o.NomeProdotto + "|" + _o.QuantitaBloccoOrdine + "|" + _o.NumeroOrdini);
                _writer.Close();
            }
        }
        #endregion
    }
}
