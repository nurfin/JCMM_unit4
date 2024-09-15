namespace JCMM_Unit3
{
    partial class Finances
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MoneyDisplayTotal = new TextBox();
            ExpenseButton = new Button();
            IncomeButton = new Button();
            ViewTransactionsButton = new Button();
            SetIncomeButton = new Button();
            SetGoalsButton = new Button();
            SuspendLayout();
            // 
            // MoneyDisplayTotal
            // 
            MoneyDisplayTotal.Location = new Point(105, 28);
            MoneyDisplayTotal.Name = "MoneyDisplayTotal";
            MoneyDisplayTotal.Size = new Size(514, 39);
            MoneyDisplayTotal.TabIndex = 0;
            // 
            // ExpenseButton
            // 
            ExpenseButton.Location = new Point(105, 82);
            ExpenseButton.Name = "ExpenseButton";
            ExpenseButton.Size = new Size(248, 46);
            ExpenseButton.TabIndex = 1;
            ExpenseButton.Text = "Expense";
            ExpenseButton.UseVisualStyleBackColor = true;
            // 
            // IncomeButton
            // 
            IncomeButton.Location = new Point(371, 82);
            IncomeButton.Name = "IncomeButton";
            IncomeButton.Size = new Size(248, 46);
            IncomeButton.TabIndex = 2;
            IncomeButton.Text = "Income";
            IncomeButton.UseVisualStyleBackColor = true;
            // 
            // ViewTransactionsButton
            // 
            ViewTransactionsButton.Location = new Point(78, 256);
            ViewTransactionsButton.Name = "ViewTransactionsButton";
            ViewTransactionsButton.Size = new Size(211, 50);
            ViewTransactionsButton.TabIndex = 7;
            ViewTransactionsButton.Text = "View Transactions";
            ViewTransactionsButton.UseVisualStyleBackColor = true;
            ViewTransactionsButton.Click += ViewTransactionsButton_Click;
            // 
            // SetIncomeButton
            // 
            SetIncomeButton.Location = new Point(78, 200);
            SetIncomeButton.Name = "SetIncomeButton";
            SetIncomeButton.Size = new Size(211, 50);
            SetIncomeButton.TabIndex = 8;
            SetIncomeButton.Text = "Set Income";
            SetIncomeButton.UseVisualStyleBackColor = true;
            SetIncomeButton.Click += SetIncomeButton_Click;
            // 
            // SetGoalsButton
            // 
            SetGoalsButton.Location = new Point(78, 312);
            SetGoalsButton.Name = "SetGoalsButton";
            SetGoalsButton.Size = new Size(211, 50);
            SetGoalsButton.TabIndex = 9;
            SetGoalsButton.Text = "Set Goals";
            SetGoalsButton.UseVisualStyleBackColor = true;
            SetGoalsButton.Click += SetGoalsButton_Click;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SetGoalsButton);
            Controls.Add(SetIncomeButton);
            Controls.Add(ViewTransactionsButton);
            Controls.Add(IncomeButton);
            Controls.Add(ExpenseButton);
            Controls.Add(MoneyDisplayTotal);
            Name = "Finances";
            Text = "Finances";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MoneyDisplayTotal;
        private Button ExpenseButton;
        private Button IncomeButton;
        private Button ViewTransactionsButton;
        private Button SetIncomeButton;
        private Button SetGoalsButton;
    }
}
