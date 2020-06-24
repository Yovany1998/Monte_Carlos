using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Reservaciones
{
    public partial class Insertar_Reservaciones : Form
    {
        private Reservacion reservacion;
        Conexion conexion;
        public Insertar_Reservaciones()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reservaciones ventana = new Menu_Reservaciones();
            ventana.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            reservacion.Idreservacion = txtCodigo.Text;
            reservacion.IdMesa = txtMesa.Text;
            reservacion.DateFecha = Convert.ToDateTime (dateFecha);
            reservacion.Hora = Convert.ToInt32 (txtHora.Text);
            if (reservacion.Guardar())
            {
                MessageBox.Show("Registro guardado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", reservacion.Error.ToString()), "Reservacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtMesa.Text = "";
            txtHora.Text = "";

           
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reservaciones ventana = new Menu_Reservaciones();
            ventana.Show();
        }
    }
}
