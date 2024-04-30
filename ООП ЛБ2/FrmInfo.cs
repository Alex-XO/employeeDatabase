using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛБ2
{
    public partial class FrmInfo : Form
    {
        public string f;
        public string n;
        public string o;
        public int Summa;
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmInfo_Shown(object sender, EventArgs e)
        {
            txtFam.Text = f;
            txtName.Text = n;
            txtOtch.Text = o;
            txtSumma.Text = Summa.ToString()+" рублей";
        }

        private void FrmInfo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtFam.ReadOnly = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtFam.ReadOnly = true;
        }

        private void txtOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtFam.ReadOnly = true;
        }

        private void txtSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtFam.ReadOnly = true;
        }

        private void txtFam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
