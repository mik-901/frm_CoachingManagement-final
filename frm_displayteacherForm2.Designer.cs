namespace frm_CoachingManagement
{
    partial class frm_displayteacherForm2
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
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(834, 409);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 1;
            button1.Text = "CLOSE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(132, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(717, 244);
            listBox1.TabIndex = 3;
            // 
            // frm_displayteacherForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 474);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "frm_displayteacherForm2";
            Text = "frm_displayteacher";
            Load += frm_displayteacherForm2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
    }
}