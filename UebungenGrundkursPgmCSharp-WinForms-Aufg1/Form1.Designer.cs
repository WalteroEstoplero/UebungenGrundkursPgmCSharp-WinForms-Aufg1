namespace UebungenGrundkursPgmCSharp_WinForms_Aufg1
{
    partial class Form_Aufgabe1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_read = new System.Windows.Forms.Button();
            this.TBx_file = new System.Windows.Forms.TextBox();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_copy = new System.Windows.Forms.Button();
            this.TBx_Kopie = new System.Windows.Forms.TextBox();
            this.Btn_Verschl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_read
            // 
            this.Btn_read.Location = new System.Drawing.Point(45, 104);
            this.Btn_read.Name = "Btn_read";
            this.Btn_read.Size = new System.Drawing.Size(349, 56);
            this.Btn_read.TabIndex = 0;
            this.Btn_read.Text = "read file";
            this.Btn_read.UseVisualStyleBackColor = true;
            this.Btn_read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // TBx_file
            // 
            this.TBx_file.Location = new System.Drawing.Point(45, 56);
            this.TBx_file.Name = "TBx_file";
            this.TBx_file.Size = new System.Drawing.Size(717, 20);
            this.TBx_file.TabIndex = 2;
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_clear.Location = new System.Drawing.Point(413, 104);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(349, 56);
            this.Btn_clear.TabIndex = 3;
            this.Btn_clear.Text = "clear";
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_copy
            // 
            this.Btn_copy.Location = new System.Drawing.Point(243, 191);
            this.Btn_copy.Name = "Btn_copy";
            this.Btn_copy.Size = new System.Drawing.Size(151, 56);
            this.Btn_copy.TabIndex = 4;
            this.Btn_copy.Text = "copy";
            this.Btn_copy.UseVisualStyleBackColor = true;
            this.Btn_copy.Click += new System.EventHandler(this.Btn_copy_Click);
            // 
            // TBx_Kopie
            // 
            this.TBx_Kopie.Location = new System.Drawing.Point(45, 191);
            this.TBx_Kopie.Name = "TBx_Kopie";
            this.TBx_Kopie.Size = new System.Drawing.Size(179, 20);
            this.TBx_Kopie.TabIndex = 5;
            // 
            // Btn_Verschl
            // 
            this.Btn_Verschl.Location = new System.Drawing.Point(413, 189);
            this.Btn_Verschl.Name = "Btn_Verschl";
            this.Btn_Verschl.Size = new System.Drawing.Size(151, 60);
            this.Btn_Verschl.TabIndex = 6;
            this.Btn_Verschl.Text = "verschlüsseln";
            this.Btn_Verschl.UseVisualStyleBackColor = true;
            this.Btn_Verschl.Click += new System.EventHandler(this.Btn_Verschl_Click);
            // 
            // Form_Aufgabe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.Btn_Verschl);
            this.Controls.Add(this.TBx_Kopie);
            this.Controls.Add(this.Btn_copy);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.TBx_file);
            this.Controls.Add(this.Btn_read);
            this.Name = "Form_Aufgabe1";
            this.Text = "Aufgabe1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_read;
        private System.Windows.Forms.TextBox TBx_file;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_copy;
        private System.Windows.Forms.TextBox TBx_Kopie;
        private System.Windows.Forms.Button Btn_Verschl;
    }
}

