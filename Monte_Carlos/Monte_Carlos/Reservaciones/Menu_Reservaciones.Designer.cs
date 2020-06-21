namespace Monte_Carlos.Reservaciones
{
    partial class Menu_Reservaciones
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
            this.btnInsertarReservacion = new System.Windows.Forms.Button();
            this.btnModificarReservacion = new System.Windows.Forms.Button();
            this.btnEliminarReservacion = new System.Windows.Forms.Button();
            this.btnVerReservacion = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertarReservacion
            // 
            this.btnInsertarReservacion.Location = new System.Drawing.Point(109, 42);
            this.btnInsertarReservacion.Name = "btnInsertarReservacion";
            this.btnInsertarReservacion.Size = new System.Drawing.Size(277, 157);
            this.btnInsertarReservacion.TabIndex = 2;
            this.btnInsertarReservacion.Text = "Insertar  Reservacion";
            this.btnInsertarReservacion.UseVisualStyleBackColor = true;
            this.btnInsertarReservacion.Click += new System.EventHandler(this.btnInsertarReservacion_Click);
            // 
            // btnModificarReservacion
            // 
            this.btnModificarReservacion.Location = new System.Drawing.Point(465, 42);
            this.btnModificarReservacion.Name = "btnModificarReservacion";
            this.btnModificarReservacion.Size = new System.Drawing.Size(277, 157);
            this.btnModificarReservacion.TabIndex = 3;
            this.btnModificarReservacion.Text = "Modificar Reservacion";
            this.btnModificarReservacion.UseVisualStyleBackColor = true;
            this.btnModificarReservacion.Click += new System.EventHandler(this.btnModificarReservacion_Click);
            // 
            // btnEliminarReservacion
            // 
            this.btnEliminarReservacion.Location = new System.Drawing.Point(109, 232);
            this.btnEliminarReservacion.Name = "btnEliminarReservacion";
            this.btnEliminarReservacion.Size = new System.Drawing.Size(277, 157);
            this.btnEliminarReservacion.TabIndex = 4;
            this.btnEliminarReservacion.Text = "Eliminar Reservacion";
            this.btnEliminarReservacion.UseVisualStyleBackColor = true;
            this.btnEliminarReservacion.Click += new System.EventHandler(this.btnEliminarReservacion_Click);
            // 
            // btnVerReservacion
            // 
            this.btnVerReservacion.Location = new System.Drawing.Point(465, 232);
            this.btnVerReservacion.Name = "btnVerReservacion";
            this.btnVerReservacion.Size = new System.Drawing.Size(277, 157);
            this.btnVerReservacion.TabIndex = 5;
            this.btnVerReservacion.Text = " Ver Reservacion";
            this.btnVerReservacion.UseVisualStyleBackColor = true;
            this.btnVerReservacion.Click += new System.EventHandler(this.btnVerReservacion_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(79, 450);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Menu_Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnVerReservacion);
            this.Controls.Add(this.btnEliminarReservacion);
            this.Controls.Add(this.btnModificarReservacion);
            this.Controls.Add(this.btnInsertarReservacion);
            this.Name = "Menu_Reservaciones";
            this.Text = "Menu_Reservaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarReservacion;
        private System.Windows.Forms.Button btnModificarReservacion;
        private System.Windows.Forms.Button btnEliminarReservacion;
        private System.Windows.Forms.Button btnVerReservacion;
        private System.Windows.Forms.Button btnReturn;
    }
}