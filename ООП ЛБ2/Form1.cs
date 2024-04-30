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
    public partial class Form1 : Form
    {
        const int N = 10;
        Sotr[] sotr = new Sotr[N];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < N)
            {
                int ind = Find(txtFam.Text, txtName.Text, txtOtch.Text);
                if(ind!=-1)
                {
                    MessageBox.Show("Сотрудник с такими данными уже есть в базе");
                    return;
                }
                Sotr dat=null;
                if (radioButton1.Checked)
                    dat = new SotrFix(txtFam.Text, txtName.Text, txtOtch.Text,Convert.ToInt32(txtFixSumma.Text));
                if (radioButton2.Checked)
                    dat = new SotrDay(txtFam.Text, txtName.Text, txtOtch.Text, Convert.ToInt32(txtCount.Text), Convert.ToInt32(txtStoim.Text));
                if (radioButton3.Checked)
                    dat = new SotrComission(txtFam.Text, txtName.Text, txtOtch.Text, Convert.ToInt32(txtProdag.Text), Convert.ToSingle(txtPercent.Text));
                if (dat != null)
                {
                    sotr[count] = dat;
                    count++;
                    txtCounSotr.Text = count.ToString();
                }
            }
            else
                MessageBox.Show("Вы достигли предела массива");

        }
        int Find(string f,string n,string o)
        {
            for (int i = 0; i < count; i++)
                if (sotr[i].IsThisSotr(f, n, o))
                    return i;
            return -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Summa = 0;
            for (int i = 0; i < count; i++)
                Summa = Summa + sotr[i].GetSalary();
            txtSumma.Text = Summa.ToString() + "рублей";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = Find(txtFam.Text, txtName.Text, txtOtch.Text);
            if (ind != -1)
            {
                FrmInfo frm = new FrmInfo();
                frm.f = sotr[ind].fam;
                frm.n = sotr[ind].name;
                frm.o = sotr[ind].otch;
                frm.Summa = sotr[ind].GetSalary();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Данный сотрудник не найден");
        }

        private void txtFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
                e.Handled = true;
        }

        private void txtSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtFam.ReadOnly = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
                e.Handled = true;
        }

        private void txtOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
                e.Handled = true;
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            e.Handled=!(char.IsDigit(n)||n=='.'||n==','|| n=='\b');
        }

        private void txtStoim_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            e.Handled = !(char.IsDigit(n) || n == '.'|| n == ',' || n == '\b');
        }

        private void txtCounSotr_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtFam.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
