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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            String claveCorrecta = "123";

            if (txtIngreso.Text == claveCorrecta)
            {
                MessageBox.Show("¡Bienvenido a la App Melodías Perfectas!", "Acceso Concedido",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Pasar al siguiente formulario
                DatosDeIngreso datos = new DatosDeIngreso();
                datos.Show();

                //Para cerrar el formulario de acceso
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Contraseña Incorrecta, Intente Nuevamente", "Acceso Denegado",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Permitir que el usuario ingrese de nuevo la contraseña
                txtIngreso.Clear();
                txtIngreso.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIngreso.Enabled = false;
        }

        private void validarCamposVacios()
        {
            var vr = !string.IsNullOrEmpty(txtIngreso.Text);
            btnIngreso.Enabled = vr;
        }
    }
}
