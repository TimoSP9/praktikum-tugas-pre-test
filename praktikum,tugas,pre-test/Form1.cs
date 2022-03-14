using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_tugas_pre_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static DataTable dataNama = new DataTable();
        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            dataNama.Columns.Add("Nama");
            dataNama.Columns.Add("Alamat");
            dataNama.Columns.Add("Telp");
            dataNama.Rows.Add(txtBox_Nama.Text, txtBox_alamat.Text, txtBox_telp.Text);
            
        }


        private void txtBox_telp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Nama_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
