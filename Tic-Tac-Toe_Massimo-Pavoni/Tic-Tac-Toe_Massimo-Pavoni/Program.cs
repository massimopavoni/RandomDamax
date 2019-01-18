using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Massimo_Pavoni
{
    class Program
    {
        static void tavola(char[] t)
        {
            Console.Clear();
            Console.Write("Tic Tac Toe\n\n\n\nQuesto programma permette di giocare a tris contro il computer.\nPer scegliere dove mettere il proprio simbolo si tenga presente che le caselle sono numerate come un tastierino di un cellulare (da 1 a 9).\n");
            for (int c = 0; c < 9; c++)
            {
                if (c % 3 == 0)
                {
                    Console.Write("\n\n\n\t{0}", t[c]);
                }
                else
                {
                    Console.Write("\t{0}", t[c]);
                }
            }
        }

        static bool mossavalida(char[] t, string sp, int p)
        {
            if (int.TryParse(sp, out p))
            {
                if ((p > 0) && (p < 10))
                {
                    if ((t[p - 1] == 'X') || (t[p - 1] == 'O'))
                    {
                        return false;
                    }
                    else
                    {
                        t[p - 1] = 'O';
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static int fine(char[] t)
        {
            if (((t[0] == 'O') && (t[1] == 'O') && (t[2] == 'O')) || ((t[3] == 'O') && (t[4] == 'O') && (t[5] == 'O')) ||
               ((t[6] == 'O') && (t[7] == 'O') && (t[8] == 'O')) || ((t[0] == 'O') && (t[3] == 'O') && (t[6] == 'O')) ||
               ((t[1] == 'O') && (t[4] == 'O') && (t[7] == 'O')) || ((t[2] == 'O') && (t[5] == 'O') && (t[8] == 'O')) ||
               ((t[0] == 'O') && (t[4] == 'O') && (t[8] == 'O')) || ((t[2] == 'O') && (t[4] == 'O') && (t[6] == 'O')))
            {
                return 1;
            }
            else if (((t[0] == 'X') && (t[1] == 'X') && (t[2] == 'X')) || ((t[3] == 'X') && (t[4] == 'X') && (t[5] == 'X')) ||
                    ((t[6] == 'X') && (t[7] == 'X') && (t[8] == 'X')) || ((t[0] == 'X') && (t[3] == 'X') && (t[6] == 'X')) ||
                    ((t[1] == 'X') && (t[4] == 'X') && (t[7] == 'X')) || ((t[2] == 'X') && (t[5] == 'X') && (t[8] == 'X')) ||
                    ((t[0] == 'X') && (t[4] == 'X') && (t[8] == 'X')) || ((t[2] == 'X') && (t[4] == 'X') && (t[6] == 'X')))
            {
                return -1;
            }
            else if ((t[0] != ' ') && (t[1] != ' ') && (t[2] != ' ')
                    && (t[3] != ' ') && (t[4] != ' ') && (t[5] != ' ') 
                    && (t[6] != ' ') && (t[7] != ' ') && (t[8] != ' '))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        static char vittoria(char[] t)
        {
            int[,] vs = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } }; //vittorie
            for (int c = 0; c < 8; c++)
            {
                if ((t[vs[c, 0]] != ' ') && (t[vs[c, 0]] == t[vs[c, 1]]) && (t[vs[c, 0]] == t[vs[c, 2]]))
                {
                    return t[vs[c, 2]];
                }
            }
            return ' ';
        }

        static int minimax(char[] t, int g)
        {
            int cv = 0; //casella vincente
            if (vittoria(t) == 'X')
            {
                cv = 1;
            }
            else if (vittoria(t) == 'O')
            {
                cv = -1;
            }
            if (cv != 0)
            {
                return cv * g;
            }
            int m = -1; //mossa
            int p = -2; //punti
            int qp; //questi punti
            for (int c = 0; c < 9; c++) 
            {
                if (t[c] == ' ')
                {
                    if (g == -1)
                    {
                        t[c] = 'O';
                        qp = -minimax(t, g*-1);
                    }
                    else
                    {
                        t[c] = 'X';
                        qp = -minimax(t, g*-1);
                    }
                    if (qp > p)
                    {
                        p = qp;
                        m = c;
                    }
                    t[c] = ' ';
                }
            }
            if (m == -1)
            {
                return 0;
            }
            return p;
        }

        static void ai(char[] t, int g)
        {
            int m = -1; //mossa
            int p = -2; //punti
            int qp; //questi punti
            int c; //contatore
            for (c = 0; c < 9; c++)
            {
                if (t[c] == ' ')
                {
                    t[c] = 'X';
                    qp = -minimax(t, -1);
                    t[c] = ' ';
                    if (qp > p)
                    {
                        p = qp;
                        m = c;
                    }
                }
            }
            t[m] = 'X';
        }

        static void Main(string[] args)
        {
            string s = "no"; //scelta
            bool no = s.Equals("no", StringComparison.OrdinalIgnoreCase); //controllo con "no"
            bool si = s.Equals("si", StringComparison.OrdinalIgnoreCase); //controllo con "si"
            do
            {
                char[] t = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }; //vettore tavola
                string gc = "mortale"; //giocatore corrente
                int g = 0; //giocatore corrente
                string sp = "1"; //stringa posizione
                int p = 1; //posizione
                int gv = 0; //giocatore vincente
                bool vm = true; //validità mossa
                do
                {
                    if ((gc.Equals("ai", StringComparison.OrdinalIgnoreCase)) || (gc.Equals("mortale", StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.Clear();
                        Console.Write("Tic Tac Toe\n\n\n\nQuesto programma permette di giocare a tris contro il computer.\nPer scegliere dove mettere il proprio simbolo si tenga presente che le caselle sono numerate come un tastierino di un cellulare (da 1 a 9).\nPer scegliere chi inizia inserisci AI (per il computer, 'X') o Mortale (per il giocatore, 'O'). ");
                        gc = Convert.ToString(Console.ReadLine());
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Tic Tac Toe\n\n\n\nQuesto programma permette di giocare a tris contro il computer.\nPer scegliere dove mettere il proprio simbolo si tenga presente che le caselle sono numerate come un tastierino di un cellulare (da 1 a 9).\nInput non valido, per scegliere chi inizia inserisci AI (per il computer, 'X') o Mortale (per il giocatore, 'O'). ");
                        gc = Convert.ToString(Console.ReadLine());
                    }
                } while ((!gc.Equals("ai", StringComparison.OrdinalIgnoreCase)) && (!gc.Equals("mortale", StringComparison.OrdinalIgnoreCase)));
                if (gc.Equals("ai", StringComparison.OrdinalIgnoreCase))
                {
                    g = 1;
                }
                else
                {
                    g = -1;
                }
                do
                {
                    switch (g)
                    {
                        case 1:
                            tavola(t);
                            ai(t, g);
                            gv = fine(t);
                            g = -1;
                            break;
                        case -1:
                            do
                            {
                                if ((int.TryParse(sp, out p)) && vm)
                                {
                                    tavola(t);
                                    Console.Write("\n\n\n\nQuale spazio vuoi occupare? ");
                                    sp = Convert.ToString(Console.ReadLine());
                                    vm = mossavalida(t, sp, p);
                                }
                                else
                                {
                                    tavola(t);
                                    Console.Write("\n\n\n\nInput non valido, quale spazio vuoi occupare? ");
                                    sp = Convert.ToString(Console.ReadLine());
                                    vm = mossavalida(t, sp, p);
                                }
                            } while ((!int.TryParse(sp, out p)) || (!vm));
                            tavola(t);
                            gv = fine(t);
                            g = 1;
                            break;
                    }
                } while (fine(t) == 0);
                do
                {
                    tavola(t);
                    switch (gv)
                    {
                        case 1:
                            Console.Write("\n\n\n\nHai vinto!");
                            break;
                        case -1:
                            Console.Write("\n\n\n\nHai perso...prevedibile.");
                            break;
                        case 2:
                            Console.Write("\n\n\n\nPareggio.");
                            break;
                    }
                    if (no || si)
                    {
                        Console.Write("\n\n\n\nVuoi rigiocare? ");
                        s = Convert.ToString(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("\n\n\n\nScelta non valida, vuoi rigiocare? ");
                        s = Convert.ToString(Console.ReadLine());
                    }
                    no = s.Equals("no", StringComparison.OrdinalIgnoreCase);
                    si = s.Equals("si", StringComparison.OrdinalIgnoreCase);
                } while (!(no || si));
            } while (!no || si);
        }
    }
}
