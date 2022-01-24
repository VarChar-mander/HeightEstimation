using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightEstimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dadlabel_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectGirl_CheckedChanged(object sender, EventArgs e)
        {
            if (selectGirl.Checked)
                SelectBoy.Checked = false;
        }

        private void SelectBoy_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectBoy.Checked)
                selectGirl.Checked = false;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            selectGirl.Enabled = false;
            SelectBoy.Enabled = false;
            momHeight.Enabled = false;
            dadHeight.Enabled = false;
            string outputText = "";
            int feet;
            int inches;
            decimal temp;
            int temp2;
            decimal temp3;
            if (selectGirl.Checked)
            {
                temp = momHeight.Value + dadHeight.Value;
                temp2 = Decimal.ToInt32(temp);
                temp = temp2 / 2 - 5;
                temp3 = 
                //feet = temp / 12;
                //inches = temp % 12;
                temp3 = temp - temp2;
                //outputText = "Daughter's height will be " + feet + " feet and " + inches + " inches tall.";
            }
                
            if (SelectBoy.Checked)
            {
                temp = momHeight.Value + dadHeight.Value;
                temp2 = Decimal.ToInt32(temp);
                temp = temp2 / 2 + 5;
                //feet = temp / 12;
                //inches = temp % 12;
                temp3 = temp - temp2;
                //outputText = "Daughter's height will be " + feet + " feet and " + inches + " inches tall.";
            }
            if (outputText == "")
                        outputText = "Please enter missing fields";
            Output.Text = outputText;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            selectGirl.Enabled = true;
            selectGirl.Checked = false;
            SelectBoy.Enabled = true;
            SelectBoy.Checked = false;
            momHeight.Enabled = true;
            dadHeight.Enabled = true;
            momHeight.Value = 65;
            dadHeight.Value = 69;
            Output.Visible = false;
        }
    }
}
