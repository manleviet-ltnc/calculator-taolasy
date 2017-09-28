using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool isTypingNumber = false;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NhapSo("1");
        }

        private void NhapSo(string so)
        {
            if (isTypingNumber)
                lbldisplay.Text = lbldisplay.Text + so;

            else
            {
                lbldisplay.Text = so;
                isTypingNumber = true;
            }

        }
    }
}