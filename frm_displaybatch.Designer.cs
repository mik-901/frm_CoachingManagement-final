﻿namespace frm_CoachingManagement
{
    partial class frm_displaybatch
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(150, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(688, 349);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(849, 456);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "CLOSE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_displaybatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 501);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "frm_displaybatch";
            Text = "VIEW BATCHES";
            Load += frm_displaybatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
    }
}