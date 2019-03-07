// Dalyssa Webb, DS3850-001, HW1, 01/28/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webbDalyssaHW1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            // Today's date and time
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input and output, reset rank and performance, and reset foucs
            radHigh.Checked = true;
            radExcellent.Checked = true;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIDNumber.Clear();
            txtSalary.Clear();
            lblOutput.Text = "";
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        private void frmCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display message box when Exit button is clicked
            DialogResult dlgReply;
            dlgReply = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgReply == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // Declare variables and constants
            string strFirstName=txtFirstName.Text, strLastName=txtLastName.Text, strRank, strPerformance;
            decimal decSalary, decBonusPercent, decBonus;
            int intIDNumber;
            bool blnValid = true;
            string strErr = "";
            const int intMinFirstName = 1, intMaxFirstName = 20, intMinLastName = 1, intMaxLastName = 30, intMinIDNumber = 1, intMaxIDNumber = 5000;
            const decimal decSeniority = 0.05m, decMinSalary = 20000, decMaxSalary = 1000000;
            // Validate input
            if (txtFirstName.Text.Length < 1 || txtFirstName.Text.Length > 20)
            {
                blnValid = false;
                strErr = "First name must be between " + intMinFirstName.ToString() + " and " + intMaxFirstName.ToString() + " characters long." + "\n";
            }
            if (txtLastName.Text.Length < 1 || txtLastName.Text.Length > 30)
            {
                blnValid = false;
                strErr += "Last name must be between " + intMinLastName.ToString() + " and " + intMaxLastName.ToString() + " characters long." + "\n";
            }
            // Parse ID Number and validate
            if (!int.TryParse(txtIDNumber.Text, out intIDNumber))
            {
                blnValid = false;
                strErr += "ID Number must be an integer value." + "\n";
            }
            else // User entered integer value
            {
                if (intIDNumber < intMinIDNumber || intIDNumber > intMaxIDNumber)
                {
                    blnValid = false;
                    strErr += "ID Number must be between " + intMinIDNumber.ToString() + " and " + intMaxIDNumber.ToString() + "." + "\n";
                }
            }
            // Validate Annual Salary
            if (decimal.TryParse(txtSalary.Text, out decSalary))
            {
                if (decSalary < 20000 || decSalary > 1000000)
                {
                    blnValid = false;
                    strErr += "Annual salary must be between " + decMinSalary.ToString() + " and " + decMaxSalary.ToString() + "." + "\n";
                }
            }
            else // User entered non-decimal value 
            {
                blnValid = false;
                strErr += "Annual salary must be numeric." + "\n";
            }
            if (blnValid)
            {
                // Determine bonus percentage
                if (radHigh.Checked == true)
                {
                    strRank = "High";
                }
                else if (radMedium.Checked == true)
                {
                    strRank = "Medium";
                }
                else // Rank is low
                {
                    strRank = "Low";
                }
                if (radExcellent.Checked == true)
                {
                    strPerformance = "Excellent";
                }
                else if (radGood.Checked == true)
                {
                    strPerformance = "Good";
                }
                else // Performance is fair
                {
                    strPerformance = "Fair";
                }
                if (strRank == "High")
                {
                    if (strPerformance == "Excellent")
                    {
                        decBonusPercent = .80m;
                    }
                    else if (strPerformance == "Good")
                    {
                        decBonusPercent = .60m;
                    }
                    else // Performance is fair
                    {
                        decBonusPercent = .45m;
                    }
                }
                else if (strRank == "Medium")
                {
                    if (strPerformance == "Excellent")
                    {
                        decBonusPercent = .65m;
                    }
                    else if (strPerformance == "Good")
                    {
                        decBonusPercent = .40m;
                    }
                    else // Performance is fair
                    {
                        decBonusPercent = .25m;
                    }
                }
                else // Rank is Low
                {
                    if (strPerformance == "Excellent")
                    {
                        decBonusPercent = .50m;
                    }
                    else if (strPerformance == "Good")
                    {
                        decBonusPercent = .30m;
                    }
                    else // Performance is fair
                    {
                        decBonusPercent = .15m;
                    }
                }
                // Check for high seniority 
                if (intIDNumber < 100)
                {
                    decBonusPercent += decSeniority;
                }
                // Calculate bonus
                decBonus = decSalary * decBonusPercent;
                // Create output and display on form
                if (intIDNumber < 100)
                {
                    lblOutput.Text = "This bonus calculation was generated for " + strFirstName + " " + strLastName + " on " + lblDate.Text + " at " + lblTime.Text + ". Based on an employee rank of "
                    + strRank + ", a performance rating of " + strPerformance + ", and a high seniority level (ID Number of " + intIDNumber + "), " + strFirstName +
                    "'s bonus percentage will be " + decBonusPercent.ToString("p") + ". Applying this bonus percentage to an annual salary of " + decSalary.ToString("c") + ", " + strFirstName + " will receive a bonus of "
                    + decBonus.ToString("c") + ".";
                }
                else // ID Number is >100, no high seniority bonus
                {
                    lblOutput.Text = "This bonus calculation was generated for " + strFirstName + " " + strLastName + " on " + lblDate.Text + " at " + lblTime.Text + ". Based on an employee rank of "
                    + strRank + " and a performance rating of " + strPerformance + ", " + strFirstName + "'s bonus percentage will be " + decBonusPercent.ToString("p") + 
                    ". Applying this bonus percentage to an annual salary of " + decSalary.ToString("c") + ", " + strFirstName + " will receive a bonus of " + decBonus.ToString("c") + ".";
                }
            }
            else
            {
                MessageBox.Show(strErr);
            }
        }

        private void radHigh_CheckedChanged(object sender, EventArgs e)
        {
            // Clear output label if user changes Rank or Performance
            lblOutput.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            // Clear output label if user changes any textbox input
            lblOutput.Text = "";
        }
    }
}
