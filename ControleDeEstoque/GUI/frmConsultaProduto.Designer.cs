namespace GUI
{
    partial class frmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
            this.btnLocalizar_ConsultaPro = new System.Windows.Forms.Button();
            this.dtgDados_ConsultaPro = new System.Windows.Forms.DataGridView();
            this.txtProduto_ConsultaPro = new System.Windows.Forms.TextBox();
            this.lblProduto_ConsultaPro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaPro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar_ConsultaPro
            // 
            this.btnLocalizar_ConsultaPro.Location = new System.Drawing.Point(657, 24);
            this.btnLocalizar_ConsultaPro.Name = "btnLocalizar_ConsultaPro";
            this.btnLocalizar_ConsultaPro.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaPro.TabIndex = 8;
            this.btnLocalizar_ConsultaPro.Text = "Localizar";
            this.btnLocalizar_ConsultaPro.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaPro.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dtgDados_ConsultaPro
            // 
            this.dtgDados_ConsultaPro.AllowUserToAddRows = false;
            this.dtgDados_ConsultaPro.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaPro.Location = new System.Drawing.Point(14, 66);
            this.dtgDados_ConsultaPro.Name = "dtgDados_ConsultaPro";
            this.dtgDados_ConsultaPro.ReadOnly = true;
            this.dtgDados_ConsultaPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaPro.Size = new System.Drawing.Size(760, 484);
            this.dtgDados_ConsultaPro.TabIndex = 7;
            this.dtgDados_ConsultaPro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // txtProduto_ConsultaPro
            // 
            this.txtProduto_ConsultaPro.Location = new System.Drawing.Point(14, 26);
            this.txtProduto_ConsultaPro.Name = "txtProduto_ConsultaPro";
            this.txtProduto_ConsultaPro.Size = new System.Drawing.Size(637, 20);
            this.txtProduto_ConsultaPro.TabIndex = 6;
            // 
            // lblProduto_ConsultaPro
            // 
            this.lblProduto_ConsultaPro.AutoSize = true;
            this.lblProduto_ConsultaPro.Location = new System.Drawing.Point(11, 10);
            this.lblProduto_ConsultaPro.Name = "lblProduto_ConsultaPro";
            this.lblProduto_ConsultaPro.Size = new System.Drawing.Size(44, 13);
            this.lblProduto_ConsultaPro.TabIndex = 5;
            this.lblProduto_ConsultaPro.Text = "Produto";
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLocalizar_ConsultaPro);
            this.Controls.Add(this.dtgDados_ConsultaPro);
            this.Controls.Add(this.txtProduto_ConsultaPro);
            this.Controls.Add(this.lblProduto_ConsultaPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar_ConsultaPro;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaPro;
        private System.Windows.Forms.TextBox txtProduto_ConsultaPro;
        private System.Windows.Forms.Label lblProduto_ConsultaPro;
    }
}