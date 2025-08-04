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
    public partial class defaulterlist : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public defaulterlist()
        {
            InitializeComponent();
        }

        private void defaulterlist_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select studentinfo.*, courseinfo.cfees from studentinfo, courseinfo  where studentinfo.cid= courseinfo.cid", con);
            dr = cmd.ExecuteReader();
            listBox1.Items.Add(" STDID " + " COURSEID " + " BATCHID " + " NAME " + " CONTACT " + " PAYMENT(Y/N) " + " STUDENTACTIVE " + " TOTAL AMOUNT " + " AMOUNT SUBMITTED " + " AMOUNT REMAINING ");
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString() + "  " + dr[1].ToString() + "  " + dr[2].ToString() + "  " + dr[3].ToString() + "  " + dr[4].ToString() + "  " + dr[5] + "  " + dr[6] + "  " + dr[7].ToString() + "  " + dr[8].ToString() + "  " + (Convert.ToInt32(dr[8].ToString()) - Convert.ToInt32(dr[7].ToString())));
            }
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
