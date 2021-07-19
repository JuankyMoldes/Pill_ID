using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pill_Identifier
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"server = localhost; userid = root; password = ProjectPassword; database = pharma";
            string query = "SELECT * FROM pharma.Pills";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
