using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal MINIMUM_SALARY = 40000m;
                const decimal MINIMUM_YEARS_ON_JOB = 2;

                decimal Salary;
                int yearsOnJob;

                Salary=decimal.Parse(txt_Salary.Text);
                yearsOnJob = int.Parse(txtYears.Text);

                if(Salary>=MINIMUM_SALARY)
                {
                    if(yearsOnJob>=MINIMUM_YEARS_ON_JOB)
                    {
                        lblDescription.Text = "You are applicable for loan";
                    }
                    else
                    {
                        lblDescription.Text = "Sorry you are not applicable for loan";
                    }
                }
                else
                {
                    lblDescription.Text = "Sorry you are not applicable for loan";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Salary.Text = "";
            txtYears.Text = "";
            lblDescription.Text = "";

            txt_Salary.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
