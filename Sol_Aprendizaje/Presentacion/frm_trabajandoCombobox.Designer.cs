namespace Presentacion
{
    partial class frm_trabajandoCombobox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nuevo = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Items.AddRange(new object[] {
            "VISUAL FOXPRO",
            "C SHARP",
            "VB.NET"});
            this.cmb_cursos.Location = new System.Drawing.Point(390, 43);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(165, 21);
            this.cmb_cursos.TabIndex = 0;
            this.cmb_cursos.Text = "Seleccione un curso";
            this.cmb_cursos.SelectedIndexChanged += new System.EventHandler(this.cmb_cursos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cursos disponibles:";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(345, 106);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(210, 60);
            this.txt_resultado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso seleccionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso nuevo:";
            // 
            // txt_nuevo
            // 
            this.txt_nuevo.Location = new System.Drawing.Point(88, 58);
            this.txt_nuevo.Name = "txt_nuevo";
            this.txt_nuevo.Size = new System.Drawing.Size(137, 20);
            this.txt_nuevo.TabIndex = 5;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(88, 90);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(137, 23);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_trabajandoCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 251);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_nuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_cursos);
            this.Name = "frm_trabajandoCombobox";
            this.Text = "frm_trabajandoCombobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nuevo;
        private System.Windows.Forms.Button btn_registrar;
    }
}