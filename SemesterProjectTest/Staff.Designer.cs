﻿namespace SemesterProjectTest
{
    partial class Staff
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
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Location = new System.Drawing.Point(46, 31);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(312, 182);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Table 1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 837);
            this.Controls.Add(this.btn1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
    }
}