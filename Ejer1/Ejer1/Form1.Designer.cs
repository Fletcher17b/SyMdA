namespace Ejer1
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
            this.tirar_dados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_suma = new System.Windows.Forms.Label();
            this.roll_36k = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tirar_dados
            // 
            this.tirar_dados.Location = new System.Drawing.Point(43, 311);
            this.tirar_dados.Name = "tirar_dados";
            this.tirar_dados.Size = new System.Drawing.Size(75, 23);
            this.tirar_dados.TabIndex = 0;
            this.tirar_dados.Text = "roll";
            this.tirar_dados.UseVisualStyleBackColor = true;
            this.tirar_dados.Click += new System.EventHandler(this.tirar_dados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dado 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dado 2:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 186);
            this.listBox1.TabIndex = 3;
            // 
            // lbl_suma
            // 
            this.lbl_suma.AutoSize = true;
            this.lbl_suma.Location = new System.Drawing.Point(40, 86);
            this.lbl_suma.Name = "lbl_suma";
            this.lbl_suma.Size = new System.Drawing.Size(37, 13);
            this.lbl_suma.TabIndex = 4;
            this.lbl_suma.Text = "Suma:";
            // 
            // roll_36k
            // 
            this.roll_36k.Location = new System.Drawing.Point(158, 311);
            this.roll_36k.Name = "roll_36k";
            this.roll_36k.Size = new System.Drawing.Size(75, 23);
            this.roll_36k.TabIndex = 5;
            this.roll_36k.Text = "roll 36k";
            this.roll_36k.UseVisualStyleBackColor = true;
            this.roll_36k.Click += new System.EventHandler(this.roll_36k_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 346);
            this.Controls.Add(this.roll_36k);
            this.Controls.Add(this.lbl_suma);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tirar_dados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tirar_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_suma;
        private System.Windows.Forms.Button roll_36k;
    }
}

