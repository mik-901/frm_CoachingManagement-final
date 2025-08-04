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
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_CoachingManagement
{
    public partial class frm_batchinfo : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public frm_batchinfo()
        {
            InitializeComponent();
        }

        private void frm_batchinfo_Load(object sender, EventArgs e)
        {
            tb1.Enabled = false;
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select cname from courseinfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() != "")
                {
                    cb1.Items.Add(dr[0].ToString());
                }
            }
            cb1.Text = "";
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int ind = 0, sql1 = 100, r;
            string id1 = "select max(bid) from batchinfo";
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
            cmd = new SqlCommand("select cid from courseinfo where cname='" + cb1.SelectedItem.ToString() + "';", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() != "")
                    sql1 = Convert.ToInt32(dr[0].ToString());

            }
            dr.Close();
            string sql2 = "insert into batchinfo values(" + ind + "," + sql1 + ",'" + cb2.SelectedItem.ToString() + "');";
            cmd = new SqlCommand(sql2, con);
            r = cmd.ExecuteNonQuery();
            if (r != 0)
            {
                MessageBox.Show("BATCH GENERATED!");
            }
            else
            {
                MessageBox.Show("ERROR OCCURED!");
            }
            tb1.Text = ind.ToString();
            con.Close();
            cmd.Dispose();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
