using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pill_Identifier
{
    public partial class LoginForm : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
            con = new MySqlConnection(@"server=localhost;userid=root;password=Wtf@985632@;database=pharma");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user = usr_txtbox.Text;
            string pass = pass_txtbox.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM pharma.Users WHERE username = @username AND pass = @pass";
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {               
                Pill_Form pill_Form = new Pill_Form();
                this.Hide();
                pill_Form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login, please check username and password");
            }
            con.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
