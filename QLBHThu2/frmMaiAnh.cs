using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHThu2
{
    public partial class frmMaiAnh : Form
    {
        // khai báo biến toàn cục (khai báo a,b,c ở đây) 
        double a, b, c, d, x1, x2;
        public frmMaiAnh()
        {
            InitializeComponent();
        }

        private void frmMaiAnh_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGpt_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            d = b * b - 4 * a * c;
            if (d < 0)
            lblKq.Text = "Phuong trinh vo nghiem";
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                lblKq.Text = "Phuong trinh co nghiem kep x1 = x2 = " + Math.Round(x1,1);
                // MessageBox.Show("Phuong trinh co nghiem kep x1 = x2 = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                lblKq.Text = "Phuong trinh co 2 nghiem phan biet: x1 =" + Math.Round(x1,1) + ", x2 = " + Math.Round(x2,1);
                // MessageBox.Show("Phuong trinh co 2 nghiem phan biet: x1 = " + x1 + ", x2 = " + x2);

            }
    }
}
}
