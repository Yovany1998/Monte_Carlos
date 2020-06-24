using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Venta
{
    public partial class Pago : Form
    {

        Conexion conexion;
        private int state;
        private Ventas venta;

        public Pago()
        {
            InitializeComponent();
            venta = new Ventas();
            conexion = new Conexion();
        }

        private void BtnGenerarPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            Generar_Venta ventana = new Generar_Venta();
            ventana.Show();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            int Id = 0;

            DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idProducto as 'Producto',precio as 'Precio',Cantidad,Descuento,Total FROM DetalleDeVenta  where idVenta = {0};", Id));
            dgvVenta.DataSource = Datos;
            dgvVenta.Refresh();
        }
    }
}
