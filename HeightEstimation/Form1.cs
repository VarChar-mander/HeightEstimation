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
            decimal inches;
            decimal total;
            decimal formula;
            
            if (selectGirl.Checked)
            {
                total = momHeight.Value + dadHeight.Value;
                formula = (total - 5) / 2;
                feet = Decimal.ToInt32(formula) / 12;
                inches = formula - feet * 12;
                inches = Decimal.Round(inches, 2);
                //feet = temp / 12;
                //inches = temp % 12;
                outputText = "Daughter will be " + feet + " feet and " + inches + " inches tall.";
            }
                
            if (SelectBoy.Checked)
            {
                total = momHeight.Value + dadHeight.Value;
                formula = (total + 5) / 2;
                feet = Decimal.ToInt32(formula) / 12;
                inches = formula - feet * 12;
                inches = Decimal.Round(inches, 2);
                //feet = temp / 12;
                //inches = temp % 12;
                outputText = "Son will be " + feet + " feet and " + inches + " inches tall.";
            }
            if (outputText == "")
                        outputText = "Please enter missing fields.";
            Output.Text = outputText;
            Output.Visible = true;
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

        private void momHeight_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
