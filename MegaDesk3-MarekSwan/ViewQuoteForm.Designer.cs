﻿namespace MegaDesk3_MarekSwan
{
    partial class ViewQuoteForm
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
            this.btnViewQuoteExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewQuoteExit
            // 
            this.btnViewQuoteExit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuoteExit.Location = new System.Drawing.Point(127, 75);
            this.btnViewQuoteExit.Name = "btnViewQuoteExit";
            this.btnViewQuoteExit.Size = new System.Drawing.Size(75, 23);
            this.btnViewQuoteExit.TabIndex = 0;
            this.btnViewQuoteExit.Text = "Exit";
            this.btnViewQuoteExit.UseVisualStyleBackColor = true;
            this.btnViewQuoteExit.Click += new System.EventHandler(this.btnViewQuoteExit_Click);
            // 
            // ViewQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 179);
            this.Controls.Add(this.btnViewQuoteExit);
            this.Name = "ViewQuoteForm";
            this.Text = "ViewQuoteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewQuoteExit;
    }
}