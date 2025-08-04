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

    public partial class frm_studentlogin : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        int id;
        string b = "";

        public frm_studentlogin(int sid)
        {
            id = sid;
            InitializeComponent();

        }

        private void vIEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            cmd = new SqlCommand("Select * from studentinfo where sid=" + id + ";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox5.Text = dr[0].ToString();
                b = textBox6.Text = dr[1].ToString();
                textBox7.Text = dr[2].ToString();
                textbox1.Text = dr[3].ToString();
                textBox2.Text = dr[4].ToString();
                textBox8.Text = dr[5].ToString();
                textBox9.Text = dr[6].ToString();
                textBox3.Text = dr[7].ToString();
            }

            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        private void frm_studentlogin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void vIEWBATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            con.Open();
            cmd = new SqlCommand("Select batchinfo.*,cname from batchinfo,courseinfo, studentinfo where studentinfo.sid=" + id + "and courseinfo.cid=" + b + "and batchinfo.bid= studentinfo.bid;", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox14.Text = dr[0].ToString();
                textBox13.Text = dr[1].ToString();
                textBox17.Text = dr[2].ToString();
                textBox12.Text = dr[3].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vIEWATTENDENCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            con.Open();
            cmd = new SqlCommand("Select attendance.*,adetails.sid from attendance, adetails where  adetails.sid=" + id + "and attendance.aid=adetails.aid;", con);
            dr = cmd.ExecuteReader();
            listBox1.Items.Add(" AID " + " ADATE " + " BID" + " SID ");
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString() + "  " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            int[] s = new int[100];
            int i = -1, a = 0, sum = 0;
            float per, allp;
            con.Open();
            cmd = new SqlCommand("Select tdetails.sid,tdetails.tstatus,testinfo.* from testinfo, tdetails where  tdetails.sid=" + id + "and testinfo.ttid=tdetails.ttid;", con);
            dr = cmd.ExecuteReader();
            listBox2.Items.Add(" SID " + " TESTSTATUS " + "TID" + " TDATE " + " BID " + " PERCETANGE ");
            while (dr.Read())
            {
                if (int.TryParse(dr[1].ToString(), out int value) == true)
                {
                    
                    per = (float)value / 100 * 100;
                    s[++i] = value;
                    listBox2.Items.Add(dr[0].ToString() + "  " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString() + " " + per.ToString());
                }
                else
                    listBox2.Items.Add(dr[0].ToString() + "  " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString() + " " + "0");
            }
            while (a <= i)
            {
                sum += s[a];
                a++;
            }
            allp = (float)(sum * 100) / (float)((i + 1) * 100);
            label18.Text = allp.ToString() + " %";
            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
