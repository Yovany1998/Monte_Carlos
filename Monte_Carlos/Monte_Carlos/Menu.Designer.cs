namespace Monte_Carlos
{
    partial class Menu
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btnservicio = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.btnReservaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncliente.Location = new System.Drawing.Point(73, 35);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(126, 75);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnempleado
            // 
            this.btnempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnempleado.Location = new System.Drawing.Point(73, 139);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(126, 75);
            this.btnempleado.TabIndex = 1;
            this.btnempleado.Text = "Empleado";
            this.btnempleado.UseVisualStyleBackColor = false;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btnservicio
            // 
            this.btnservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnservicio.Location = new System.Drawing.Point(230, 32);
            this.btnservicio.Name = "btnservicio";
            this.btnservicio.Size = new System.Drawing.Size(135, 80);
            this.btnservicio.TabIndex = 2;
            this.btnservicio.Text = "Servicio";
            this.btnservicio.UseVisualStyleBackColor = false;
            this.btnservicio.Click += new System.EventHandler(this.btnservicio_Click);
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Venta.Location = new System.Drawing.Point(230, 142);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(139, 72);
            this.Venta.TabIndex = 3;
            this.Venta.Text = "Venta";
            this.Venta.UseVisualStyleBackColor = false;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReservaciones.Location = new System.Drawing.Point(73, 232);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(126, 76);
            this.btnReservaciones.TabIndex = 4;
            this.btnReservaciones.Text = "Reservacion";
            this.btnReservaciones.UseVisualStyleBackColor = false;
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(453, 364);
            this.Controls.Add(this.btnReservaciones);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.btnservicio);
            this.Controls.Add(this.btnempleado);
            this.Controls.Add(this.btncliente);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btnservicio;
        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.Button btnReservaciones;
    }
}