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
    public partial class frm_teacherlogin : Form
    {
        int id, i = -1, k = -1;
        string bid, cid;
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        string[] s = new string[100];
        string[] p = new string[100];

        public frm_teacherlogin(int tid)
        {

            id = tid;
            InitializeComponent();
        }

        private void frm_teacherlogin_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            label12.Visible = false;
            label5.Visible = false;
            label10.Visible = false;
            panel4.Enabled = false;
            panel4.Visible = false;
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
        }

        private void vIEWPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label12.Visible = true;

            cmd = new SqlCommand("Select * from teachersinfo where tid=" + id + ";", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox5.Text = dr[0].ToString();
                textbox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox6.Text = dr[3].ToString();
                cid = textBox7.Text = dr[4].ToString();
                bid = textBox4.Text = dr[5].ToString();
            }

            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        private void aTTENDENDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label5.Visible = true;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            con.Open();
            cmd = new SqlCommand("Select sid, sname from studentinfo where bid=" + bid + ";", con);
            dr = cmd.ExecuteReader();
            listBox1.Items.Add(" SID " + " SNAME ");
            listBox2.Items.Add("A/P");
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString() + "  " + dr[1].ToString());
                listBox2.Items.Add("A");
                s[++i] = dr[0].ToString() + "    " + dr[1].ToString() + "    " + "A";

            }
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            int r, did = -1, ind = 0;
            DateTime date = dateTimePicker1.Value;
            string formattedDate = date.ToString("yyyy-MM-dd");
            sql = "Select aid from attendance where bid= @bid  and adate= @adate;";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@adate", formattedDate);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && !string.IsNullOrWhiteSpace(dr[0].ToString()))
                    did = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            sql = "delete from adetails where aid=" + did + ";";
            cmd = new SqlCommand(sql, con);
            r = cmd.ExecuteNonQuery();
            sql = "delete from attendance where aid=" + did + ";";
            cmd = new SqlCommand(sql, con);
            r = cmd.ExecuteNonQuery();
            con.Close();
            ind = 0;
            sql = "select max(aid) from attendance";
            con.Open();
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        ind = Convert.ToInt32(dr[0].ToString());
                }
            }
            dr.Close();
            ind++;
            sql = "insert into attendance values(" + ind + ",'" + formattedDate + "'," + bid + ");";
            cmd = new SqlCommand(sql, con);
            r = cmd.ExecuteNonQuery();
            if (r == 0)
                MessageBox.Show("Some problem Occured");
            else
            {
                //insert
                sql = "";
                for (int j = 0; j < (i + 1); j++)
                {
                    sql += "(" + ind + "," + s[j].Substring(0, s[j].IndexOf(" ")) + "),";
                }
                sql = sql.Substring(0, sql.Length - 1);
                sql = "insert into adetails values" + sql + ";";
                cmd = new SqlCommand(sql, con);
                int r1 = cmd.ExecuteNonQuery();
                if (r1 == 0)
                    MessageBox.Show("Some problem Occured");
                else
                    MessageBox.Show("MARKED!");
            }
            con.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "";
            if (listBox2.Items[listBox1.SelectedIndex] != null && listBox2.Items[listBox1.SelectedIndex].ToString().CompareTo("A") == 0)
            {
                a = s[listBox1.SelectedIndex - 1].Substring(0, s[listBox1.SelectedIndex - 1].Length - 1) + "P";
                s[listBox1.SelectedIndex - 1] = a;
            }
            else
                s[listBox1.SelectedIndex - 1] = s[listBox1.SelectedIndex - 1].Substring(0, s[listBox1.SelectedIndex - 1].Length - 1) + "A";
            listBox2.Items.Clear();
            listBox2.Items.Add("A/P");
            for (int j = 0; j < (i + 1); j++)
            {
                listBox2.Items.Add(s[j][s[j].Length - 1]);
            }

        }

        private void tESTREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Enabled = true;
            label10.Visible = true;
            textBox3.Enabled = false;
            textBox8.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            con.Open();
            cmd = new SqlCommand("Select sid, sname from studentinfo where bid=" + bid + ";", con);
            dr = cmd.ExecuteReader();
            listBox3.Items.Add(" SID " + " SNAME " + " MARKS OBTAINED");
            while (dr.Read())
            {
                listBox3.Items.Add(dr[0].ToString() + "  " + dr[1].ToString() + "  " + "A");
                p[++k] = dr[0].ToString() + " " + dr[1].ToString() + " " + "A";

            }

            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void refreshlistbox()
        {
            string subs;
            listBox3.Items.Clear();
            listBox3.Items.Add(" SID " + " SNAME " + " MARKS OBTAINED");
            for (int j = 0; j < k + 1; j++)
            {
                string[] s = p[j].Split(" ");
                listBox3.Items.Add(s[0] + "  " + s[1] + "  " + s[2]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sql;
            int r, ind = 0;
            DateTime date = dateTimePicker1.Value;
            string formattedDate = date.ToString("yyyy-MM-dd");
            ind = 0;
            sql = "select max(ttid) from testinfo";
            con.Open();
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        ind = Convert.ToInt32(dr[0].ToString());
                }
            }
            dr.Close();
            ind++;
            sql = "insert into testinfo values(" + ind + ",'" + formattedDate + "'," + bid + ");";
            cmd = new SqlCommand(sql, con);
            r = cmd.ExecuteNonQuery();
            if (r == 0)
                MessageBox.Show("ERROR");
            else
            {
                sql = "";
                string[] s1 = new string[3];
                for (int j = 1; j <= (k + 1); j++)
                {
                    s1 = listBox3.Items[j].ToString().Split("  ");
                    sql += "(" + ind + "," + s1[0] + ",'" + s1[2] + "'),";
                }
                sql = "insert into tdetails values" + sql.Substring(0, sql.Length - 1) + ";";
                cmd = new SqlCommand(sql, con);
                int r1 = cmd.ExecuteNonQuery();
                if (r1 == 0)
                    MessageBox.Show("ERROR");
                else
                    MessageBox.Show("UPDATED ");
                refreshlistbox();
            }
            con.Close();

            listBox3.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] l = { };
            panel4.Visible = true;
            panel4.Enabled = true;

            if (listBox3.SelectedItem != null)
            {
                l = listBox3.SelectedItem.ToString().Split("  ");
                textBox3.Text = l[0];
                textBox8.Text = l[1];
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = listBox3.SelectedIndex;
            if (int.TryParse(textBox9.Text, out int value) == true)
            {
                if (value >= 0 && value <= 100)
                    listBox3.Items[a] = textBox3.Text + "  " + textBox8.Text + "  " + textBox9.Text;
                else
                {
                    MessageBox.Show("INVALID!");
                    textBox9.Text = "";
                }
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
