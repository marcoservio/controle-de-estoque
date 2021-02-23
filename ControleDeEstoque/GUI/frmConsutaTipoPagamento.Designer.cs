namespace GUI
{
    partial class frmConsutaTipoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsutaTipoPagamento));
            this.btnLocalizar_ConsultaTip = new System.Windows.Forms.Button();
            this.dtgDados_ConsultaTip = new System.Windows.Forms.DataGridView();
            this.txtTipoPagamento_ConsultaTip = new System.Windows.Forms.TextBox();
            this.lblTipoPagamento_ConsultaTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaTip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar_ConsultaTip
            // 
            this.btnLocalizar_ConsultaTip.Location = new System.Drawing.Point(657, 24);
            this.btnLocalizar_ConsultaTip.Name = "btnLocalizar_ConsultaTip";
            this.btnLocalizar_ConsultaTip.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaTip.TabIndex = 8;
            this.btnLocalizar_ConsultaTip.Text = "Localizar";
            this.btnLocalizar_ConsultaTip.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaTip.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dtgDados_ConsultaTip
            // 
            this.dtgDados_ConsultaTip.AllowUserToAddRows = false;
            this.dtgDados_ConsultaTip.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaTip.Location = new System.Drawing.Point(14, 66);
            this.dtgDados_ConsultaTip.Name = "dtgDados_ConsultaTip";
            this.dtgDados_ConsultaTip.ReadOnly = true;
            this.dtgDados_ConsultaTip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaTip.Size = new System.Drawing.Size(760, 484);
            this.dtgDados_ConsultaTip.TabIndex = 7;
            this.dtgDados_ConsultaTip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // txtTipoPagamento_ConsultaTip
            // 
            this.txtTipoPagamento_ConsultaTip.Location = new System.Drawing.Point(14, 26);
            this.txtTipoPagamento_ConsultaTip.Name = "txtTipoPagamento_ConsultaTip";
            this.txtTipoPagamento_ConsultaTip.Size = new System.Drawing.Size(637, 20);
            this.txtTipoPagamento_ConsultaTip.TabIndex = 6;
            // 
            // lblTipoPagamento_ConsultaTip
            // 
            this.lblTipoPagamento_ConsultaTip.AutoSize = true;
            this.lblTipoPagamento_ConsultaTip.Location = new System.Drawing.Point(11, 10);
            this.lblTipoPagamento_ConsultaTip.Name = "lblTipoPagamento_ConsultaTip";
            this.lblTipoPagamento_ConsultaTip.Size = new System.Drawing.Size(85, 13);
            this.lblTipoPagamento_ConsultaTip.TabIndex = 5;
            this.lblTipoPagamento_ConsultaTip.Text = "Tipo Pagamento";
            // 
            // frmConsutaTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLocalizar_ConsultaTip);
            this.Controls.Add(this.dtgDados_ConsultaTip);
            this.Controls.Add(this.txtTipoPagamento_ConsultaTip);
            this.Controls.Add(this.lblTipoPagamento_ConsultaTip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsutaTipoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Tipo Pagamento";
            this.Load += new System.EventHandler(this.frmConsutaTipoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar_ConsultaTip;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaTip;
        private System.Windows.Forms.TextBox txtTipoPagamento_ConsultaTip;
        private System.Windows.Forms.Label lblTipoPagamento_ConsultaTip;
    }
}