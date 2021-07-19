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

    public partial class Pill_Form : Form
    {
        public Pill_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";
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

            button1.Enabled = false;
            button1.Visible = false;
        }


        private void addPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprint_txtbox.Text = "";
            color_txtbox.Text = "";
            shape_txtbox.Text = "";
            drugName_txtbox.Text = "";
            strength_txtbox.Text = "";

            imprint_txtbox.Enabled = true;
            color_txtbox.Enabled = true;
            shape_txtbox.Enabled = true;
            drugName_txtbox.Enabled = true;
            strength_txtbox.Enabled = true;
            photo_btn.Enabled = true;

            button1.Enabled = true;
            button1.Visible = true;

            button3.Enabled = false;
            button3.Visible = false;

            button2.Enabled = false;
            button2.Visible = false;

            button4.Enabled = false;
            button4.Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void photo_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i = imprint_txtbox.Text;
            string c = color_txtbox.Text;
            string s = shape_txtbox.Text;
            string n = drugName_txtbox.Text;
            string str = (strength_txtbox.Text);
            string ph = openFileDialog1.FileName;
            string t = DateTime.Now.ToString();
            Pill a = new Pill(i, c, s, n, str, ph, t);

            a.Add(a);

            string connectionString = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";
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

            imprint_txtbox.Enabled = false;
            color_txtbox.Enabled = false;
            shape_txtbox.Enabled = false;
            drugName_txtbox.Enabled = false;
            strength_txtbox.Enabled = false;
            photo_btn.Enabled = false;

            clear();

        }

        private void modifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprint_txtbox.Enabled = true;
            color_txtbox.Enabled = false;
            shape_txtbox.Enabled = false;
            drugName_txtbox.Enabled = false;
            strength_txtbox.Enabled = false;
            photo_btn.Enabled = false;

            button2.Visible = true;
            button2.Enabled = true;

            button1.Enabled = false;
            button1.Visible = false;

            button3.Enabled = false;
            button3.Visible = false;

            button4.Enabled = false;
            button4.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            color_txtbox.Enabled = true;
            shape_txtbox.Enabled = true;
            drugName_txtbox.Enabled = true;
            strength_txtbox.Enabled = true;
            photo_btn.Enabled = true;
            imprint_txtbox.Enabled = false;


            button1.Enabled = false;
            button1.Visible = false;

            button3.Enabled = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.Visible = false;
            
            string i = imprint_txtbox.Text;
            string c = color_txtbox.Text;
            string s = shape_txtbox.Text;
            string n = drugName_txtbox.Text;
            string str = strength_txtbox.Text;
            string ph = openFileDialog1.FileName;
            string t = DateTime.Now.ToString();
            Pill a = new Pill(i, c, s, n, str, ph, t);

            a.Modify(a);

            string connectionString = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";
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

            clear();
        }

        private void pillIdentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprint_txtbox.Enabled = true;
            color_txtbox.Enabled = false;
            shape_txtbox.Enabled = false;
            drugName_txtbox.Enabled = false;
            strength_txtbox.Enabled = false;
            photo_btn.Enabled = false;

            button4.Enabled = true;
            button4.Visible = true;

            button1.Enabled = false;
            button1.Visible = false;

            button3.Enabled = false;
            button3.Visible = false;

            button2.Enabled = false;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pill p = new Pill();
            string i = imprint_txtbox.Text;

            p.Identifier(i);
            clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            rp.Show();
        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Pill: \n\n Enter all the fields and select the photo. Once done click \"Submit\" to safe. " +
                            "\n\n Modify Pill: \n\n Enter the pill imprint # and click \"Check\" then enter all the remaining fields you wish to change. Once done, click \" Modify\". " +
                            "\n\n Pill Identifier: \n\n Enter the pill imprint # and click \"Search\" and a display will appear showing all the details on the pill. " +
                            "\n\n Pill Report: \n\n A window will appear showing all pills and details available.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Juancarlos Moldes Hernández");
        }

        private void clear()
        {
            imprint_txtbox.Text = "";
            color_txtbox.Text = "";
            shape_txtbox.Text = "";
            drugName_txtbox.Text = "";
            strength_txtbox.Text = "";

            imprint_txtbox.Enabled = false;
            color_txtbox.Enabled = false;
            shape_txtbox.Enabled = false;
            drugName_txtbox.Enabled = false;
            strength_txtbox.Enabled = false;
            photo_btn.Enabled = false;

            pictureBox1.Image = null;

            button4.Enabled = false;
            button4.Visible = false;

            button1.Enabled = false;
            button1.Visible = false;

            button3.Enabled = false;
            button3.Visible = false;

            button2.Enabled = false;
            button2.Visible = false;
        }
    }
} 
