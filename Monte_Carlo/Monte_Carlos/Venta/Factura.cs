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
    public partial class Factura : Form
    {
        Conexion conexion;

        public Factura()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Venta ventana = new Menu_Venta();
            ventana.Show();
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT a.IdFactura,a.FechaActual as 'Fecha de venta',b.nombre as 'Nombre del cliente',c.nombre as 'Nombre del empleado' FROM ventas_comedor.factura a join ventas_comedor.cliente b on a.idCliente =b.idCliente  join  ventas_comedor.empleado c on c.idEmpleado =a.IdEmpleado;"));
            dgvFactura.DataSource = Datos;
            dgvFactura.Refresh();
        }
    }
}
