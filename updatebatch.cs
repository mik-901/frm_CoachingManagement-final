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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace frm_CoachingManagement
{
    public partial class updatebatch : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;

        public updatebatch()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("Select bid from batchinfo where cid=" + comboBox1.SelectedItem.ToString() + ";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void updatebatch_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select cid from courseinfo;", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            con.Open();
            cmd = new SqlCommand("update batchinfo set bactive='" + comboBox2.SelectedItem.ToString() + "'where bid=" +comboBox3.SelectedItem.ToString()+";", con);
            r = cmd.ExecuteNonQuery();
            if (r != 0)
            {
                MessageBox.Show("UPDATED!");
            }
            else
            {
                MessageBox.Show("ERROR OCCURED!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
