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
    public partial class frm_admindashboard : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public frm_admindashboard(int tid)
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form frm_studentregister = new frm_studentregister();
            frm_studentregister.Show();
        }

        private void frm_admindashboard_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Integrated Security=True");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form frm_studentregister = new frm_studentregister();
            frm_studentregister.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form frm_addcourse = new frm_addcourse();
            frm_addcourse.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form displaycourse = new displaycourse();
            displaycourse.Show();
        }

        private void tEACHERREGISTERATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTUDENTREGISTERATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDCOURSEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm_addcourse = new frm_addcourse();
            frm_addcourse.Show();
        }

        private void aDDCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDBATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dEFAULTERLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form defaulterlist = new defaulterlist();
            defaulterlist.Show();
        }

        private void dELETECOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form deletecourse = new deletecourse();
            deletecourse.Show();
        }

        private void vIEWCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form displaycourse = new displaycourse();
            displaycourse.Show();
        }

        private void vIEWBATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_displaybatch = new frm_displaybatch();
            frm_displaybatch.Show();

        }

        private void aDDBATCHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm_batchinfo = new frm_batchinfo();
            frm_batchinfo.Show();


        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWSTUDENTINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_viewstudent = new frm_viewstudent();
            frm_viewstudent.Show();
        }

        private void sTUDENTREGISTERATIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm_studentregister = new frm_studentregister();
            frm_studentregister.Show();

        }

        private void tEACHERREGISTERATTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_teacherregisteration = new frm_teacherregisteration();
            frm_teacherregisteration.Show();
        }

        private void vIEWTEACHERINFOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm_displayteacherForm2 = new frm_displayteacherForm2();
            frm_displayteacherForm2.Show();
        }

        private void uPDATECOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form updatecourse = new updatecourse();
            updatecourse.Show();
        }

        private void dELETEBATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form deletebatch1 = new deletebatch1();
            deletebatch1.Show();
        }

        private void uPDATEBATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form updatebatch = new updatebatch();
            updatebatch.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
