using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            TotalSalaryCalculation salary = new TotalSalaryCalculation();

            salary.Name = employeeNameTextBox.Text;
            salary.BasicSalary = Convert.ToDouble(basicAmountTextBox.Text);
            salary.HomeRent = Convert.ToDouble(homeRentTextBox.Text);
            salary.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            MessageBox.Show(salary.Report());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
