using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliedSystemsTest
{
    public partial class PleaseEnterYourDetails : Form
    {
        public PleaseEnterYourDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numOfClaims_ValueChanged(object sender, EventArgs e)
        {
            if (numOfClaims.Value == 1)
            {
                Claim1Label.Visible = true;
                Claim1Date.Visible = true;
            }
            if (numOfClaims.Value == 2)
            {
                Claim1Label.Visible = true;
                Claim1Date.Visible = true;
                Claim2Label.Visible = true;
                Claim2Date.Visible = true;
            }
            if (numOfClaims.Value == 3)
            {
                Claim1Label.Visible = true;
                Claim1Date.Visible = true;
                Claim2Label.Visible = true;
                Claim2Date.Visible = true;
                Claim3Label.Visible = true;
                Claim3Date.Visible = true;
            }
            if (numOfClaims.Value == 4)
            {
                Claim1Label.Visible = true;
                Claim1Date.Visible = true;

                Claim2Label.Visible = true;
                Claim2Date.Visible = true;

                Claim3Label.Visible = true;
                Claim3Date.Visible = true;

                Claim4Label.Visible = true;
                Claim4Date.Visible = true;
            }
            if (numOfClaims.Value == 5)
            {
                Claim1Label.Visible = true;
                Claim1Date.Visible = true;

                Claim2Label.Visible = true;
                Claim2Date.Visible = true;

                Claim3Label.Visible = true;
                Claim3Date.Visible = true;

                Claim4Label.Visible = true;
                Claim4Date.Visible = true;

                Claim5Label.Visible = true;
                Claim5Date.Visible = true;
            }
        }

        private void Claim1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
