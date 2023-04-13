
namespace warung
{
    partial class Form_Admin
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
            this.btn_laporantransaksi = new System.Windows.Forms.Button();
            this.btn_kelolauser = new System.Windows.Forms.Button();
            this.btn_kelolamenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_laporantransaksi
            // 
            this.btn_laporantransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_laporantransaksi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_laporantransaksi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_laporantransaksi.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporantransaksi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_laporantransaksi.Location = new System.Drawing.Point(17, 33);
            this.btn_laporantransaksi.Name = "btn_laporantransaksi";
            this.btn_laporantransaksi.Size = new System.Drawing.Size(143, 55);
            this.btn_laporantransaksi.TabIndex = 1;
            this.btn_laporantransaksi.Text = "LaporanTransaksi";
            this.btn_laporantransaksi.UseVisualStyleBackColor = false;
            this.btn_laporantransaksi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kelolauser
            // 
            this.btn_kelolauser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kelolauser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_kelolauser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_kelolauser.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kelolauser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kelolauser.Location = new System.Drawing.Point(17, 104);
            this.btn_kelolauser.Name = "btn_kelolauser";
            this.btn_kelolauser.Size = new System.Drawing.Size(143, 55);
            this.btn_kelolauser.TabIndex = 2;
            this.btn_kelolauser.Text = "Kelola user";
            this.btn_kelolauser.UseVisualStyleBackColor = false;
            this.btn_kelolauser.Click += new System.EventHandler(this.btn_kelolauser_Click);
            // 
            // btn_kelolamenu
            // 
            this.btn_kelolamenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kelolamenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_kelolamenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_kelolamenu.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kelolamenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kelolamenu.Location = new System.Drawing.Point(17, 175);
            this.btn_kelolamenu.Name = "btn_kelolamenu";
            this.btn_kelolamenu.Size = new System.Drawing.Size(143, 55);
            this.btn_kelolamenu.TabIndex = 3;
            this.btn_kelolamenu.Text = "Kelola menu";
            this.btn_kelolamenu.UseVisualStyleBackColor = false;
            this.btn_kelolamenu.Click += new System.EventHandler(this.btn_kelolamenu_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(177, 263);
            this.Controls.Add(this.btn_kelolamenu);
            this.Controls.Add(this.btn_kelolauser);
            this.Controls.Add(this.btn_laporantransaksi);
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Admin_FormClosing);
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_laporantransaksi;
        private System.Windows.Forms.Button btn_kelolauser;
        private System.Windows.Forms.Button btn_kelolamenu;

    }
}