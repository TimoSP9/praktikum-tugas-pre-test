
namespace praktikum_tugas_pre_test
{
    partial class Form_Tampil_Data
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
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_Alamat = new System.Windows.Forms.Label();
            this.lbl_Telp = new System.Windows.Forms.Label();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_Pdata = new System.Windows.Forms.Button();
            this.btn_Ndata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(47, 46);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(56, 20);
            this.lbl_nama.TabIndex = 0;
            this.lbl_nama.Text = "Nama :";
            // 
            // lbl_Alamat
            // 
            this.lbl_Alamat.AutoSize = true;
            this.lbl_Alamat.Location = new System.Drawing.Point(47, 104);
            this.lbl_Alamat.Name = "lbl_Alamat";
            this.lbl_Alamat.Size = new System.Drawing.Size(64, 20);
            this.lbl_Alamat.TabIndex = 1;
            this.lbl_Alamat.Text = "Alamat :";
            // 
            // lbl_Telp
            // 
            this.lbl_Telp.AutoSize = true;
            this.lbl_Telp.Location = new System.Drawing.Point(47, 167);
            this.lbl_Telp.Name = "lbl_Telp";
            this.lbl_Telp.Size = new System.Drawing.Size(44, 20);
            this.lbl_Telp.TabIndex = 2;
            this.lbl_Telp.Text = "Telp :";
            // 
            // btn_kembali
            // 
            this.btn_kembali.Location = new System.Drawing.Point(47, 283);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(94, 29);
            this.btn_kembali.TabIndex = 3;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            // 
            // btn_Pdata
            // 
            this.btn_Pdata.Location = new System.Drawing.Point(207, 283);
            this.btn_Pdata.Name = "btn_Pdata";
            this.btn_Pdata.Size = new System.Drawing.Size(94, 29);
            this.btn_Pdata.TabIndex = 4;
            this.btn_Pdata.Text = "Prev Data";
            this.btn_Pdata.UseVisualStyleBackColor = true;
            // 
            // btn_Ndata
            // 
            this.btn_Ndata.Location = new System.Drawing.Point(378, 283);
            this.btn_Ndata.Name = "btn_Ndata";
            this.btn_Ndata.Size = new System.Drawing.Size(94, 29);
            this.btn_Ndata.TabIndex = 5;
            this.btn_Ndata.Text = "Next Data";
            this.btn_Ndata.UseVisualStyleBackColor = true;
            // 
            // Form_Tampil_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ndata);
            this.Controls.Add(this.btn_Pdata);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.lbl_Telp);
            this.Controls.Add(this.lbl_Alamat);
            this.Controls.Add(this.lbl_nama);
            this.Name = "Form_Tampil_Data";
            this.Text = "Form Tampil Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_Alamat;
        private System.Windows.Forms.Label lbl_Telp;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_Pdata;
        private System.Windows.Forms.Button btn_Ndata;
    }
}