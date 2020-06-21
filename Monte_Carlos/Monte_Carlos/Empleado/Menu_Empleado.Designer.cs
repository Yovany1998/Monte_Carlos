namespace Monte_Carlos.Empleado
{
    partial class Menu_Empleado
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
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnInsertarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.Maroon;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(463, 59);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(277, 157);
            this.btnModificarEmpleado.TabIndex = 3;
            this.btnModificarEmpleado.Text = "Modificar Empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnInsertarEmpleado
            // 
            this.btnInsertarEmpleado.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertarEmpleado.Location = new System.Drawing.Point(114, 59);
            this.btnInsertarEmpleado.Name = "btnInsertarEmpleado";
            this.btnInsertarEmpleado.Size = new System.Drawing.Size(277, 157);
            this.btnInsertarEmpleado.TabIndex = 4;
            this.btnInsertarEmpleado.Text = "Insertar Empleado";
            this.btnInsertarEmpleado.UseVisualStyleBackColor = false;
            this.btnInsertarEmpleado.Click += new System.EventHandler(this.btnInsertarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(114, 239);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(277, 157);
            this.btnEliminarEmpleado.TabIndex = 5;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Maroon;
            this.btnVer.Location = new System.Drawing.Point(463, 239);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(277, 157);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver Empleado";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            // Menu_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnInsertarEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Name = "Menu_Empleado";
            this.Text = "Menu_Empleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnInsertarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnReturn;
    }
}