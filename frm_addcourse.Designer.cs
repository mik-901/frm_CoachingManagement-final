namespace frm_CoachingManagement
{
    partial class frm_addcourse
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
            button2 = new Button();
            tb1 = new TextBox();
            button1 = new Button();
            tb2 = new TextBox();
            lb2 = new Label();
            lb1 = new Label();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.ControlDark;
            gb1.Controls.Add(button2);
            gb1.Controls.Add(tb1);
            gb1.Controls.Add(button1);
            gb1.Controls.Add(tb2);
            gb1.Controls.Add(lb2);
            gb1.Controls.Add(lb1);
            gb1.ForeColor = SystemColors.InactiveCaptionText;
            gb1.Location = new Point(221, 55);
            gb1.Name = "gb1";
            gb1.Size = new Size(517, 369);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "COURSE INFO";
            gb1.Enter += gb1_Enter;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.InactiveCaptionText;
            button2.Location = new Point(19, 326);
            button2.Name = "button2";
            button2.Size = new Size(68, 23);
            button2.TabIndex = 7;
            button2.Text = "PREVIOUS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tb1
            // 
            tb1.ForeColor = SystemColors.ActiveCaptionText;
            tb1.Location = new Point(158, 74);
            tb1.Name = "tb1";
            tb1.Size = new Size(114, 23);
            tb1.TabIndex = 6;
            tb1.TextChanged += tb1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.InactiveCaptionText;
            button1.Location = new Point(437, 326);
            button1.Name = "button1";
            button1.Size = new Size(58, 23);
            button1.TabIndex = 5;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb2
            // 
            tb2.ForeColor = SystemColors.ActiveCaptionText;
            tb2.Location = new Point(158, 106);
            tb2.Name = "tb2";
            tb2.Size = new Size(114, 23);
            tb2.TabIndex = 3;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.ForeColor = SystemColors.ActiveCaptionText;
            lb2.Location = new Point(56, 109);
            lb2.Name = "lb2";
            lb2.Size = new Size(81, 15);
            lb2.TabIndex = 1;
            lb2.Text = "COURSE FEES:";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.ForeColor = SystemColors.ActiveCaptionText;
            lb1.Location = new Point(56, 77);
            lb1.Name = "lb1";
            lb1.Size = new Size(91, 15);
            lb1.TabIndex = 0;
            lb1.Text = "COURSE NAME:";
            // 
            // frm_addcourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 489);
            Controls.Add(gb1);
            Name = "frm_addcourse";
            Text = "COURSES";
            Load += frm_addcourse_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Label lb2;
        private Label lb1;
        private TextBox tb2;
        private Button button1;
        private TextBox tb1;
        private Button button2;
    }
}