﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Servicio
{
    public partial class Ver_Pedido : Form
    {
        public Ver_Pedido()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Servico ventana = new Menu_Servico();
            ventana.Show();
        }
    }
}
