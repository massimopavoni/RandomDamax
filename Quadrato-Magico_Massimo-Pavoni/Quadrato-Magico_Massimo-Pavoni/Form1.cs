using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadrato_Magico_Massimo_Pavoni
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            t = new TextBox[] { t0, t1, t2, t3, t4, t5, t6, t7, t8 }; //inizializzazione vettore textbox
        }

        private TextBox[] t; //dichiarazione vettore textbox
        int[] q; //dichiarazione vettore quadrato
        int v; //variabile appoggio
        int cm; //dichiarazione costante magica

        private void via_Click(object sender, EventArgs e) //pulsante nuovo quadrato
        {
            via.Enabled = false; //blocco via
            q = new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 }; //inizializzazione vettore quadrato
            for (int c = 0; c < 9; c++) //blocco textbox
            {
                t[c].Enabled = false;
            }
            Random r = new Random(); //variabile trasformazioni casuali
            trasformag(r.Next(0, 8)); //richiamo con numero random funzione trasformazioni geometriche
            trasformam(r.Next(0, 3)); //richiamo con numero random funzione trasformazioni matematiche
            for(int c = 0; c < 9; c++) //inizializzazione valori quadrato magico trasformato
            {
                t[c].Text = Convert.ToString(q[c]);
            }
            tc.Text = Convert.ToString(cm); //assegnamento costante magica textbox corrispondente
            inizio();
        }

        private void inizio() //funzione preparazione gioco
        {
            int[] vcc = new int[] { 0, 0, 0, 0, 0 }; //vettore appoggio
            Random rrr = new Random(); //variabile textbox casuale
            for(int c = 0; c < 5; c++) //scelta casuale textbox vuote
            {
                vcc[c] = rrr.Next(0, 9);
                if (!((vcc[c] != vcc[(c + 1) % 5]) && (vcc[c] != vcc[(c + 2) % 5]) && (vcc[c] != vcc[(c + 3) % 5]) && (vcc[c] != vcc[(c + 4) % 5]))) //verifica textbox vuotate
                {
                    vcc[c] = -1;
                    c--;
                }
                else
                {
                    t[vcc[c]].Text = "";
                    t[vcc[c]].Enabled = true;
                }
            }
        }

        private void trasformag(int r) //funzione trasformazioni geometriche
        {
            switch (r)
            {
                case 0: //nessuna
                    break;
                case 1: //90° oraria
                    v = q[0];
                    q[0] = q[6];
                    q[6] = q[8];
                    q[8] = q[2];
                    q[2] = v;
                    v = q[1];
                    q[1] = q[3];
                    q[3] = q[7];
                    q[7] = q[5];
                    q[5] = v;
                    break;
                case 2: //180° oraria
                    v = q[0];
                    q[0] = q[8];
                    q[8] = v;
                    v = q[2];
                    q[2] = q[6];
                    q[6] = v;
                    v = q[1];
                    q[1] = q[7];
                    q[7] = v;
                    v = q[3];
                    q[3] = q[5];
                    q[5] = v;
                    break;
                case 3: //270° oraria
                    v = q[0];
                    q[0] = q[2];
                    q[2] = q[8];
                    q[8] = q[6];
                    q[6] = v;
                    v = q[1];
                    q[1] = q[5];
                    q[5] = q[7];
                    q[7] = q[3];
                    q[3] = v;
                    break;
                case 4: //simmetria orizzontale
                    for(int c = 0; c < 3; c++)
                    {
                        v = q[c];
                        q[c] = q[c + 6];
                        q[c + 6] = v;
                    }
                    break;
                case 5: //simmetria verticale
                    for(int c = 0; c < 7; c += 3)
                    {
                        v = q[c];
                        q[c] = q[c + 2];
                        q[c + 2] = v;
                    }
                    break;
                case 6: //simmetria diagonale 1
                    for(int c = 1; c < 6; c += 4)
                    {
                        v = q[c];
                        q[c] = q[c + 2];
                        q[c + 2] = v;
                    }
                    v = q[2];
                    q[2] = q[6];
                    q[6] = v;
                    break;
                case 7: //simmetria diagonale 2
                    for(int c = 1; c < 4; c += 2)
                    {
                        v = q[c];
                        q[c] = q[c + 4];
                        q[c + 4] = v;
                    }
                    v = q[0];
                    q[0] = q[8];
                    q[8] = v;
                    break;
            }
        }

        private void trasformam(int r) //funzione trasformazioni matematiche
        {
            Random rr = new Random(); //variabile numero casuale
            switch (r)
            {
                case 0: //nessuna
                    cm = 15;
                    break;
                case 1: //somma
                    v = rr.Next(1, 91);
                    for(int c = 0; c < 9; c++)
                    {
                        q[c] += v;
                    }
                    cm = 15 + v * 3;
                    break;
                case 2: //prodotto
                    v = rr.Next(2, 10);
                    for(int c = 0; c < 9; c++)
                    {
                        q[c] *= v;
                    }
                    cm = 15 * v;
                    break;
            }
        }

        private void con_Click(object sender, EventArgs e) //pulsante controllo quadrato corretto
        {
            bool con = false; //dichiarazione ed inizializzazione variabile controllo
            for (int c = 0; c < 9; c++) //controllo textbox
            {
                if (Int32.TryParse(t[c].Text, out v)) //controllo numero non stringa
                {
                    if (v == q[c]) //controllo numero giusto
                    {
                        con = true;
                    }
                    else
                    {
                        con = false;
                        c = 9; //uscita ciclo
                    }
                }
                else
                {
                    con = false;
                    c = 9; //uscita ciclo
                }
            }
            if (con == true) //quadrato corretto
            {
                MessageBox.Show("Corretto!");
                via.Enabled = true;
                for (int c = 0; c < 9; c++) //blocco textbox
                {
                    t[c].Enabled = false;
                }
            }
            else //quadrato sbagliato
            {
                MessageBox.Show("Sbagliato!");
            }
        }
    }
}
