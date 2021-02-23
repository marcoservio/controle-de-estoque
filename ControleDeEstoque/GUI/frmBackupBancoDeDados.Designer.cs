namespace GUI
{
    partial class frmBackupBancoDeDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupBancoDeDados));
            this.txtBackup_Backup = new System.Windows.Forms.Button();
            this.txtRestaurar_Backup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBackup_Backup
            // 
            this.txtBackup_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackup_Backup.Location = new System.Drawing.Point(12, 12);
            this.txtBackup_Backup.Name = "txtBackup_Backup";
            this.txtBackup_Backup.Size = new System.Drawing.Size(760, 258);
            this.txtBackup_Backup.TabIndex = 0;
            this.txtBackup_Backup.Text = "Backup do Banco de Dados";
            this.txtBackup_Backup.UseVisualStyleBackColor = true;
            this.txtBackup_Backup.Click += new System.EventHandler(this.txtBackup_Backup_Click);
            // 
            // txtRestaurar_Backup
            // 
            this.txtRestaurar_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurar_Backup.Location = new System.Drawing.Point(12, 291);
            this.txtRestaurar_Backup.Name = "txtRestaurar_Backup";
            this.txtRestaurar_Backup.Size = new System.Drawing.Size(760, 258);
            this.txtRestaurar_Backup.TabIndex = 3;
            this.txtRestaurar_Backup.Text = "Restaurar o Banco de Dados";
            this.txtRestaurar_Backup.UseVisualStyleBackColor = true;
            this.txtRestaurar_Backup.Click += new System.EventHandler(this.txtRestaurar_Backup_Click);
            // 
            // frmBackupBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtRestaurar_Backup);
            this.Controls.Add(this.txtBackup_Backup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackupBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do Banco de Dados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtBackup_Backup;
        private System.Windows.Forms.Button txtRestaurar_Backup;
    }
}