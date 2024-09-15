using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCMM_Unit3
{
    public partial class SetIncomeForm : Form
    {
        public SetIncomeForm()
        {
            InitializeComponent();
        }

        private void SalaryDropdownButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            string salary = SalaryDropdownButton.Text;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
          //  string salary = SalaryDropdownButton.SelectedItem.ToString();
        }
    }
}
