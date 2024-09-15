namespace JCMM_Unit3
{
    partial class SetIncomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SalaryDropdownButton = new ComboBox();
            PayFrequencyLabel = new Label();
            AmountLabel = new Label();
            SalaryAmountTextbox = new TextBox();
            CalculateLabel = new Label();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // SalaryDropdownButton
            // 
            SalaryDropdownButton.FormattingEnabled = true;
            SalaryDropdownButton.Items.AddRange(new object[] { "Weekly", "Biweekly", "Annual Salary" });
            SalaryDropdownButton.Location = new Point(12, 100);
            SalaryDropdownButton.Name = "SalaryDropdownButton";
            SalaryDropdownButton.Size = new Size(242, 40);
            SalaryDropdownButton.TabIndex = 0;
            SalaryDropdownButton.SelectedIndexChanged += SalaryDropdownButton_SelectedIndexChanged;
            // 
            // PayFrequencyLabel
            // 
            PayFrequencyLabel.Location = new Point(12, 47);
            PayFrequencyLabel.Name = "PayFrequencyLabel";
            PayFrequencyLabel.Size = new Size(242, 54);
            PayFrequencyLabel.TabIndex = 1;
            PayFrequencyLabel.Text = "Pay Frequency";
            // 
            // AmountLabel
            // 
            AmountLabel.Location = new Point(270, 47);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(242, 54);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "Amount";
            // 
            // SalaryAmountTextbox
            // 
            SalaryAmountTextbox.Location = new Point(270, 100);
            SalaryAmountTextbox.Name = "SalaryAmountTextbox";
            SalaryAmountTextbox.Size = new Size(200, 39);
            SalaryAmountTextbox.TabIndex = 3;
            // 
            // CalculateLabel
            // 
            CalculateLabel.Location = new Point(495, 47);
            CalculateLabel.Name = "CalculateLabel";
            CalculateLabel.Size = new Size(242, 54);
            CalculateLabel.TabIndex = 4;
            CalculateLabel.Text = "Calculate";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(495, 93);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(208, 46);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // SetIncomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateButton);
            Controls.Add(CalculateLabel);
            Controls.Add(SalaryAmountTextbox);
            Controls.Add(AmountLabel);
            Controls.Add(PayFrequencyLabel);
            Controls.Add(SalaryDropdownButton);
            Name = "SetIncomeForm";
            Text = "SetIncomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SalaryDropdownButton;
        private Label PayFrequencyLabel;
        private Label AmountLabel;
        private TextBox SalaryAmountTextbox;
        private Label CalculateLabel;
        private Button CalculateButton;
    }
}