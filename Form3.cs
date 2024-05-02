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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Do you want to add new ticket?";
                string caption = "Message";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (textBoxName.Text != "" || textBoxSur.Text != "" || textBoxCity.Text != "")
                        {
                            Form1 main = this.Owner as Form1;
                            DataRow nRow = main.DB2DataSet.Clients.NewRow();
                            int rc = main.dataGridViewClients.RowCount + 1;

                            nRow[0] = rc;
                            nRow[1] = textBoxName.Text;
                            nRow[2] = textBoxSur.Text;
                            nRow[3] = dateTimePicker1.Value;
                            nRow[4] = textBoxCity.Text;

                            main.DB2DataSet.Clients.Rows.Add(nRow);
                            main.DB2DataSet.Clients.AcceptChanges();
                            main.dataGridViewClients.Refresh();

                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string err = "Fill all fields properly!" + '\n' + ex;
                        string c = "Error";
                        buttons = MessageBoxButtons.OK;
                        ico = MessageBoxIcon.Question;

                        result = MessageBox.Show(this, err, c, buttons, ico);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not saved" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
