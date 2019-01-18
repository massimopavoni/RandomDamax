using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produzione_Pezzi_Massimo_Pavoni
{
    class Pezzo
    {
        public enum Tipi : int { A = 2, B = 3, C = 5, D = 7 };
        private Tipi tipo;
        private int matricola;
        private double altezza;
        private double larghezza;
        private double profondita;
        public enum Qualita { ALTA_Q, BASSA_Q, SCARTO };
        private Qualita qualitaPezzo;

        #region Proprietà
        public Tipi Tipo => tipo;
        public int Matricola => matricola;
        public double Altezza => altezza;
        public double Larghezza => larghezza;
        public double Profondita => profondita;
        public Qualita QualitaPezzo => qualitaPezzo;
        #endregion

        //costruttore
        public Pezzo(Tipi _tipo, int _matricola, double _altezza, double _larghezza, double _profondita)
        {
            tipo = _tipo;
            matricola = _matricola;
            altezza = _altezza;
            larghezza = _larghezza;
            profondita = _profondita;
        }

        internal void ControllaQualita()
        {
            double _altezzaTipo = 0;
            double _larghezzaTipo = 0;
            double _profonditaTipo = 0;
            //inizializzazione misure per tipo
            switch (tipo)
            {
                case Tipi.A:
                    _altezzaTipo = 10;
                    _larghezzaTipo = 15;
                    _profonditaTipo = 20;
                    break;
                case Tipi.B:
                    _altezzaTipo = 14;
                    _larghezzaTipo = 13;
                    _profonditaTipo = 28;
                    break;
                case Tipi.C:
                    _altezzaTipo = 17;
                    _larghezzaTipo = 22;
                    _profonditaTipo = 55;
                    break;
                case Tipi.D:
                    _altezzaTipo = 105;
                    _larghezzaTipo = 152;
                    _profonditaTipo = 207;
                    break;
            }
            if (((altezza <= _altezzaTipo * (100 + (int)tipo) / 100) && (altezza >= _altezzaTipo * (100 - (int)tipo) / 100)) &&
                ((larghezza <= _larghezzaTipo * (100 + (int)tipo) / 100) && (larghezza >= _larghezzaTipo * (100 - (int)tipo) / 100)) &&
                ((profondita <= _profonditaTipo * (100 + (int)tipo) / 100) && (profondita >= _profonditaTipo * (100 - (int)tipo) / 100)))
            {
                if (((altezza <= _altezzaTipo * 100.5 / 100) && (altezza >= _altezzaTipo * 99.5 / 100)) &&
                    ((larghezza <= _larghezzaTipo * 100.5 / 100) && (larghezza >= _larghezzaTipo * 99.5 / 100)) &&
                    ((profondita <= _profonditaTipo * 100.5 / 100) && (profondita >= _profonditaTipo * 99.5 / 100)))
                {
                    qualitaPezzo = Qualita.ALTA_Q;
                }
                else
                {
                    qualitaPezzo = Qualita.BASSA_Q;
                }
            }
            else
            {
                qualitaPezzo = Qualita.SCARTO;
            }
        }
    }
}
