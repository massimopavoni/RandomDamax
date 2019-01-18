using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produzione_Pezzi_Massimo_Pavoni
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            ControlloPezzi.CaricaDati();
            ControlloPezzi.ControllaPezzi();
            ControlloPezzi.SalvaDati();
        }

        private void VisualizzaPezzi(List<Pezzo> _pezzi)
        {
            lvPezzi.Items.Clear();
            lblNumeroPezzi.Text = _pezzi.Count.ToString();
            foreach (Pezzo _p in _pezzi)
            {
                ListViewItem _lvi = new ListViewItem(_p.Matricola.ToString());
                _lvi.SubItems.Add(_p.Tipo.ToString());
                _lvi.SubItems.Add(_p.Altezza.ToString());
                _lvi.SubItems.Add(_p.Larghezza.ToString());
                _lvi.SubItems.Add(_p.Profondita.ToString());
                lvPezzi.Items.Add(_lvi);
            }
        }

        #region Eventi
        private void btnPezziTotali_Click(object sender, EventArgs e)
        {
            btnPezziTotali.Enabled = false;
            btnPezziALTA_Q.Enabled = true;
            btnPezziBASSA_Q.Enabled = true;
            btnPezziSCARTO.Enabled = true;
            VisualizzaPezzi(ControlloPezzi.PezziTotali);
        }
        private void btnPezziALTA_Q_Click(object sender, EventArgs e)
        {
            btnPezziTotali.Enabled = true;
            btnPezziALTA_Q.Enabled = false;
            btnPezziBASSA_Q.Enabled = true;
            btnPezziSCARTO.Enabled = true;
            VisualizzaPezzi(ControlloPezzi.PezziALTA_Q);
        }
        private void btnPezziBASSA_Q_Click(object sender, EventArgs e)
        {
            btnPezziTotali.Enabled = true;
            btnPezziALTA_Q.Enabled = true;
            btnPezziBASSA_Q.Enabled = false;
            btnPezziSCARTO.Enabled = true;
            VisualizzaPezzi(ControlloPezzi.PezziBASSA_Q);
        }
        private void btnPezziSCARTO_Click(object sender, EventArgs e)
        {
            btnPezziTotali.Enabled = true;
            btnPezziALTA_Q.Enabled = true;
            btnPezziBASSA_Q.Enabled = true;
            btnPezziSCARTO.Enabled = false;
            VisualizzaPezzi(ControlloPezzi.PezziSCARTO);
        }
        #endregion
    }
}
