namespace GUI
{
    partial class frmConsultaUnidadeDeMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUnidadeDeMedida));
            this.btnLocalizar_ConsultaUmed = new System.Windows.Forms.Button();
            this.dtgDados_ConsultaUmed = new System.Windows.Forms.DataGridView();
            this.txtUnidadeMedida_ConsultaUmed = new System.Windows.Forms.TextBox();
            this.lblUnidadeMedida_ConsultaUmed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaUmed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar_ConsultaUmed
            // 
            this.btnLocalizar_ConsultaUmed.Location = new System.Drawing.Point(657, 24);
            this.btnLocalizar_ConsultaUmed.Name = "btnLocalizar_ConsultaUmed";
            this.btnLocalizar_ConsultaUmed.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaUmed.TabIndex = 8;
            this.btnLocalizar_ConsultaUmed.Text = "Localizar";
            this.btnLocalizar_ConsultaUmed.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaUmed.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dtgDados_ConsultaUmed
            // 
            this.dtgDados_ConsultaUmed.AllowUserToAddRows = false;
            this.dtgDados_ConsultaUmed.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaUmed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaUmed.Location = new System.Drawing.Point(14, 66);
            this.dtgDados_ConsultaUmed.Name = "dtgDados_ConsultaUmed";
            this.dtgDados_ConsultaUmed.ReadOnly = true;
            this.dtgDados_ConsultaUmed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaUmed.Size = new System.Drawing.Size(760, 484);
            this.dtgDados_ConsultaUmed.TabIndex = 7;
            this.dtgDados_ConsultaUmed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // txtUnidadeMedida_ConsultaUmed
            // 
            this.txtUnidadeMedida_ConsultaUmed.Location = new System.Drawing.Point(14, 26);
            this.txtUnidadeMedida_ConsultaUmed.Name = "txtUnidadeMedida_ConsultaUmed";
            this.txtUnidadeMedida_ConsultaUmed.Size = new System.Drawing.Size(637, 20);
            this.txtUnidadeMedida_ConsultaUmed.TabIndex = 6;
            // 
            // lblUnidadeMedida_ConsultaUmed
            // 
            this.lblUnidadeMedida_ConsultaUmed.AutoSize = true;
            this.lblUnidadeMedida_ConsultaUmed.Location = new System.Drawing.Point(11, 10);
            this.lblUnidadeMedida_ConsultaUmed.Name = "lblUnidadeMedida_ConsultaUmed";
            this.lblUnidadeMedida_ConsultaUmed.Size = new System.Drawing.Size(100, 13);
            this.lblUnidadeMedida_ConsultaUmed.TabIndex = 5;
            this.lblUnidadeMedida_ConsultaUmed.Text = "Unidade de Medida";
            // 
            // frmConsultaUnidadeDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLocalizar_ConsultaUmed);
            this.Controls.Add(this.dtgDados_ConsultaUmed);
            this.Controls.Add(this.txtUnidadeMedida_ConsultaUmed);
            this.Controls.Add(this.lblUnidadeMedida_ConsultaUmed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaUnidadeDeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Unidade de Medida";
            this.Load += new System.EventHandler(this.frmConsultaUnidadeDeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaUmed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar_ConsultaUmed;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaUmed;
        private System.Windows.Forms.TextBox txtUnidadeMedida_ConsultaUmed;
        private System.Windows.Forms.Label lblUnidadeMedida_ConsultaUmed;
    }
}