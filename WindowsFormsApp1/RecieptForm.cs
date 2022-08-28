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
    public partial class RecieptForm : Form
    {
        public RecieptForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void data()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP ENVY\Documents\Al-mazkhzundb.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            string query = "select * from ReceiptsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Receipts.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void RecieptForm_Load(object sender, EventArgs e)
        {
            data();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Shoprite Inventory System", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(Top));
            e.Graphics.DrawString("Date: " + Receipts.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(30, 70));
            e.Graphics.DrawString("Amount: " + Receipts.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(30, 100));
        }
    }
}
