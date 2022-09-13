using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Estadoguarda = 0; //Sin ninguna acción
        int Ncodigo = 0; //Se va utilizar para guardar el código del registro seleccionado

        #endregion
        #region "Mis Métodos"

        private void Formato_ca()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "CATEGORÍA";
        }
        private void Listado_ca(string cTexto)
        {
            Dgv_principal.DataSource = N_Categorias.Listar_ca(cTexto);
            this.Formato_ca();
        }

        private void Estado(bool lEstado)
        {
            Txt_descripcion_ca.Enabled= lEstado;
            Btn_cancelar.Enabled = lEstado;
            Btn_guardar.Enabled = lEstado;

            Btn_nuevo.Enabled = !lEstado;
            Btn_actualizar.Enabled = !lEstado;
            Btn_eliminar.Enabled = !lEstado;
            Btn_reporte.Enabled = !lEstado;
            Btn_salir.Enabled = !lEstado;

            Txt_buscar.Enabled = !lEstado;
            Btn_buscar.Enabled = !lEstado;
            Dgv_principal.Enabled = !lEstado;

        }

        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(Txt_descripcion_ca.Text))
            {
                MessageBox.Show("No se tiene información para ser guardada","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                E_Categorias oCa = new E_Categorias();
                oCa.Codigo_ca = Ncodigo;
                oCa.Descripcion_ca = Txt_descripcion_ca.Text.Trim();               

                Rpta = N_Categorias.Guardar_ca(Estadoguarda, oCa);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    this.Estado(false);
                    Txt_descripcion_ca.Clear(); 
                    Estadoguarda = 0;
                    Ncodigo = 0;
                    MessageBox.Show("Datos guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ca(Txt_buscar.Text.Trim());
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro
            this.Estado(true);
            Txt_descripcion_ca.Text = "";
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado(false);
            Txt_descripcion_ca.Text = "";
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado(true);
        }

        private void Dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Ncodigo= Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ca"].Value);
            Txt_descripcion_ca.Text =Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ca"].Value);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Estás seguro de eliminar el registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion== DialogResult.Yes)
            {
                string Rpta = "";
                Rpta = N_Categorias.Eliminar_ca(Ncodigo);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    Ncodigo = 0;
                    Txt_descripcion_ca.Text = "";

                    MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.frm_rpt_Categorias oRpt1 = new Reportes.frm_rpt_Categorias();
            oRpt1.txt_p1.Text = Txt_buscar.Text;
            oRpt1.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
