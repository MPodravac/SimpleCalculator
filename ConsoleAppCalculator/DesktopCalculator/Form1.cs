using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{
    public partial class Form1 : Form
    {
        public float fPrviBr, fDrugiBr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fPrviBr = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBr = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBr + fDrugiBr);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fPrviBr = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBr = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBr * fDrugiBr);
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            fPrviBr = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBr = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBr - fDrugiBr);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fPrviBr = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBr = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBr / fDrugiBr);
        }
    }
}
