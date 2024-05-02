using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных2DataSet.Races". При необходимости она может быть перемещена или удалена.
            this.racesTableAdapter.Fill(this.база_данных2DataSet.Races);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных2DataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.DB2DataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных2DataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.DB2DataSet.Tickets);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form add = new AddTicket();
            add.Owner = this;
            add.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            
            Form cli = new AddClient();
            cli.Owner = this;
            cli.Show();
        }

        private void Close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string msg = "Do you want to save the data?";
                string caption = "Save";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    this.clientsBindingSource.EndEdit();
                    this.clientsTableAdapter.Update(this.DB2DataSet.Clients);

                    this.ticketsTableAdapter.Fill(this.DB2DataSet.Tickets);

                    this.clientsBindingSource.EndEdit();
                    this.clientsTableAdapter.Update(this.DB2DataSet.Clients);

                    this.clientsTableAdapter.Fill(this.DB2DataSet.Clients);

                    база_данных2DataSet.WriteXmlSchema("DB2DataSet.xsd");

                    MessageBox.Show("Data saved", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not saved" + ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
