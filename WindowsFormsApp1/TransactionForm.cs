using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int sum = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (DateText.Text == "" || AmtText.Text == "")
            {
                MessageBox.Show("Please fill in all required information");
            }
            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP ENVY\Documents\Al-mazkhzundb.mdf;Integrated Security=True;Connect Timeout=30");
                    Con.Open();
                    string query = "insert into ReceiptsTbl values(" + DateText.Text + ", '" + sum + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Receipt recorded successfully");
                    Con.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DateText.Text == "" || ItemText.Text == "" || Quantitytext.Text == "" || PriceTextt.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
                int ProdTotal = Convert.ToInt32(PriceTextt.Text) * Convert.ToInt32(Quantitytext.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(transData);
                newRow.Cells[0].Value = DateText.Text;
                newRow.Cells[1].Value = ItemText.Text;
                newRow.Cells[2].Value = Quantitytext.Text;
                newRow.Cells[3].Value = PriceTextt.Text;
                newRow.Cells[4].Value = Convert.ToInt32(PriceTextt.Text) * Convert.ToInt32(Quantitytext.Text);
                transData.Rows.Add(newRow);
                sum = sum + ProdTotal;

                AmtText.Text = "GHS " + sum;
            }
        }
    }
}
