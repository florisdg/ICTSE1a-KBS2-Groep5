﻿namespace VirtualPiano
{
    partial class MainForm
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
            this.formContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // formContent
            // 

            this.formContent.Location = new System.Drawing.Point(1, 34);
            this.formContent.Name = "formContent";
            this.formContent.Size = new System.Drawing.Size(428, 531);

            this.formContent.Location = new System.Drawing.Point(-2, 45);
            this.formContent.Name = "formContent";
            this.formContent.Size = new System.Drawing.Size(1805, 1015);

            this.formContent.Location = new System.Drawing.Point(-2, 45);
            this.formContent.Name = "formContent";
            this.formContent.Size = new System.Drawing.Size(1805, 1015);
            this.formContent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.formContent);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formContent;
    }
}

