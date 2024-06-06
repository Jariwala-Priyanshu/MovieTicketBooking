using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTicketBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8NH2GBN;Initial Catalog=movieDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into usertab values(@ID,@Movie,@Tickets,@SeatType,@Total)", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

            cmd.Parameters.AddWithValue("@Movie", comboBox1.GetItemText(comboBox1.SelectedItem));

            cmd.Parameters.AddWithValue("@Tickets", textBox2.Text);

            cmd.Parameters.AddWithValue("@SeatType", textBox3.Text);

            cmd.Parameters.AddWithValue("@Total", comboBox2.GetItemText(comboBox2.SelectedItem));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Submitted Successfully!");
        }
    }
}
