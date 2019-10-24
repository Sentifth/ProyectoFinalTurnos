using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogicadeNegocio;
namespace Program
{
    public partial class frm_CrearTickets : Form
    {
        private cls_clasificacion Clas = new cls_clasificacion();
        private cls_ticket Tick = new cls_ticket();
        private cls_cola Cola = new cls_cola();
        public frm_CrearTickets()
        {
            InitializeComponent();
        }

        private void Frm_CrearTickets_Load(object sender, EventArgs e)
        {
            this.Llenar_Datagrid();
        }

        private void Llenar_Datagrid()
        {
            try
            {
                DataTable dataTable = this.Clas.sp_listar_clasificacion();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.dataGridView1.Rows.Add(new object[]
                    {
                        dataTable.Rows[i][0].ToString(),
                        dataTable.Rows[i][1].ToString(),
                        dataTable.Rows[i][2].ToString()
                    });
                }
                if (this.dataGridView1.Rows.Count == 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Llenar_Datagrid()" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Btn_CrearTicket_Click(object sender, EventArgs e)
        {
            try
            {
                this.btn_CrearTicket.Enabled = false;
                if (!this.funcionDemoFinalizo())
                {
                    if (this.dataGridView1.Rows.Count != 0)
                    {
                        int index = this.dataGridView1.CurrentRow.Index;
                        this.Tick.codigo = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
                        DataTable dataTable = this.Tick.sp_registrar_ticket();
                        long num = Convert.ToInt64(dataTable.Rows[0][1].ToString());
                        dataTable = this.Tick.sp_listar_tickets_xcodigo();
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            if (num == Convert.ToInt64(dataTable.Rows[i][0].ToString()))
                            {
                                this.Tick.id = Convert.ToInt64(dataTable.Rows[i][0].ToString());
                                this.Tick.codigo = dataTable.Rows[i][1].ToString();
                                this.Tick.codigo_numeracion = this.Tick.codigo + "-" + (i + 1);
                                this.Tick.modulo = (int)Convert.ToInt16(dataTable.Rows[i][3].ToString());
                                this.Tick.estado = (int)Convert.ToInt16(dataTable.Rows[i][4].ToString());
                                this.Tick.sp_actualizar_ticket();
                                new frm_Imprimir_Ticket
                                {
                                   
                                }.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: btn_CrearTicket_Click \n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                this.btn_CrearTicket.Enabled = true;
            }
        }
        public bool funcionDemoFinalizo()
        {
            int num = 20;
            this.Text = "VERSION DEMO";
            DataTable dataTable = this.Cola.sp_listar_cola();
            long num2 = 0L;
            if (dataTable.Rows.Count > 0)
            {
                num2 = Convert.ToInt64(dataTable.Rows[0][0].ToString());
            }
            if (num2 > (long)num)
            {
                MessageBox.Show("Esta es una VERSION DE PRUEBA. No puede crear más tickets", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            return false;
        }
    }
}
