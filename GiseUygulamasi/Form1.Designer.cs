﻿
namespace GiseUygulamasi
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
            this.btnislemal = new System.Windows.Forms.Button();
            this.btnislemibitir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnislemal
            // 
            this.btnislemal.Location = new System.Drawing.Point(126, 141);
            this.btnislemal.Name = "btnislemal";
            this.btnislemal.Size = new System.Drawing.Size(272, 94);
            this.btnislemal.TabIndex = 0;
            this.btnislemal.Text = "İSLEM AL";
            this.btnislemal.UseVisualStyleBackColor = true;
            this.btnislemal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnislemibitir
            // 
            this.btnislemibitir.Location = new System.Drawing.Point(433, 141);
            this.btnislemibitir.Name = "btnislemibitir";
            this.btnislemibitir.Size = new System.Drawing.Size(272, 94);
            this.btnislemibitir.TabIndex = 1;
            this.btnislemibitir.Text = "İSLEMİ SONLANDIR";
            this.btnislemibitir.UseVisualStyleBackColor = true;
            this.btnislemibitir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "İŞLEMDEKİ NUMARA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(489, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnislemibitir);
            this.Controls.Add(this.btnislemal);
            this.Name = "Form1";
            this.Text = "GİŞE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnislemal;
        private System.Windows.Forms.Button btnislemibitir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
