using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class frm_rpt_Categorias : Form
    {
        public frm_rpt_Categorias()
        {
            InitializeComponent();
        }

        private void frm_rpt_Categorias_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_caTableAdapter.Fill(this.dS_Reportes.USP_Listado_ca,cTexto: txt_p1.Text);
            this.reportViewer1.RefreshReport();
           // this.reportViewer2.RefreshReport();
           // this.reportViewer1.RefreshReport();*
        }
    }
}
