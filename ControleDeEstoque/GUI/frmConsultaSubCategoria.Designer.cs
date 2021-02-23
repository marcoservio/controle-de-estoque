namespace GUI
{
    partial class frmConsultaSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSubCategoria));
            this.btnLocalizar_ConsultaSub = new System.Windows.Forms.Button();
            this.dtgDados_ConsultaSub = new System.Windows.Forms.DataGridView();
            this.txtValor_ConsultaSub = new System.Windows.Forms.TextBox();
            this.lblSubCategoria_ConsultaSub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaSub)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar_ConsultaSub
            // 
            this.btnLocalizar_ConsultaSub.Location = new System.Drawing.Point(657, 24);
            this.btnLocalizar_ConsultaSub.Name = "btnLocalizar_ConsultaSub";
            this.btnLocalizar_ConsultaSub.Size = new System.Drawing.Size(117, 23);
            this.btnLocalizar_ConsultaSub.TabIndex = 8;
            this.btnLocalizar_ConsultaSub.Text = "Localizar";
            this.btnLocalizar_ConsultaSub.UseVisualStyleBackColor = true;
            this.btnLocalizar_ConsultaSub.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dtgDados_ConsultaSub
            // 
            this.dtgDados_ConsultaSub.AllowUserToAddRows = false;
            this.dtgDados_ConsultaSub.AllowUserToDeleteRows = false;
            this.dtgDados_ConsultaSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados_ConsultaSub.Location = new System.Drawing.Point(14, 66);
            this.dtgDados_ConsultaSub.Name = "dtgDados_ConsultaSub";
            this.dtgDados_ConsultaSub.ReadOnly = true;
            this.dtgDados_ConsultaSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados_ConsultaSub.Size = new System.Drawing.Size(760, 484);
            this.dtgDados_ConsultaSub.TabIndex = 7;
            this.dtgDados_ConsultaSub.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            // 
            // txtValor_ConsultaSub
            // 
            this.txtValor_ConsultaSub.Location = new System.Drawing.Point(14, 26);
            this.txtValor_ConsultaSub.Name = "txtValor_ConsultaSub";
            this.txtValor_ConsultaSub.Size = new System.Drawing.Size(637, 20);
            this.txtValor_ConsultaSub.TabIndex = 6;
            // 
            // lblSubCategoria_ConsultaSub
            // 
            this.lblSubCategoria_ConsultaSub.AutoSize = true;
            this.lblSubCategoria_ConsultaSub.Location = new System.Drawing.Point(11, 10);
            this.lblSubCategoria_ConsultaSub.Name = "lblSubCategoria_ConsultaSub";
            this.lblSubCategoria_ConsultaSub.Size = new System.Drawing.Size(71, 13);
            this.lblSubCategoria_ConsultaSub.TabIndex = 5;
            this.lblSubCategoria_ConsultaSub.Text = "SubCategoria";
            // 
            // frmConsultaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLocalizar_ConsultaSub);
            this.Controls.Add(this.dtgDados_ConsultaSub);
            this.Controls.Add(this.txtValor_ConsultaSub);
            this.Controls.Add(this.lblSubCategoria_ConsultaSub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta SubCategoria";
            this.Load += new System.EventHandler(this.frmConsultaSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados_ConsultaSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar_ConsultaSub;
        private System.Windows.Forms.DataGridView dtgDados_ConsultaSub;
        private System.Windows.Forms.TextBox txtValor_ConsultaSub;
        private System.Windows.Forms.Label lblSubCategoria_ConsultaSub;
    }
}