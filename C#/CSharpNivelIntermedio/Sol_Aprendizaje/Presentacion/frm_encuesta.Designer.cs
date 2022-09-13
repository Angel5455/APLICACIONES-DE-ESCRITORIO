namespace Presentacion
{
    partial class frm_encuesta
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
            this.chk_vfp = new System.Windows.Forms.CheckBox();
            this.chk_csharp = new System.Windows.Forms.CheckBox();
            this.chk_vbnet = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_java = new System.Windows.Forms.CheckBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.rdb_presencial = new System.Windows.Forms.RadioButton();
            this.rdb_virtual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_vfp
            // 
            this.chk_vfp.AutoSize = true;
            this.chk_vfp.Location = new System.Drawing.Point(35, 93);
            this.chk_vfp.Name = "chk_vfp";
            this.chk_vfp.Size = new System.Drawing.Size(90, 17);
            this.chk_vfp.TabIndex = 0;
            this.chk_vfp.Text = "Visual FoxPro";
            this.chk_vfp.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            this.chk_csharp.AutoSize = true;
            this.chk_csharp.Location = new System.Drawing.Point(35, 128);
            this.chk_csharp.Name = "chk_csharp";
            this.chk_csharp.Size = new System.Drawing.Size(81, 17);
            this.chk_csharp.TabIndex = 1;
            this.chk_csharp.Text = "C Sharp C#";
            this.chk_csharp.UseVisualStyleBackColor = true;
            // 
            // chk_vbnet
            // 
            this.chk_vbnet.AutoSize = true;
            this.chk_vbnet.Location = new System.Drawing.Point(35, 162);
            this.chk_vbnet.Name = "chk_vbnet";
            this.chk_vbnet.Size = new System.Drawing.Size(65, 17);
            this.chk_vbnet.TabIndex = 2;
            this.chk_vbnet.Text = "VB.NET";
            this.chk_vbnet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cursos Disponibles en Promoción:";
            // 
            // chk_java
            // 
            this.chk_java.AutoSize = true;
            this.chk_java.Location = new System.Drawing.Point(35, 196);
            this.chk_java.Name = "chk_java";
            this.chk_java.Size = new System.Drawing.Size(49, 17);
            this.chk_java.TabIndex = 4;
            this.chk_java.Text = "Java";
            this.chk_java.UseVisualStyleBackColor = true;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(263, 227);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(343, 98);
            this.txt_resultado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(265, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado de los cursos seleccionados:";
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_procesar.Location = new System.Drawing.Point(35, 227);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(127, 71);
            this.btn_procesar.TabIndex = 7;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // rdb_presencial
            // 
            this.rdb_presencial.AutoSize = true;
            this.rdb_presencial.Location = new System.Drawing.Point(268, 150);
            this.rdb_presencial.Name = "rdb_presencial";
            this.rdb_presencial.Size = new System.Drawing.Size(74, 17);
            this.rdb_presencial.TabIndex = 8;
            this.rdb_presencial.TabStop = true;
            this.rdb_presencial.Text = "Presencial";
            this.rdb_presencial.UseVisualStyleBackColor = true;
            // 
            // rdb_virtual
            // 
            this.rdb_virtual.AutoSize = true;
            this.rdb_virtual.Location = new System.Drawing.Point(422, 150);
            this.rdb_virtual.Name = "rdb_virtual";
            this.rdb_virtual.Size = new System.Drawing.Size(54, 17);
            this.rdb_virtual.TabIndex = 9;
            this.rdb_virtual.TabStop = true;
            this.rdb_virtual.Text = "Virtual";
            this.rdb_virtual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(265, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "En que escenario de aprendizaje te gustaria?";
            // 
            // frm_encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_virtual);
            this.Controls.Add(this.rdb_presencial);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.chk_java);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_vbnet);
            this.Controls.Add(this.chk_csharp);
            this.Controls.Add(this.chk_vfp);
            this.Name = "frm_encuesta";
            this.Text = "ENCUESTA DE CURSOS DISPONIBLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_vfp;
        private System.Windows.Forms.CheckBox chk_csharp;
        private System.Windows.Forms.CheckBox chk_vbnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_java;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.RadioButton rdb_presencial;
        private System.Windows.Forms.RadioButton rdb_virtual;
        private System.Windows.Forms.Label label3;
    }
}