namespace frm_CoachingManagement
{
    partial class frm_teacherregisteration
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textbox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textbox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(256, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TEACHER REGISTERATION";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(232, 203);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 45;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 44;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 206);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 43;
            label6.Text = "BATCH ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 178);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 42;
            label5.Text = "COURSE NAME:";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(385, 315);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 41;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 315);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 40;
            button1.Text = "PREVIOUS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Location = new Point(232, 148);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(232, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 28;
            // 
            // textbox1
            // 
            textbox1.BackColor = SystemColors.Window;
            textbox1.Location = new Point(232, 90);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(100, 23);
            textbox1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 206);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 151);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 25;
            label3.Text = "CONTACT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 122);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 24;
            label2.Text = "SALARY:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 93);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 23;
            label1.Text = "TEACHER NAME:";
            // 
            // frm_teacherregisteration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 539);
            Controls.Add(groupBox1);
            Name = "frm_teacherregisteration";
            Text = "TEACHER INFO";
            Load += frm_teacherregisteration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textbox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}