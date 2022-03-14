
namespace praktikum_tugas_pre_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtBox_Nama = new System.Windows.Forms.TextBox();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_lihatdata = new System.Windows.Forms.Button();
            this.txtBox_alamat = new System.Windows.Forms.TextBox();
            this.txtBox_telp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(31, 62);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nama   :";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // txtBox_Nama
            // 
            this.txtBox_Nama.Location = new System.Drawing.Point(119, 59);
            this.txtBox_Nama.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Nama.Name = "txtBox_Nama";
            this.txtBox_Nama.Size = new System.Drawing.Size(534, 32);
            this.txtBox_Nama.TabIndex = 1;
            this.txtBox_Nama.TextChanged += new System.EventHandler(this.txtBox_Nama_TextChanged);
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Location = new System.Drawing.Point(31, 139);
            this.lbl_alamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(80, 25);
            this.lbl_alamat.TabIndex = 2;
            this.lbl_alamat.Text = "Alamat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telp     :";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(140, 345);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(118, 36);
            this.btn_simpan.TabIndex = 4;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_lihatdata
            // 
            this.btn_lihatdata.Location = new System.Drawing.Point(335, 345);
            this.btn_lihatdata.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lihatdata.Name = "btn_lihatdata";
            this.btn_lihatdata.Size = new System.Drawing.Size(118, 36);
            this.btn_lihatdata.TabIndex = 5;
            this.btn_lihatdata.Text = "Lihat Data";
            this.btn_lihatdata.UseVisualStyleBackColor = true;
            // 
            // txtBox_alamat
            // 
            this.txtBox_alamat.Location = new System.Drawing.Point(119, 139);
            this.txtBox_alamat.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_alamat.Name = "txtBox_alamat";
            this.txtBox_alamat.Size = new System.Drawing.Size(726, 32);
            this.txtBox_alamat.TabIndex = 6;
            // 
            // txtBox_telp
            // 
            this.txtBox_telp.Location = new System.Drawing.Point(119, 226);
            this.txtBox_telp.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_telp.Name = "txtBox_telp";
            this.txtBox_telp.Size = new System.Drawing.Size(533, 32);
            this.txtBox_telp.TabIndex = 7;
            this.txtBox_telp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_telp_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtBox_telp);
            this.Controls.Add(this.txtBox_alamat);
            this.Controls.Add(this.btn_lihatdata);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.txtBox_Nama);
            this.Controls.Add(this.lbl_name);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form Penambah Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtBox_Nama;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_lihatdata;
        private System.Windows.Forms.TextBox txtBox_alamat;
        private System.Windows.Forms.TextBox txtBox_telp;
    }
}

