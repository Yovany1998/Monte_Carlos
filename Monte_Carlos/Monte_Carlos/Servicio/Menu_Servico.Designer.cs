namespace Monte_Carlos.Servicio
{
    partial class Menu_Servico
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
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnInsertarPedido = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(400, 290);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(277, 157);
            this.btnVerPedido.TabIndex = 0;
            this.btnVerPedido.Text = "Ver Pedido";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // btnInsertarPedido
            // 
            this.btnInsertarPedido.Location = new System.Drawing.Point(101, 31);
            this.btnInsertarPedido.Name = "btnInsertarPedido";
            this.btnInsertarPedido.Size = new System.Drawing.Size(277, 157);
            this.btnInsertarPedido.TabIndex = 1;
            this.btnInsertarPedido.Text = "Insertar Pedido";
            this.btnInsertarPedido.UseVisualStyleBackColor = true;
            this.btnInsertarPedido.Click += new System.EventHandler(this.btnInsertarPedido_Click);
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
            this.btnReturn.Size = new System.Drawing.Size(79, 556);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(400, 31);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(277, 157);
            this.btnModificarPedido.TabIndex = 7;
            this.btnModificarPedido.Text = "Modificar Pedido";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(101, 290);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(277, 157);
            this.btnEliminarPedido.TabIndex = 8;
            this.btnEliminarPedido.Text = "Eliminar Pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // Menu_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(707, 556);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnInsertarPedido);
            this.Controls.Add(this.btnVerPedido);
            this.Name = "Menu_Servico";
            this.Text = "Menu_Servico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Button btnInsertarPedido;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
    }
}