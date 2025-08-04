namespace frm_CoachingManagement
{
    partial class frm_studentregister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label8 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textbox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textbox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(231, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "STUDENT REGISTERATION";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.Location = new Point(213, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 259);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 21;
            label8.Text = "AMOUNT PAID:";
            label8.Click += label8_Click;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(214, 168);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(100, 23);
            comboBox4.TabIndex = 20;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 172);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 19;
            label7.Text = "BATCH:";
            label7.Click += label7_Click;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.Window;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "YES", "NO" });
            comboBox3.Location = new Point(213, 227);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 23);
            comboBox3.TabIndex = 18;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 235);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 17;
            label6.Text = "STUDENT ACTIVE:";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(20, 331);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "PREVIOUS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Window;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "YES", "NO" });
            comboBox2.Location = new Point(213, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 206);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 14;
            label5.Text = "PAYMENT:";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(349, 331);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(214, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textbox1
            // 
            textbox1.BackColor = SystemColors.Window;
            textbox1.Location = new Point(214, 79);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(100, 23);
            textbox1.TabIndex = 8;
            textbox1.TextChanged += textbox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 140);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "COURSE:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 108);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "CONTACT:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 82);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "NAME:";
            label1.Click += label1_Click;
            // 
            // frm_studentregister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 472);
            Controls.Add(groupBox1);
            Name = "frm_studentregister";
            Text = "frm_studentregister";
            Load += frm_studentregister_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textbox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Button button2;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
    }
}