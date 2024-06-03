using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHArp_ptbac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnptbac1_Click(object sender, EventArgs e)
        {
            double a, b, ketqua;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            if (a != 0)
            {
                ketqua = -b / a;
                lblkq.Text = "nghiệm của phương trình là ketqua =" + ketqua.ToString();
            }
            else
            {
                if (b != 0)
                    lblkq.Text = "phương trình vô nghiệm";

                else
                {
                    lblkq.Text = "phương trình nghiệm đúng với mọi ketqua";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtA.Text=trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtB.Text = trackBar2.Value.ToString();
        }
    }
        }
