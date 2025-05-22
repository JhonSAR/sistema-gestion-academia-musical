namespace Fase2JhonArdila
{
    partial class ReporteDeDatos
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
            this.txtClasesRecibidas = new System.Windows.Forms.TextBox();
            this.dtpFechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCostoPorClase = new System.Windows.Forms.TextBox();
            this.txtNombreDelEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostoTotalCurso = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gboxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClasesRecibidas
            // 
            this.txtClasesRecibidas.Enabled = false;
            this.txtClasesRecibidas.Location = new System.Drawing.Point(209, 277);
            this.txtClasesRecibidas.Margin = new System.Windows.Forms.Padding(5);
            this.txtClasesRecibidas.Name = "txtClasesRecibidas";
            this.txtClasesRecibidas.Size = new System.Drawing.Size(272, 27);
            this.txtClasesRecibidas.TabIndex = 32;
            // 
            // dtpFechaDeRegistro
            // 
            this.dtpFechaDeRegistro.Enabled = false;
            this.dtpFechaDeRegistro.Location = new System.Drawing.Point(679, 82);
            this.dtpFechaDeRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaDeRegistro.Name = "dtpFechaDeRegistro";
            this.dtpFechaDeRegistro.Size = new System.Drawing.Size(304, 27);
            this.dtpFechaDeRegistro.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Piano",
            "Guitarra",
            "Violín",
            "Batería",
            "Canto"});
            this.comboBox1.Location = new System.Drawing.Point(209, 210);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 29);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.rbtnFemenino);
            this.gboxGenero.Controls.Add(this.rbtnMasculino);
            this.gboxGenero.Controls.Add(this.label7);
            this.gboxGenero.Controls.Add(this.label8);
            this.gboxGenero.Enabled = false;
            this.gboxGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxGenero.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gboxGenero.Location = new System.Drawing.Point(505, 137);
            this.gboxGenero.Margin = new System.Windows.Forms.Padding(5);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Padding = new System.Windows.Forms.Padding(5);
            this.gboxGenero.Size = new System.Drawing.Size(222, 114);
            this.gboxGenero.TabIndex = 29;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Genero";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFemenino.Location = new System.Drawing.Point(128, 69);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(14, 13);
            this.rbtnFemenino.TabIndex = 9;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(128, 30);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(14, 13);
            this.rbtnMasculino.TabIndex = 8;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Masculino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Femenino";
            // 
            // txtCostoPorClase
            // 
            this.txtCostoPorClase.Enabled = false;
            this.txtCostoPorClase.Location = new System.Drawing.Point(679, 277);
            this.txtCostoPorClase.Margin = new System.Windows.Forms.Padding(5);
            this.txtCostoPorClase.Name = "txtCostoPorClase";
            this.txtCostoPorClase.Size = new System.Drawing.Size(272, 27);
            this.txtCostoPorClase.TabIndex = 28;
            // 
            // txtNombreDelEstudiante
            // 
            this.txtNombreDelEstudiante.Enabled = false;
            this.txtNombreDelEstudiante.Location = new System.Drawing.Point(209, 149);
            this.txtNombreDelEstudiante.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreDelEstudiante.Name = "txtNombreDelEstudiante";
            this.txtNombreDelEstudiante.Size = new System.Drawing.Size(272, 27);
            this.txtNombreDelEstudiante.TabIndex = 27;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Enabled = false;
            this.txtIdentificacion.Location = new System.Drawing.Point(209, 82);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(272, 27);
            this.txtIdentificacion.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(519, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Costo Por Clase";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(501, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha de Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(14, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Clases Recibidas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(14, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Instrumento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(14, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre del Estudiante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Identificación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(266, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Costo Total Del Curso";
            // 
            // txtCostoTotalCurso
            // 
            this.txtCostoTotalCurso.Enabled = false;
            this.txtCostoTotalCurso.Location = new System.Drawing.Point(484, 342);
            this.txtCostoTotalCurso.Margin = new System.Windows.Forms.Padding(5);
            this.txtCostoTotalCurso.Name = "txtCostoTotalCurso";
            this.txtCostoTotalCurso.Size = new System.Drawing.Size(266, 27);
            this.txtCostoTotalCurso.TabIndex = 34;
            this.txtCostoTotalCurso.TextChanged += new System.EventHandler(this.txtCostoTotalCurso_TextChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegresar.Location = new System.Drawing.Point(416, 395);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(166, 47);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 30);
            this.label10.TabIndex = 36;
            this.label10.Text = "REPORTE DE INFORMACIÓN";
            // 
            // ReporteDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(999, 481);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtCostoTotalCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClasesRecibidas);
            this.Controls.Add(this.dtpFechaDeRegistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gboxGenero);
            this.Controls.Add(this.txtCostoPorClase);
            this.Controls.Add(this.txtNombreDelEstudiante);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReporteDeDatos";
            this.Text = "ReporteDeDatos";
            this.Load += new System.EventHandler(this.ReporteDeDatos_Load);
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtClasesRecibidas;
        public System.Windows.Forms.DateTimePicker dtpFechaDeRegistro;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.RadioButton rbtnFemenino;
        public System.Windows.Forms.RadioButton rbtnMasculino;
        public System.Windows.Forms.TextBox txtCostoPorClase;
        public System.Windows.Forms.TextBox txtNombreDelEstudiante;
        public System.Windows.Forms.TextBox txtIdentificacion;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCostoTotalCurso;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.GroupBox gboxGenero;
        public System.Windows.Forms.Label label10;
    }
}