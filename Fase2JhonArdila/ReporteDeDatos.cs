using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2JhonArdila
{
    public partial class ReporteDeDatos : Form
    {
        public ReporteDeDatos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            // Crear objeto para regresar al formulario de Datos de Acceso
            DatosDeIngreso accesoForm = new DatosDeIngreso();

            // Cerrar formulario reporte
            this.Close();

            // Volver al formulario de datos de acceso en blanco
            accesoForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCostoTotalCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReporteDeDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
