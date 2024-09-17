namespace Ejer3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_vent = new System.Windows.Forms.TextBox();
            this.cmb_prod = new System.Windows.Forms.ComboBox();
            this.cmb_vend = new System.Windows.Forms.ComboBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.clm_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_vendedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vend2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vend3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vend4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 136);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venta en $";
            // 
            // txb_vent
            // 
            this.txb_vent.Location = new System.Drawing.Point(192, 136);
            this.txb_vent.Name = "txb_vent";
            this.txb_vent.Size = new System.Drawing.Size(100, 20);
            this.txb_vent.TabIndex = 3;
            // 
            // cmb_prod
            // 
            this.cmb_prod.FormattingEnabled = true;
            this.cmb_prod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_prod.Location = new System.Drawing.Point(192, 96);
            this.cmb_prod.Name = "cmb_prod";
            this.cmb_prod.Size = new System.Drawing.Size(100, 21);
            this.cmb_prod.TabIndex = 4;
            // 
            // cmb_vend
            // 
            this.cmb_vend.FormattingEnabled = true;
            this.cmb_vend.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_vend.Location = new System.Drawing.Point(192, 55);
            this.cmb_vend.Name = "cmb_vend";
            this.cmb_vend.Size = new System.Drawing.Size(100, 21);
            this.cmb_vend.TabIndex = 5;
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Producto,
            this.clm_vendedor1,
            this.vend2,
            this.vend3,
            this.vend4,
            this.Total1});
            this.dGV1.Location = new System.Drawing.Point(54, 219);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(648, 347);
            this.dGV1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(192, 181);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // clm_Producto
            // 
            this.clm_Producto.HeaderText = "Productos";
            this.clm_Producto.Name = "clm_Producto";
            // 
            // clm_vendedor1
            // 
            this.clm_vendedor1.HeaderText = "Vendedor 1";
            this.clm_vendedor1.Name = "clm_vendedor1";
            // 
            // vend2
            // 
            this.vend2.HeaderText = "Vendedor 2";
            this.vend2.Name = "vend2";
            // 
            // vend3
            // 
            this.vend3.HeaderText = "Vendedor 3";
            this.vend3.Name = "vend3";
            // 
            // vend4
            // 
            this.vend4.HeaderText = "Vendedor 4";
            this.vend4.Name = "vend4";
            // 
            // Total1
            // 
            this.Total1.HeaderText = "Total Prod";
            this.Total1.Name = "Total1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 611);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.cmb_vend);
            this.Controls.Add(this.cmb_prod);
            this.Controls.Add(this.txb_vent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_vent;
        private System.Windows.Forms.ComboBox cmb_prod;
        private System.Windows.Forms.ComboBox cmb_vend;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_vendedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vend2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vend3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vend4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
    }
}

