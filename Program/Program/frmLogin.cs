using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaAccesoaDatos;
namespace Program
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.lbl_nueva_clave.Visible = false;
            this.txt_nueva_clave.Visible = false;
            this.cargar_datos();
        }
        private void Chk_cambiar_clave_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_cambiar_clave.Checked)
            {
                this.lbl_nueva_clave.Visible = true;
                this.txt_nueva_clave.Visible = true;
                this.txt_clave.Focus();
                return;
            }
            this.lbl_nueva_clave.Visible = false;
            this.txt_nueva_clave.Visible = false;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }
        private void Escribir(string archivo, string valor)
        {
            
        }
        private void cargar_datos()
        {
            
        }
        private void txt_clave_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (this.chk_cambiar_clave.Checked)
                {
                    this.txt_nueva_clave.Focus();
                    return;
                }
                this.Btn_aceptar_Click(null, null);
            }
        }

        private void Txt_nueva_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 && this.chk_cambiar_clave.Checked)
            {
                this.Btn_aceptar_Click(null, null);
            }
        }

     
    }
}
