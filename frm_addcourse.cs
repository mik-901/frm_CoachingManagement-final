using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_CoachingManagement
{
    public partial class frm_addcourse : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public frm_addcourse()
        {
            InitializeComponent();
        }

        private void frm_addcourse_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = 100;
            int r;
            string id1 = "Select max(cid) from courseinfo";
            con.Open();
            cmd = new SqlCommand(id1, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() != "")
                    ind = Convert.ToInt32(dr[0].ToString());
            }
            ind++;
            dr.Close();

            string sql2 = "insert into courseinfo values(" + ind + ",'" + tb1.Text + "'," + tb2.Text + ");";
            cmd = new SqlCommand(sql2, con);
            r = cmd.ExecuteNonQuery();
            if (r != 0)
            {
                MessageBox.Show("COURSE UPDATED!");
            }
            else
            {
                MessageBox.Show("ERROR OCCURED!");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
