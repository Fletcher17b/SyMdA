﻿namespace Ejer2
{
    partial class Form1
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
            this.btn_reserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbx_smoke = new System.Windows.Forms.CheckBox();
            this.chbx_nosmoke = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(230, 132);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(75, 23);
            this.btn_reserve.TabIndex = 0;
            this.btn_reserve.Text = "Reservar";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btnreserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Smoking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Non Smoking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escoja un tipo de asiento";
            // 
            // chbx_smoke
            // 
            this.chbx_smoke.AutoSize = true;
            this.chbx_smoke.Location = new System.Drawing.Point(96, 73);
            this.chbx_smoke.Name = "chbx_smoke";
            this.chbx_smoke.Size = new System.Drawing.Size(15, 14);
            this.chbx_smoke.TabIndex = 6;
            this.chbx_smoke.UseVisualStyleBackColor = true;
            this.chbx_smoke.CheckedChanged += new System.EventHandler(this.chbx_smoke_CheckedChanged);
            // 
            // chbx_nosmoke
            // 
            this.chbx_nosmoke.AutoSize = true;
            this.chbx_nosmoke.Location = new System.Drawing.Point(206, 73);
            this.chbx_nosmoke.Name = "chbx_nosmoke";
            this.chbx_nosmoke.Size = new System.Drawing.Size(15, 14);
            this.chbx_nosmoke.TabIndex = 7;
            this.chbx_nosmoke.UseVisualStyleBackColor = true;
            this.chbx_nosmoke.CheckedChanged += new System.EventHandler(this.chbx_nosmoke_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 167);
            this.Controls.Add(this.chbx_nosmoke);
            this.Controls.Add(this.chbx_smoke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reserve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbx_smoke;
        private System.Windows.Forms.CheckBox chbx_nosmoke;
    }
}

