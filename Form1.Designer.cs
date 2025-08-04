namespace frm_CoachingManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb1 = new GroupBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb1 = new TextBox();
            btn1 = new Button();
            lb1 = new Label();
            cb1 = new ComboBox();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.AppWorkspace;
            gb1.Controls.Add(label3);
            gb1.Controls.Add(textBox2);
            gb1.Controls.Add(textBox1);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Controls.Add(tb1);
            gb1.Controls.Add(btn1);
            gb1.Controls.Add(lb1);
            gb1.Controls.Add(cb1);
            gb1.FlatStyle = FlatStyle.Popup;
            gb1.Location = new Point(218, 69);
            gb1.Name = "gb1";
            gb1.Size = new Size(508, 346);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "WELCOME TO ASPIRE STUDY!";
            gb1.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 68);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 199);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 7;
            label2.Text = "Enter Teacher Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 170);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter Student Id:";
            // 
            // tb1
            // 
            tb1.Location = new Point(279, 140);
            tb1.Name = "tb1";
            tb1.PasswordChar = '*';
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlLightLight;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Location = new Point(411, 300);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 3;
            btn1.Text = "LOGIN";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(172, 143);
            lb1.Name = "lb1";
            lb1.Size = new Size(90, 15);
            lb1.TabIndex = 1;
            lb1.Text = "Enter Password:";
            // 
            // cb1
            // 
            cb1.BackColor = SystemColors.Menu;
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "ADMIN", "STUDENT", "TEACHER" });
            cb1.Location = new Point(45, 68);
            cb1.Name = "cb1";
            cb1.Size = new Size(121, 23);
            cb1.TabIndex = 0;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.comps;
            ClientSize = new Size(962, 488);
            Controls.Add(gb1);
            Name = "Form1";
            Text = "ASPIRE STUDIES";
            Load += Form1_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private ComboBox cb1;
        private Button btn1;
        private Label lb1;
        private TextBox tb1;
        private Label label2;
        private Label label1;
        private TextBox tb2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
    }
}