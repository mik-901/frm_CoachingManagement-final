namespace frm_CoachingManagement
{
    partial class frm_batchinfo
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
            gb1 = new GroupBox();
            btn2 = new Button();
            cb2 = new ComboBox();
            btn1 = new Button();
            tb1 = new TextBox();
            lb3 = new Label();
            lb2 = new Label();
            cb1 = new ComboBox();
            lb1 = new Label();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.ButtonShadow;
            gb1.Controls.Add(btn2);
            gb1.Controls.Add(cb2);
            gb1.Controls.Add(btn1);
            gb1.Controls.Add(tb1);
            gb1.Controls.Add(lb3);
            gb1.Controls.Add(lb2);
            gb1.Controls.Add(cb1);
            gb1.Controls.Add(lb1);
            gb1.Location = new Point(220, 94);
            gb1.Name = "gb1";
            gb1.Size = new Size(485, 296);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "ADD BATCH";
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Location = new Point(21, 245);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 8;
            btn2.Text = "PREVIOUS";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // cb2
            // 
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "YES", "NO" });
            cb2.Location = new Point(226, 147);
            cb2.Name = "cb2";
            cb2.Size = new Size(121, 23);
            cb2.TabIndex = 7;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonHighlight;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Location = new Point(378, 245);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 6;
            btn1.Text = "GENERATE";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // tb1
            // 
            tb1.Enabled = false;
            tb1.Location = new Point(226, 80);
            tb1.Name = "tb1";
            tb1.Size = new Size(121, 23);
            tb1.TabIndex = 4;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(113, 155);
            lb3.Name = "lb3";
            lb3.Size = new Size(90, 15);
            lb3.TabIndex = 3;
            lb3.Text = "BATCH ACTIVE: ";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(113, 88);
            lb2.Name = "lb2";
            lb2.Size = new Size(63, 15);
            lb2.TabIndex = 2;
            lb2.Text = "BATCH ID: ";
            // 
            // cb1
            // 
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(226, 111);
            cb1.Name = "cb1";
            cb1.Size = new Size(121, 23);
            cb1.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(113, 119);
            lb1.Name = "lb1";
            lb1.Size = new Size(91, 15);
            lb1.TabIndex = 0;
            lb1.Text = "COURSE NAME:";
            // 
            // frm_batchinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 464);
            Controls.Add(gb1);
            Name = "frm_batchinfo";
            Text = "frm_batchinfo";
            Load += frm_batchinfo_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private ComboBox cb1;
        private Label lb1;
        private Label lb3;
        private Label lb2;
        private TextBox tb1;
        private Button btn1;
        private ComboBox cb2;
        private Button btn2;
    }
}