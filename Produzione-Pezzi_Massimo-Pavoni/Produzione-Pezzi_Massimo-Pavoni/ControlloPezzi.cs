using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Produzione_Pezzi_Massimo_Pavoni
{
    static class ControlloPezzi
    {
        private static List<Pezzo> pezziTotali = new List<Pezzo>();
        private static List<Pezzo> pezziALTA_Q = new List<Pezzo>();
        private static List<Pezzo> pezziBASSA_Q = new List<Pezzo>();
        private static List<Pezzo> pezziSCARTO = new List<Pezzo>();
        private static int numeroPezzi;
        private static string percorsoOrigine = @"Produzione.csv";
        private static string percorsoALTA_Q = @"AltaQualita.csv";
        private static string percorsoBASSA_Q = @"BassaQualita.csv";
        private static string percorsoSCARTO = @"Scarto.csv";

        #region Proprietà
        public static List<Pezzo> PezziTotali => pezziTotali;
        public static List<Pezzo> PezziALTA_Q => pezziALTA_Q;
        public static List<Pezzo> PezziBASSA_Q => pezziBASSA_Q;
        public static List<Pezzo> PezziSCARTO => pezziSCARTO;
        #endregion

        #region Metodi
        //caricamento dati da file csv
        internal static void CaricaDati()
        {
            if (File.Exists(percorsoOrigine))
            {
                string[] _infoPezzo = new string[5];
                foreach (string _line in File.ReadAllLines(percorsoOrigine))
                {
                    if(!int.TryParse(_line, out numeroPezzi))
                    {
                        _infoPezzo = _line.Split('|');
                        Pezzo.Tipi _tipoPezzo = Pezzo.Tipi.A;
                        Enum.TryParse(_infoPezzo[0], out _tipoPezzo);
                        Pezzo _p = new Pezzo(_tipoPezzo,
                            Convert.ToInt32(_infoPezzo[1]), Convert.ToDouble(_infoPezzo[2].Replace(",", ".")),
                            Convert.ToDouble(_infoPezzo[3].Replace(",", ".")), Convert.ToDouble(_infoPezzo[4].Replace(",", ".")));
                        pezziTotali.Add(_p);
                    }
                }
            }
        }
        //controllo di qualità dei pezzi
        internal static void ControllaPezzi()
        {
            foreach(Pezzo _p in pezziTotali)
            {
                _p.ControllaQualita();
            }
            pezziALTA_Q = pezziTotali.Where(_p => _p.QualitaPezzo == Pezzo.Qualita.ALTA_Q).ToList().OrderBy(_p => _p.Matricola).ToList();
            pezziBASSA_Q = pezziTotali.Where(_p => _p.QualitaPezzo == Pezzo.Qualita.BASSA_Q).ToList().OrderBy(_p => _p.Matricola).ToList();
            pezziSCARTO = pezziTotali.Where(_p => _p.QualitaPezzo == Pezzo.Qualita.SCARTO).ToList().OrderBy(_p => _p.Matricola).ToList();
        }
        //salvataggio dati in file csv
        internal static void SalvaDati()
        {
            //file pezzi ALTA_Q
            StreamWriter _writerALTA_Q = new StreamWriter(percorsoALTA_Q);
            _writerALTA_Q.WriteLine(pezziALTA_Q.Count);
            foreach (Pezzo _p in pezziALTA_Q)
            {
                _writerALTA_Q.WriteLine(_p.Tipo + "|" + _p.Matricola + "|" + _p.Altezza + "|" + _p.Larghezza + "|" + _p.Profondita);
            }
            _writerALTA_Q.Close();
            //file pezzi BASSA_Q
            StreamWriter _writerBASSA_Q = new StreamWriter(percorsoBASSA_Q);
            _writerBASSA_Q.WriteLine(pezziBASSA_Q.Count);
            foreach (Pezzo _p in pezziBASSA_Q)
            {
                _writerBASSA_Q.WriteLine(_p.Tipo + "|" + _p.Matricola + "|" + _p.Altezza + "|" + _p.Larghezza + "|" + _p.Profondita);
            }
            _writerBASSA_Q.Close();
            //file pezzi SCARTO
            StreamWriter _writerSCARTO = new StreamWriter(percorsoSCARTO);
            _writerSCARTO.WriteLine(pezziSCARTO.Count);
            foreach (Pezzo _p in pezziSCARTO)
            {
                _writerSCARTO.WriteLine(_p.Tipo + "|" + _p.Matricola + "|" + _p.Altezza + "|" + _p.Larghezza + "|" + _p.Profondita);
            }
            _writerSCARTO.Close();
        }
        #endregion
    }
}
