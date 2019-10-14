using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class TotalSalaryCalculation
    {
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double HomeRent { get; set; }
        public double MedicalAllowance { get; set; }
        public double ShowTotalSalary { get; set; }
        public double HomeBasic { get; set; }
        public double MedicalBasic { get; set; }
        public double GetTotalSalary()
        {
            ShowTotalSalary = BasicSalary + PersentanceHomeSalary();
            double ShowTotalSalary1 = ShowTotalSalary + PersentanceMedicalSalary();

            return ShowTotalSalary1;
        }
        public double PersentanceHomeSalary()
        {
            HomeBasic = (BasicSalary * HomeRent)/100;
            return HomeBasic;
        }
        public double PersentanceMedicalSalary()
        {
            MedicalBasic = (BasicSalary * MedicalAllowance) / 100;
            return MedicalBasic;
        }
        public string Report()
        {
           string  ShowResul = "" + Name + " Your salary is:  " + GetTotalSalary().ToString();
           return ShowResul;
        }
    }
}
