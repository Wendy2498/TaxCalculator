/*Wendy Faulk
 * 5/23/2021
 * Extra 6-2
 * Wk 4 Murach Coding Assignments (Teamword done individually)*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);

            //Modify statment to get its value by calling CalculateTax method.
            decimal tax = CalculateTax(income);

            txtTax.Text = tax.ToString();
        }

        //Code the declaration for a private method, Calculate_Tax.
        private decimal CalculateTax(decimal income)    //Receives the income amount.
        {
            //Declare a variable for tax.
            decimal tax = 0m;

            //Move the if statement to this method.
            if (income <= 9875)
                tax = (int)(income * .10m);
            else if (income > 9875 && income <= 40125)
                tax = 987.5m + (int)((income - 9875) * .12m);
            else if (income > 40125 && income <= 85525)
                tax = 4617.5m + (int)((income - 40125) * .22m);
            else if (income > 85525 && income <= 163300)
                tax = 14605.5m + (int)((income - 85525) * .24m);
            else if (income > 163300 && income <= 207350)
                tax = 33271.5m + (int)((income - 163300) * .32m);
            else if (income > 207351 && income <= 518400)
                tax = 47367.5m + (int)((income - 518400) * .35m);
            else if (income > 518401)
                tax = 156235m + (int)((income - 518400) * .37m);

            //Return the tax.
            return tax;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Create event handler to clear tax text box if user changes value in Taxable Income text box.
        private void ClearIncomeTaxOwed(object sender, EventArgs e)
        {
            txtTax.Text = "";   //Clears tax amount.
        }
    }
}
