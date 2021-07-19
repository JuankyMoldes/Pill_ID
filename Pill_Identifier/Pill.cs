using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet.Security.Cryptography;
using Ubiety.Dns.Core.Records;

namespace Pill_Identifier
{
 
        class Pill
        {
            private string imprint;
            private string color;
            private string shape;
            private string drug_name;
            private string drug_strength;
            private string pill_photo;
            private string time;

            private MySqlConnection conn;


            public Pill()
            {
                string cs = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";
                
                conn = new MySqlConnection(cs);
                conn.Open();
            }

            public Pill(string imprint, string color, string shape, string drug_name, string drug_strength, string pill_photo, string time)
            {
                string cs = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";

            conn = new MySqlConnection(cs);
                conn.Open();

                Imprint = imprint;
                Color = color;
                Shape = shape;
                Drug_Name = drug_name;
                Drug_Strength = drug_strength;
                Pill_photo = pill_photo;
                Time = time;               
            }

            public void Add(Pill record)
            {
                string cs = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";

                conn = new MySqlConnection(cs);

                conn.Open();

                string sql = "INSERT INTO pharma.Pills(pill_imprint, pill_color, pill_shape, drug_name, drug_strength, pill_photo, creation_date) " +
                       " VALUES (@pill_imprint, @pill_color, @pill_shape, @drug_name, @drug_strength, @pill_photo, @creation_date)";

                
                var cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@pill_imprint", record.Imprint);
                cmd.Parameters.AddWithValue("@pill_color", record.Color);
                cmd.Parameters.AddWithValue("@pill_shape", record.Shape);
                cmd.Parameters.AddWithValue("@drug_name", record.Drug_Name);
                cmd.Parameters.AddWithValue("@drug_strength", record.Drug_Strength);
                cmd.Parameters.AddWithValue("@pill_photo", record.Pill_photo);
                cmd.Parameters.AddWithValue("@creation_date", DateTime.Now);      

                cmd.Prepare();              
                cmd.ExecuteNonQuery();

                closePill();
            }

            public void Modify(Pill record)
            {
                string cs = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";

                conn = new MySqlConnection(cs);
                conn.Open();
                
                string sql = "UPDATE pharma.Pills SET pill_color=@pill_color, pill_shape=@pill_shape, drug_name=@drug_name, drug_strength=@drug_strength, pill_photo=@pill_photo"
                +  " WHERE pill_imprint = @pill_imprint";
                var cmd = new MySqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@pill_imprint", record.Imprint);
                cmd.Parameters.AddWithValue("@pill_color", record.Color);
                cmd.Parameters.AddWithValue("@pill_shape", record.Shape);
                cmd.Parameters.AddWithValue("@drug_name", record.Drug_Name);
                cmd.Parameters.AddWithValue("@drug_strength", record.Drug_Strength);
                cmd.Parameters.AddWithValue("@pill_photo", record.Pill_photo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                closePill();
            }

            public Pill Identifier(string id)
            {
                string cs = @"server=localhost;userid=root;password=Wtf@985632@;database=pharma";

                conn = new MySqlConnection(cs);
                conn.Open();
                
                string sql = "SELECT * FROM pharma.Pills WHERE pill_imprint = @pill_imprint";
                Pill record = null;
                var cmd = new MySqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@pill_imprint", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();         
                                
                    while (reader.Read())
                    {
                        if (id != reader.GetString("pill_imprint"))
                        {
                            throw new ArgumentException("No pill found.", "id");
                        }
                        else
                        {
                            record = new Pill(reader.GetString("pill_imprint"), reader.GetString("pill_color"), reader.GetString("pill_shape"),
                             reader.GetString("drug_name"), reader.GetString("drug_strength"), reader.GetString("pill_photo"), reader.GetString("creation_date"));
                            MessageBox.Show(record.ToString());
                        }
                    }                      

                  reader.Close();
                  closePill();
                  return record;                
            }

            public void closePill()
            {
                conn.Close();
            }

        public override string ToString()
        {
            return string.Format("Imprint #: {0}\nColor: {1}\nShape: {2}\nName: {3}\nStrength: {4}\nPhoto Location: {5}\nDate Created: {6}", this.Imprint, this.Color, this.Shape, this.Drug_Name,
                this.Drug_Strength, this.Pill_photo, this.Time);
        }

            public string Imprint { get; set; }
            public string Color { get; set; }
            public string Shape { get; set; }
            public string Drug_Name { get; set; }
            public string Drug_Strength { get; set; }
            public string Pill_photo { get; set; }
            public string Time { get; set; }
        }
    
}
