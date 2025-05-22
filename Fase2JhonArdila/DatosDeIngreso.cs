using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fase2JhonArdila
{
    public partial class DatosDeIngreso : Form
    {
        public DatosDeIngreso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

            bool error = false;
            foreach (char caracter in txtIdentificacion.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtIdentificacion, "Solo se permiten valores numéricos en este campo");
            }
            else
                errorProvider1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Piano":
                    txtCostoPorClase.Text = "100000";
                    break;
                case "Guitarra":
                    txtCostoPorClase.Text = "80000";
                    break;
                case "Violín":
                    txtCostoPorClase.Text = "90000";
                    break;
                case "Batería":
                    txtCostoPorClase.Text = "85000";
                    break;
                case "Canto":
                    txtCostoPorClase.Text = "95000";
                    break;
                default:
                    txtCostoPorClase.Text = "0";
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.Identificacion = txtIdentificacion.Text;
            estudiante.NombreDelEstudiante = txtNombreDelEstudiante.Text;


            if (rbtnMasculino.Checked)
            {
                estudiante.Genero = "Masculino";
            }
            else if (rbtnFemenino.Checked)
            {
                estudiante.Genero = "Femenino";
            }
            else
            {
                MessageBox.Show("Por favor selecciona un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Elegir el instrumento a aprender
            estudiante.instrumento = comboBox1.SelectedItem.ToString();

            // Ingresar el número de clases recibidas
            estudiante.clasesRecibidas = Convert.ToInt32(txtClasesRecibidas.Text);

            // Seleccionar (automáticamente) el costo por clase de acuerdo al instrumento elegido por el estudiante
            estudiante.costoPorClase = Convert.ToDecimal(txtCostoPorClase.Text);

            // Mostrar la fecha de registro
            estudiante.fechaDeRegistro = dtpFechaDeRegistro.Value;

            // Mensaje de registro exitoso
            MessageBox.Show("Registro realizado exitosamente", " información", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            GestionEstudiantes estudiante = new GestionEstudiantes();
            estudiante.clasesRecibidas = Convert.ToInt32(txtClasesRecibidas.Text);
            estudiante.costoPorClase = Convert.ToDecimal(txtCostoPorClase.Text);

            // Para obtener el costo total del curso        
            decimal valorTotal = estudiante.costoTotalCurso();

            // Creamos un objeto con el fin de pasar los datos de los estudiantes al formulario reporte
            ReporteDeDatos formularioReporte = new ReporteDeDatos();
            formularioReporte.txtIdentificacion.Text = txtIdentificacion.Text;
            formularioReporte.txtNombreDelEstudiante.Text = txtNombreDelEstudiante.Text;

            if (rbtnMasculino.Checked)
            {
                formularioReporte.rbtnMasculino.Checked = true;
            }
            else if (rbtnFemenino.Checked)
            {
                formularioReporte.rbtnFemenino.Checked = true;
            }
            formularioReporte.comboBox1.Text = comboBox1.SelectedItem.ToString();
            formularioReporte.txtClasesRecibidas.Text = txtClasesRecibidas.Text;
            formularioReporte.txtCostoPorClase.Text = txtCostoPorClase.Text;
            formularioReporte.txtCostoTotalCurso.Text = valorTotal.ToString();

            // Mostrar el formulario reporte
            formularioReporte.ShowDialog();

            // Cerrar formulario reporte
            this.Close();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Confirmación de salida
            DialogResult resultado = MessageBox.Show("¿Desea salir?", " Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNombreDelEstudiante_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

            bool error = false;
            foreach (char caracter in txtNombreDelEstudiante.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtNombreDelEstudiante, "No se permiten valores numéricos en este campo");
            }
            else
                errorProvider1.Clear();
        }

        private void DatosDeIngreso_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void validarCamposVacios()
        {
            var valores = !string.IsNullOrEmpty(txtNombreDelEstudiante.Text) &&
                !string.IsNullOrEmpty(txtIdentificacion.Text) &&
                !string.IsNullOrEmpty(txtCostoPorClase.Text) &&
                !string.IsNullOrEmpty(txtClasesRecibidas.Text) &&
                !string.IsNullOrEmpty(gboxGenero.Text) &&
                !string.IsNullOrEmpty(comboBox1.Text);
            btnGuardar.Enabled = valores;
        }

        private void txtClasesRecibidas_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

            bool error = false;
            foreach (char caracter in txtClasesRecibidas.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtClasesRecibidas, "Solo se permiten valores numéricos en este campo");
            }
            else
                errorProvider1.Clear();
        }

        private void txtCostoPorClase_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }
    }
}
