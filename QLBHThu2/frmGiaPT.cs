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
    public partial class frmGiaPT : Form
    {
        int a,b,c;
        double d,x1,x2;
        public frmGiaPT()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            a=Convert.ToInt32(txtA.Text);
            b=Convert.ToInt32(txtB.Text);
            c=Convert.ToInt32(txtC.Text);
            d=b*b-4*a*c;
            if(d<0)
            {
                lblKQ.Text="Phương trình vô nghiệm";
            }
            else if(d==0)
            {
                x1=-b/(2*a);
                  lblKQ.Text="Phuong trinh co nghiem kep x1=x2=" +Convert.ToString(x1);
            }
            else
            {
                x1=(-b+Math.Sqrt(d))/(2*a);
                x2=(-b-Math.Sqrt(d))/(2*a);
                lblKQ.Text = "Phuong trinh co nghiem kep x1=" + Convert.ToString(Math.Round(x1,1)) + " va x2=" + Convert.ToString(x2);
            }
        }
    }
}
