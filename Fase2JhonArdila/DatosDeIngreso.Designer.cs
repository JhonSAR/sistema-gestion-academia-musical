namespace Fase2JhonArdila
{
    partial class DatosDeIngreso
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombreDelEstudiante = new System.Windows.Forms.TextBox();
            this.txtCostoPorClase = new System.Windows.Forms.TextBox();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.txtClasesRecibidas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Estudiante";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instrumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clases Recibidas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Masculino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Femenino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 277);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Costo Por Clase";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(224, 84);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(271, 27);
            this.txtIdentificacion.TabIndex = 9;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombreDelEstudiante
            // 
            this.txtNombreDelEstudiante.Location = new System.Drawing.Point(224, 142);
            this.txtNombreDelEstudiante.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreDelEstudiante.Name = "txtNombreDelEstudiante";
            this.txtNombreDelEstudiante.Size = new System.Drawing.Size(271, 27);
            this.txtNombreDelEstudiante.TabIndex = 10;
            this.txtNombreDelEstudiante.TextChanged += new System.EventHandler(this.txtNombreDelEstudiante_TextChanged);
            // 
            // txtCostoPorClase
            // 
            this.txtCostoPorClase.Enabled = false;
            this.txtCostoPorClase.Location = new System.Drawing.Point(687, 273);
            this.txtCostoPorClase.Margin = new System.Windows.Forms.Padding(5);
            this.txtCostoPorClase.Name = "txtCostoPorClase";
            this.txtCostoPorClase.Size = new System.Drawing.Size(271, 27);
            this.txtCostoPorClase.TabIndex = 12;
            this.txtCostoPorClase.TextChanged += new System.EventHandler(this.txtCostoPorClase_TextChanged);
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.rbtnFemenino);
            this.gboxGenero.Controls.Add(this.rbtnMasculino);
            this.gboxGenero.Controls.Add(this.label7);
            this.gboxGenero.Controls.Add(this.label8);
            this.gboxGenero.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gboxGenero.Location = new System.Drawing.Point(535, 142);
            this.gboxGenero.Margin = new System.Windows.Forms.Padding(5);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Padding = new System.Windows.Forms.Padding(5);
            this.gboxGenero.Size = new System.Drawing.Size(203, 106);
            this.gboxGenero.TabIndex = 13;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Genero";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(138, 75);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(14, 13);
            this.rbtnFemenino.TabIndex = 9;
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(138, 37);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(14, 13);
            this.rbtnMasculino.TabIndex = 8;
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Piano",
            "Guitarra",
            "Violín",
            "Batería",
            "Canto"});
            this.comboBox1.Location = new System.Drawing.Point(224, 211);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 29);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpFechaDeRegistro
            // 
            this.dtpFechaDeRegistro.Location = new System.Drawing.Point(687, 82);
            this.dtpFechaDeRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaDeRegistro.Name = "dtpFechaDeRegistro";
            this.dtpFechaDeRegistro.Size = new System.Drawing.Size(305, 27);
            this.dtpFechaDeRegistro.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(239, 338);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 48);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcularCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCosto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcularCosto.Location = new System.Drawing.Point(394, 338);
            this.btnCalcularCosto.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(222, 48);
            this.btnCalcularCosto.TabIndex = 17;
            this.btnCalcularCosto.Text = "Calcular/Mostra Reporte";
            this.btnCalcularCosto.UseVisualStyleBackColor = false;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Salir.Location = new System.Drawing.Point(626, 338);
            this.Salir.Margin = new System.Windows.Forms.Padding(5);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(133, 48);
            this.Salir.TabIndex = 18;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // txtClasesRecibidas
            // 
            this.txtClasesRecibidas.Location = new System.Drawing.Point(224, 273);
            this.txtClasesRecibidas.Margin = new System.Windows.Forms.Padding(5);
            this.txtClasesRecibidas.Name = "txtClasesRecibidas";
            this.txtClasesRecibidas.Size = new System.Drawing.Size(271, 27);
            this.txtClasesRecibidas.TabIndex = 19;
            this.txtClasesRecibidas.TextChanged += new System.EventHandler(this.txtClasesRecibidas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "FORMULARIO INGRESO DE DATOS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DatosDeIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1001, 431);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClasesRecibidas);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.btnGuardar);
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
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DatosDeIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosDeIngreso";
            this.Load += new System.EventHandler(this.DatosDeIngreso_Load);
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombreDelEstudiante;
        private System.Windows.Forms.TextBox txtCostoPorClase;
        private System.Windows.Forms.GroupBox gboxGenero;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaDeRegistro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox txtClasesRecibidas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}