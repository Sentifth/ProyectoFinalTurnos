namespace Program
{
    partial class frm_SelectorInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SelectorInicio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Configurar = new System.Windows.Forms.Button();
            this.btn_Pantalla = new System.Windows.Forms.Button();
            this.btn_AtenderClientes = new System.Windows.Forms.Button();
            this.btn_CrearTickets = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Configurar);
            this.groupBox1.Controls.Add(this.btn_Pantalla);
            this.groupBox1.Controls.Add(this.btn_AtenderClientes);
            this.groupBox1.Controls.Add(this.btn_CrearTickets);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Configurar
            // 
            this.btn_Configurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Configurar.BackgroundImage")));
            this.btn_Configurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Configurar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configurar.Location = new System.Drawing.Point(651, 28);
            this.btn_Configurar.Name = "btn_Configurar";
            this.btn_Configurar.Size = new System.Drawing.Size(182, 136);
            this.btn_Configurar.TabIndex = 3;
            this.btn_Configurar.Text = "Configurar";
            this.btn_Configurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Configurar.UseVisualStyleBackColor = true;
            this.btn_Configurar.Click += new System.EventHandler(this.Btn_Configurar_Click);
            // 
            // btn_Pantalla
            // 
            this.btn_Pantalla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pantalla.BackgroundImage")));
            this.btn_Pantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pantalla.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pantalla.Location = new System.Drawing.Point(437, 28);
            this.btn_Pantalla.Name = "btn_Pantalla";
            this.btn_Pantalla.Size = new System.Drawing.Size(182, 136);
            this.btn_Pantalla.TabIndex = 2;
            this.btn_Pantalla.Text = "Pantalla";
            this.btn_Pantalla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pantalla.UseVisualStyleBackColor = true;
            this.btn_Pantalla.Click += new System.EventHandler(this.Btn_Pantalla_Click);
            // 
            // btn_AtenderClientes
            // 
            this.btn_AtenderClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AtenderClientes.BackgroundImage")));
            this.btn_AtenderClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AtenderClientes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtenderClientes.Location = new System.Drawing.Point(226, 28);
            this.btn_AtenderClientes.Name = "btn_AtenderClientes";
            this.btn_AtenderClientes.Size = new System.Drawing.Size(182, 136);
            this.btn_AtenderClientes.TabIndex = 1;
            this.btn_AtenderClientes.Text = "Atender Clientes";
            this.btn_AtenderClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AtenderClientes.UseVisualStyleBackColor = true;
            this.btn_AtenderClientes.Click += new System.EventHandler(this.Btn_AtenderClientes_Click);
            // 
            // btn_CrearTickets
            // 
            this.btn_CrearTickets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CrearTickets.BackgroundImage")));
            this.btn_CrearTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CrearTickets.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearTickets.Location = new System.Drawing.Point(16, 28);
            this.btn_CrearTickets.Name = "btn_CrearTickets";
            this.btn_CrearTickets.Size = new System.Drawing.Size(182, 136);
            this.btn_CrearTickets.TabIndex = 0;
            this.btn_CrearTickets.Text = "Crear Tickets";
            this.btn_CrearTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CrearTickets.UseVisualStyleBackColor = true;
            this.btn_CrearTickets.Click += new System.EventHandler(this.Btn_CrearTickets_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Menu.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.Color.Black;
            this.lbl_Menu.Location = new System.Drawing.Point(373, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(148, 67);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "Menú";
            // 
            // frm_SelectorInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SelectorInicio";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_SelectorInicio_FormClosed);
            this.Load += new System.EventHandler(this.Frm_SelectorInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Configurar;
        private System.Windows.Forms.Button btn_Pantalla;
        private System.Windows.Forms.Button btn_AtenderClientes;
        private System.Windows.Forms.Button btn_CrearTickets;
        private System.Windows.Forms.Label lbl_Menu;
    }
}

