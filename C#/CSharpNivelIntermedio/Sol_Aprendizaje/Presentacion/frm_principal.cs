using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_principal : Form
    {
        //Instanciar los formularios de trabajo para el menú principal
        MiPrimerFormulario Frm_01;
        frm_trackbar Frm_02;
        Frm_Categorias Frm_ca;
        Frm_Unidades_medidas Frm_um;
        public frm_principal()
        {
            InitializeComponent();
        }

        private void miPrimerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_01==null)
            {
                Frm_01 = new MiPrimerFormulario();
                Frm_01.MdiParent = this;
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                Frm_01.Show();
            }
            else
            {
                Frm_01.Activate();
            }
                
        }

        void Alta_frm_01(object sender, EventArgs e)
        {
            Frm_01 = null;
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_02 == null)
            {
                Frm_02 = new frm_trackbar();
                Frm_02.MdiParent = this;
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                Frm_02.Show();
            }
            else
            {
                Frm_02.Activate();
            }
                
        }

        void Alta_frm_02(object sender, EventArgs e)
        {
            Frm_02 = null;
        }

        private void m_btn_01_Click(object sender, EventArgs e)
        {
            if (Frm_01 == null)
            {
                Frm_01 = new MiPrimerFormulario();
                Frm_01.MdiParent = this;
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                Frm_01.Show();
            }
            else
            {
                Frm_01.Activate();
            }
        }

        private void m_btn_02_Click(object sender, EventArgs e)
        {
            if (Frm_02 == null)
            {
                Frm_02 = new frm_trackbar();
                Frm_02.MdiParent = this;
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                Frm_02.Show();
            }
            else
            {
                Frm_02.Activate();
            }
        }

        void Alta_frm_ca(object sender, EventArgs e)
        {
            Frm_ca = null;
        }
        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_ca == null)
            {
                Frm_ca = new Frm_Categorias();
                Frm_ca.MdiParent = this;
                Frm_ca.FormClosed += new FormClosedEventHandler(Alta_frm_ca);
                Frm_ca.Show();
            }
            else
            {
                Frm_ca.Activate();
            }
        }

        void Alta_frm_um(object sender, EventArgs e)
        {
            Frm_um = null;
        }
        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_um == null)
            {
                Frm_um = new Frm_Unidades_medidas();
                Frm_um.MdiParent = this;
                Frm_um.FormClosed += new FormClosedEventHandler(Alta_frm_ca);
                Frm_um.Show();
            }
            else
            {
                Frm_ca.Activate();
            }
        }
    }
}
