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
    public partial class AddTicket : Form
    {
        public AddTicket()
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
                        Form1 main = this.Owner as Form1;
                        DataRow Row = main.база_данных2DataSet.Tickets.NewRow();
                        int rc = main.dataGridViewTickets.RowCount + 1;
                        int race = Convert.ToInt32(numericUpDownRaceID.Value) - 1;


                        Row[0] = rc;
                        Row[1] = numericUpDownClientID.Value;
                        Row[2] = main.база_данных2DataSet.Races.Rows[race][2];
                        Row[3] = main.база_данных2DataSet.Races.Rows[race][3];
                        Row[4] = numericUpDownSeatID.Value;
                        Row[5] = numericUpDownPrice.Value;
                        Row[6] = main.база_данных2DataSet.Races.Rows[race][4];

                        main.база_данных2DataSet.Tickets.Rows.Add(Row);
                        main.база_данных2DataSet.Tickets.AcceptChanges();
                        ticketsTableAdapter.Update(main.DB2DataSet.Tickets);
                        main.dataGridViewTickets.Refresh();

                        this.Close();
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
                MessageBox.Show("Data not saved" + ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных2DataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.база_данных2DataSet.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных2DataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.база_данных2DataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных2DataSet.Seats". При необходимости она может быть перемещена или удалена.
            this.seatsTableAdapter.Fill(this.база_данных2DataSet.Seats);

        }

        private void numericUpDownRaceID_ValueChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            int race = Convert.ToInt32(numericUpDownRaceID.Value) - 1;

            this.labelDep.Text = "Departure: " + main.база_данных2DataSet.Races.Rows[race][2];
            this.labelDes.Text = "Destination: " + main.база_данных2DataSet.Races.Rows[race][3];
            this.labelDat.Text = "Date: " + main.база_данных2DataSet.Races.Rows[race][4];
            this.labelTra.Text = "Transport: " + main.база_данных2DataSet.Races.Rows[race][1];
        }
    }
}
