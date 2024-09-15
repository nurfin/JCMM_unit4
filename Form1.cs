
namespace JCMM_Unit3
{
    public partial class Finances : Form
    {
        private decimal totalAmount = 10000;
        public Finances()
        {
            InitializeComponent();
            UpdateTotalAmountDisplay();
        }
        public partial class InputForm : Form
        {
            private string v;

            public InputForm(string v)
            {
                this.v = v;
            }

            public decimal Amount { get; private set; }
        }

        private void UpdateTotalAmountDisplay()
        {
            MoneyDisplayTotal.Text = totalAmount.ToString("C");
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputForm("Expense"))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    decimal expense = inputForm.Amount;
                    totalAmount -= expense;
                    UpdateTotalAmountDisplay();
                }
            }
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputForm("Income"))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    decimal income = inputForm.Amount;
                    totalAmount += income;
                    UpdateTotalAmountDisplay();
                }
            }
        }

        private void SetIncomeButton_Click(object sender, EventArgs e)
        {
            SetIncomeForm form = new SetIncomeForm();
            form.Show();
        }

        private void ViewTransactionsButton_Click(object sender, EventArgs e)
        {

        }

        private void SetGoalsButton_Click(object sender, EventArgs e)
        {

        }
    }
}

    