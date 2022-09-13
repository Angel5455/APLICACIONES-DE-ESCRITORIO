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
    public partial class Frm_Unidades_medidas : Form
    {
        public Frm_Unidades_medidas()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Estadoguarda = 0; //Sin ninguna acción
        int Ncodigo = 0; //Se va utilizar para guardar el código del registro seleccionado

        #endregion
        #region "Mis Métodos"

        private void Formato_um()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "UNIDADES DE MEDIDAS";
        }
        private void Listado_um(string cTexto)
        {
            Dgv_principal.DataSource = N_Unidades_medidas.Listar_um(cTexto);
            this.Formato_um();
        }

        private void Estado(bool lEstado)
        {
            Txt_descripcion_um.Enabled= lEstado;
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

        private void Frm_Unidades_medidas_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(Txt_descripcion_um.Text))
            {
                MessageBox.Show("No se tiene información para ser guardada","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                E_Unidades_medidas oUm = new E_Unidades_medidas();
                oUm.Codigo_um = Ncodigo;
                oUm.Descripcion_um = Txt_descripcion_um.Text.Trim();               

                Rpta = N_Unidades_medidas.Guardar_um(Estadoguarda, oUm);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_um("%");
                    this.Estado(false);
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
            this.Listado_um(Txt_buscar.Text.Trim());
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // Nuevo Registro
            this.Estado(true);
            Txt_descripcion_um.Text = "";
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado(false);
            Txt_descripcion_um.Text = "";
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado(true);
        }

        private void Dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ncodigo= Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_um"].Value);
            Txt_descripcion_um.Text =Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_um"].Value);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult cOpcion;
            cOpcion = MessageBox.Show("¿Estás seguro de eliminar el registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cOpcion== DialogResult.Yes)
            {
                string Rpta = "";
                Rpta = N_Unidades_medidas.Eliminar_um(Ncodigo);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_um("%");
                    Ncodigo = 0;
                    Txt_descripcion_um.Text = "";

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
           /* Reportes.frm_rpt_Unidades_medidas oRpt2 = new Reportes.frm_rpt_Unidades_medidas();
            oRpt2.txt_p1.Text = Txt_buscar.Text;
            oRpt2.ShowDialog();*/
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
