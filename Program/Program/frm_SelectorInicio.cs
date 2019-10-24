using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class frm_SelectorInicio : Form
    {
        public frm_SelectorInicio()
        {
            InitializeComponent();
        }

        private void Frm_SelectorInicio_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CrearTickets_Click(object sender, EventArgs e)
        {
            this.open_forms(1);
        }

        private void Btn_AtenderClientes_Click(object sender, EventArgs e)
        {
            this.open_forms(2);
        }

        private void Btn_Pantalla_Click(object sender, EventArgs e)
        {
            this.open_forms(3);
        }

        private void Btn_Configurar_Click(object sender, EventArgs e)
        {
            this.open_forms(4);
        }

        private void open_forms(int imenu)
        {
            this.groupBox1.Enabled = false;
            base.Hide();
            switch (imenu)
            {
                case 1:

                    {
                        frm_CrearTickets frm_CrearTickets = new frm_CrearTickets();
                        frm_CrearTickets.ShowDialog();
                        break;
                    }
                case 2:

                    {
                        frm_AtencionCliente frm_AtencionCliente = new frm_AtencionCliente();
                        frm_AtencionCliente.ShowDialog();
                        break;
                    }
                case 3:

                    {
                        frm_Pantalla frm_Pantalla = new frm_Pantalla();
                        frm_Pantalla.ShowDialog();
                        break;
                    }
                case 4:

                    {
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.ShowDialog();
                        break;
                    }
            }
            this.groupBox1.Enabled = true;
            base.Show();
        }

        private void Frm_SelectorInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.Dispose();
        }
    }
}
