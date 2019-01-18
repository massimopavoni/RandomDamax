using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris_Massimo_Pavoni
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent(); //avvio form
            b = new Button[] { b0, b1, b2, b3, b4, b5, b6, b7, b8 }; //inizializzazione vettore pulsanti
            bloccob(); //funzione blocco gioco
        }

        private Button[] b; //dichiarazione vettore pulsanti
        int g; //dichiarazione giocatore corrente
        int tn; //dichiarazione turno X/O
        int c; //dichiarazione contatore click
        int p; //dichiarazione partite giocate

        private int fine() //funzione controllo partita terminata
        {
            if (((b0.Text == "X") && (b1.Text == "X") && (b2.Text == "X")) || ((b3.Text == "X") && (b4.Text == "X") && (b5.Text == "X")) ||
               ((b6.Text == "X") && (b7.Text == "X") && (b8.Text == "X")) || ((b0.Text == "X") && (b3.Text == "X") && (b6.Text == "X")) ||
               ((b1.Text == "X") && (b4.Text == "X") && (b7.Text == "X")) || ((b2.Text == "X") && (b5.Text == "X") && (b8.Text == "X")) ||
               ((b0.Text == "X") && (b4.Text == "X") && (b8.Text == "X")) || ((b2.Text == "X") && (b4.Text == "X") && (b6.Text == "X")))
            { //vince X
                return 1;
            }
            else if (((b0.Text == "O") && (b1.Text == "O") && (b2.Text == "O")) || ((b3.Text == "O") && (b4.Text == "O") && (b5.Text == "O")) ||
                    ((b6.Text == "O") && (b7.Text == "O") && (b8.Text == "O")) || ((b0.Text == "O") && (b3.Text == "O") && (b6.Text == "O")) ||
                    ((b1.Text == "O") && (b4.Text == "O") && (b7.Text == "O")) || ((b2.Text == "O") && (b5.Text == "O") && (b8.Text == "O")) ||
                    ((b0.Text == "O") && (b4.Text == "O") && (b8.Text == "O")) || ((b2.Text == "O") && (b4.Text == "O") && (b6.Text == "O")))
            { //vince O
                return 2;
            }
            else if ((b0.Text != " ") && (b1.Text != " ") && (b2.Text != " ") &&
                    (b3.Text != " ") && (b4.Text != " ") && (b5.Text != " ") &&
                    (b6.Text != " ") && (b7.Text != " ") && (b8.Text != " "))
            { //pareggio
                return 3;
            }
            else
            { //partita non terminata
                return 0;
            }
        }

        private string simbolo(int tn) //funzione determinazione turno X/O
        {
            switch (tn % 2)
            {
                case 0:
                    return "X";
                case 1:
                    return "O";
            }
            return "Easter Egg"; //codice irraggiungibile
        }

        private string vittoria() //funzione mossa vincente [AI_NEED]
        {
            int[,] vs = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } }; //dichiarazione ed inizializzazione vettore possibili vittorie
            for (int c = 0; c < 8; c++)
            {
                if ((b[vs[c, 0]].Text != " ") && (b[vs[c, 0]].Text == b[vs[c, 1]].Text) && (b[vs[c, 0]].Text == b[vs[c, 2]].Text)) //controllo possibile vincita
                {
                    return b[vs[c, 2]].Text;
                }
            }
            return " "; //nessuna possibile vincita
        }

        private int minimax(int g) //funzione ricorsiva minimax [AI_NEED]
        {
            int cv = 0; //dichiarazione ed inizializzazione casella vincente
            if (ai1.Checked || ai3.Checked)
            { //controllo inizia giocatore
                if (vittoria() == "O")
                { //valore questipunti casella vince O
                    cv = 1;
                }
                else if (vittoria() == "X")
                { //valore questipunti casella vince X
                    cv = -1;
                }
            }
            else if (ai2.Checked || ai4.Checked)
            { //controllo inizia AI
                if (vittoria() == "X")
                { //valore questipunti casella vince X
                    cv = 1;
                }
                else if (vittoria() == "O")
                { //valore questipunti casella vince O
                    cv = -1;
                }
            }
            if (cv != 0)
            { //ritorno valore questipunti mossa se possibile vincita
                if (g == -1)
                { //AI
                    return cv * g;
                }
                else
                {
                    return cv * 1;
                }
            }
            int m = -1; //dichiarazione ed inizializzazione mossa pulsante
            int p = -2; //dichiarazione ed inizializzazione punti
            int qp; //dichiarazione questipunti
            for (int c = 0; c < 9; c++)
            {
                if (b[c].Text == " ")
                { //casella vuota
                    if (g == -1)
                    { //AI
                        b[c].Text = simbolo(tn + 1); //prova mossa simbolo AI
                        qp = -minimax(g * -1); //ricorsione valuta punteggio mossa
                    }
                    else
                    {
                        b[c].Text = simbolo(tn); //prova mossa simbolo giocatore
                        qp = -minimax(g * -1); //ricorsione valuta punteggio mossa
                    }
                    if (qp > p)
                    { //decidi mossa migliore
                        p = qp; //miglior punteggio
                        m = c; //casella miglior mossa
                    }
                    b[c].Text = " "; //libera casella
                }
            }
            if (m == -1)
            { //mossa non possibile
                return 0; //punti pareggio
            }
            return p; //ritorno valore punti mossa
        }

        private void ai() //funzione mossa AI [AI_NEED]
        {
            int m = -1; //dichiarazione ed inizializzazione mossa pulsante
            int p = -2; //dichiarazione ed inizializzazione punti
            int qp; //dichiarazione questipunti
            int c; //dichiarazione contatore
            if (((b0.Text == " ") && (b1.Text == " ") && (b2.Text == " ") &&
               (b3.Text == " ") && (b4.Text == " ") && (b5.Text == " ") &&
               (b6.Text == " ") && (b7.Text == " ") && (b8.Text == " ")) ||
               ((b0.Text == " ") && (b1.Text == " ") && (b2.Text == " ") &&
               (b3.Text == " ") && (b4.Text != simbolo(tn)) && (b5.Text == " ") &&
               (b6.Text == " ") && (b7.Text == " ") && (b8.Text == " ")))
            { //velocizzazione prima mossa inizia AI
                b0.Enabled = false; //casella bloccata
                b0.Text = simbolo(tn); //mossa
            }
            else if ((b0.Text != simbolo(tn)) && (b1.Text != simbolo(tn)) && (b2.Text != simbolo(tn)) &&
                    (b3.Text != simbolo(tn)) && (b4.Text == " ") && (b5.Text != simbolo(tn)) &&
                    (b6.Text != simbolo(tn)) && (b7.Text != simbolo(tn)) && (b8.Text != simbolo(tn)))
            { //velocizzazione prima mossa inizia giocatore
                b4.Enabled = false; //casella bloccata
                b4.Text = simbolo(tn); //mossa
            }
            else
            { //mossa ragionata
                for (c = 0; c < 9; c++)
                { //controllo ogni casella
                    if (b[c].Text == " ")
                    { //casella libera
                        b[c].Text = simbolo(tn); //prova mossa
                        qp = -minimax(-1); //valuta punteggio mossa ricorsione ramo albero delle partite
                        b[c].Text = " "; //libera casella
                        if (qp > p)
                        { //decidi mossa migliore
                            p = qp; //miglior punteggio
                            m = c; //casella miglior mossa
                        }
                    }
                }
                b[m].Enabled = false; //casella bloccata
                b[m].Text = simbolo(tn); //mossa
            }
            if (fine() != 0)
            { //vincita
                giocatore(g); //funzione cambio giocatore e punti partite
            }
            tn++; //turno successivo
        }

        private void punti1(int g) //funzione punti partite giocatore 1
        {
            if (fine() == 1)
            { //vince X
                bloccob(); //funzione blocco gioco
                if (giocatori1.Checked)
                { //giocatore 1 vs giocatore 2
                    pg1.Value++; //giocatore 1 vince
                    MessageBox.Show("Il G1 ha vinto.");
                }
                else
                { //giocatore 2 vs giocatore 1
                    pg2.Value++; //giocatore 2 vince
                    MessageBox.Show("Il G2 ha vinto.");
                }
            }
            else if (fine() == 2)
            { //vince O
                bloccob(); //funzione blocco gioco
                if (giocatori1.Checked)
                { //giocatore 1 vs giocatore 2
                    pg2.Value++; //giocatore 2 vince
                    MessageBox.Show("Il G2 ha vinto.");
                }
                else
                { //giocatore 2 vs giocatore 1
                    pg1.Value++; //giocatore 1 vince
                    MessageBox.Show("Il G1 ha vinto.");
                }
            }
            else if (fine() == 3)
            { //pareggio
                bloccob(); //funzione blocco gioco
                MessageBox.Show("Pareggio.");
            }
            else
            {
                if (g == 1)
                { //cambio giocatore
                    g = 2;
                }
                else
                {
                    g = 1;
                }
            }
        }

        private void punti2(int g) //funzione punti partite giocatore 1
        {
            if (fine() == 1)
            { //vince X
                bloccob(); //funzione blocco gioco
                if (ai1.Checked)
                { //giocatore 1 vs AI
                    pg1.Value++; //giocatore 1 vince (codice irraggiungibile XD)
                    MessageBox.Show("Il G1 ha vinto.");
                }
                else if (ai3.Checked)
                { //giocatore 2 vs AI
                    pg2.Value++; //giocatore 2 vince (codice irraggiungibile XD)
                    MessageBox.Show("Il G2 ha vinto.");
                }
                else if (ai2.Checked || ai4.Checked)
                { //AI vs giocatore 1 o giocatore 2
                    pai.Value++; //AI vince
                    MessageBox.Show("La CPU ha vinto.");
                }
            }
            else if (fine() == 2)
            { //vince O
                bloccob(); //funzione blocco gioco
                if (ai1.Checked || ai3.Checked)
                { //giocatore 1 o giocatore 2 vs AI
                    pai.Value++; //AI vince
                    MessageBox.Show("La CPU ha vinto.");
                }
                else if (ai2.Checked)
                { //Ai vs giocatore 1
                    pg1.Value++; //giocatore 1 vince (codice irraggiungibile XD)
                    MessageBox.Show("Il G1 ha vinto.");
                }
                else if (ai4.Checked)
                { //AI vs giocatore 2
                    pg2.Value++; //giocatore 1 vince (codice irraggiungibile XD)
                    MessageBox.Show("Il G2 ha vinto.");
                }
            }
            else if (fine() == 3)
            { //pareggio
                bloccob(); //funzione blocco gioco
                MessageBox.Show("Pareggio.");
            }
            else
            {
                ai(); //mossa AI
                if (g == -1)
                { //cambio giocatore
                    g = 1;
                }
                else
                {
                    g = -1;
                }
            }
        }

        private void giocatore(int g) //funzione punti e cambio giocatore
        {
            if (giocatori1.Checked || giocatori2.Checked) //giocatori
            {
                punti1(g);
            }
            else if (ai1.Checked || ai2.Checked || ai3.Checked || ai4.Checked) //AI
            {
                punti2(g);
            }
        }

        private void click() //funzione click pulsanti
        {
            b[c].Enabled = false; //casella bloccata
            b[c].Text = simbolo(tn); //mossa
            tn++; //prossimo turno
            giocatore(g); //cambio giocatore e verifica punti (fine partita)
        }

        private void b0_Click(object sender, EventArgs e)
        {
            c = 0; //pulsante alto sinistra
            click();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            c = 1; //pulsante alto centro
            click();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            c = 2; //pulsante alto destra
            click();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            c = 3; //pulsante centro sinistra
            click();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            c = 4; //pulsante centro centro
            click();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            c = 5; //pulsante centro destra
            click();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            c = 6; //pulsante basso sinistra
            click();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            c = 7; //pulsante basso centro
            click();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            c = 8; //pulsante basso destra
            click();
        }

        private void blocco() //funzione sblocco gioco
        {
            giocatori1.Enabled = false;
            giocatori2.Enabled = false;
            ai1.Enabled = false;
            ai2.Enabled = false;
            ai3.Enabled = false;
            ai4.Enabled = false;
            via.Enabled = false;
            reset.Enabled = false;
            for (int c = 0; c < 9; c++) //tabella
            {
                b[c].Enabled = true;
            }
        }

        private void bloccob() //funzione blocco gioco
        {
            giocatori1.Enabled = true;
            giocatori2.Enabled = true;
            ai1.Enabled = true;
            ai2.Enabled = true;
            ai3.Enabled = true;
            ai4.Enabled = true;
            via.Enabled = true;
            reset.Enabled = true;
            for (int c = 0; c < 9; c++) //tabella
            {
                b[c].Enabled = false;
            }
        }

        private void inizio() //funzione partite giocate e inizializzazione testo pulsanti
        {
            p++; //aumento partite giocate
            partite0.Text = p.ToString();
            pg1.Maximum++;
            pg2.Maximum++;
            pai.Maximum++;
            tn = 0;
            for (int c = 0; c < 9; c++) //tabella
            {
                b[c].Text = " ";
            }
        }

        private void via_Click(object sender, EventArgs e) //pulsante nuova partita
        {
            if (giocatori1.Checked)
            { //giocatore 1 vs giocatore 2
                g = 1; //inizializzazione giocatore corrente
                inizio();
                blocco(); //sblocco gioco
            }
            else if (giocatori2.Checked)
            { //giocatore 2 vs giocatore 1
                g = 2; //inizializzazione giocatore corrente
                inizio();
                blocco(); //sblocco gioco
            }
            else if (ai1.Checked || ai3.Checked)
            { //giocatore 1 o giocatore 2 vs AI
                g = 1; //inizializzazione giocatore corrente
                inizio();
                blocco(); //sblocco gioco
            }
            else if (ai2.Checked || ai4.Checked)
            { //AI vs giocatore 1 o giocatore 2
                g = 1; //inizializzazione giocatore corrente
                inizio();
                blocco(); //sblocco gioco
                giocatore(g); //mossa AI
            }
            else
            { //nessun radiobutton selezionato
                MessageBox.Show("Devi prima selezionare una modalità di gioco.");
            }
        }

        private void reset_Click(object sender, EventArgs e) //pulsante reset punti
        {
            p = 0; //partite giocate azzerate
            partite0.Text = p.ToString();
            pg1.Maximum = 0;
            pg2.Maximum = 0;
            pai.Maximum = 0;
            pg1.Value = 0;
            pg2.Value = 0;
            pai.Value = 0;
        }
    }
}
