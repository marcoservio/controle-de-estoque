namespace GUI
{
    partial class frmConsultaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCategoria));
            this.lblCategoria_ConsultaCat = new System.Windows.Forms.Label();
            this.txtValor_ConsultaCat = new System.Windows.Forms.TextBox();
            this.dtgDados_ConsultaCat = new System.Windows.Forms.DataGridView();
            this.btnLocalizar_ConsultaCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria_ConsultaCat
            // 
            this.lblCategoria_ConsultaCat.AutoSize = true;
            this.lblCategoria_ConsultaCat.Location = new System.Drawing.Point(9, 9);
            this.lblCategoria_ConsultaCat.Name = "lblCategoria_ConsultaCat";
            this.lblCategoria_ConsultaCat.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria_ConsultaCat.TabIndex = 0;
            this.lblCategoria_ConsultaCat.Text = "Categoria";
            // 
            // txtValor_ConsultaCat
            // 
            this.txtValor_ConsultaCat.Location = new System.Drawing.Point(12, 25);
            this.txtValor_ConsultaCat.Name = "txtValor_ConsultaCat";
            this.txtValor_ConsultaCat.Size = new System.Drawing.Size(637, 20);
            this.txtValor_ConsultaCat.TabIndex = 1;
            // 
            // dtgDados_ConsultaCat
            // 
            this.dtgDados_ConsultaCat.AllowUserToAddRows = false;
            this.dtgDados_ConsultaCat.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaCat.Location = new System.Drawing.Point(12, 65);
            this.dtgDados_ConsultaCat.Name = "dtgDados_ConsultaCat";
            this.dtgDados_ConsultaCat.ReadOnly = true;
            this.dtgDados_ConsultaCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaCat.Size = new System.Drawing.Size(760, 484);
            this.dtgDados_ConsultaCat.TabIndex = 3;
            this.dtgDados_ConsultaCat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // btnLocalizar_ConsultaCat
            // 
            this.btnLocalizar_ConsultaCat.Location = new System.Drawing.Point(655, 23);
            this.btnLocalizar_ConsultaCat.Name = "btnLocalizar_ConsultaCat";
            this.btnLocalizar_ConsultaCat.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaCat.TabIndex = 4;
            this.btnLocalizar_ConsultaCat.Text = "Localizar";
            this.btnLocalizar_ConsultaCat.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaCat.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // frmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLocalizar_ConsultaCat);
            this.Controls.Add(this.dtgDados_ConsultaCat);
            this.Controls.Add(this.txtValor_ConsultaCat);
            this.Controls.Add(this.lblCategoria_ConsultaCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.frmConsultaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria_ConsultaCat;
        private System.Windows.Forms.TextBox txtValor_ConsultaCat;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaCat;
        private System.Windows.Forms.Button btnLocalizar_ConsultaCat;
    }
}