namespace VirtualBankWinForms
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lbl_account = new Label();
            lbl_balance = new Label();
            groupBox1 = new GroupBox();
            lbl_currency = new Label();
            cbb_currency = new ComboBox();
            txt_amount = new TextBox();
            lbl_amount = new Label();
            btn_deposit = new Button();
            btn_withdraw = new Button();
            exchangeRateBindingSource1 = new BindingSource(components);
            exchangeRateBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            cbb_account = new ComboBox();
            txt_balance = new TextBox();
            txt_welcome = new TextBox();
            btn_load_customer = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exchangeRateBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exchangeRateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_account
            // 
            lbl_account.AutoSize = true;
            lbl_account.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_account.Location = new Point(510, 234);
            lbl_account.Name = "lbl_account";
            lbl_account.Size = new Size(138, 37);
            lbl_account.TabIndex = 1;
            lbl_account.Text = "Account : ";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_balance.Location = new Point(510, 311);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(134, 37);
            lbl_balance.TabIndex = 2;
            lbl_balance.Text = "Balance :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(lbl_currency);
            groupBox1.Controls.Add(cbb_currency);
            groupBox1.Controls.Add(txt_amount);
            groupBox1.Controls.Add(lbl_amount);
            groupBox1.Controls.Add(btn_deposit);
            groupBox1.Controls.Add(btn_withdraw);
            groupBox1.Font = new Font("Tw Cen MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(137, 380);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 257);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction";
            // 
            // lbl_currency
            // 
            lbl_currency.AutoSize = true;
            lbl_currency.Location = new Point(427, 73);
            lbl_currency.Name = "lbl_currency";
            lbl_currency.Size = new Size(123, 31);
            lbl_currency.TabIndex = 6;
            lbl_currency.Text = "Currency :";
            // 
            // cbb_currency
            // 
            cbb_currency.FormattingEnabled = true;
            cbb_currency.Items.AddRange(new object[] { "USD", "MXN", "EUR", "CAD" });
            cbb_currency.Location = new Point(556, 70);
            cbb_currency.Name = "cbb_currency";
            cbb_currency.Size = new Size(135, 39);
            cbb_currency.TabIndex = 5;
            cbb_currency.SelectedIndexChanged += cbb_currency_SelectedIndexChanged;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(175, 70);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(188, 37);
            txt_amount.TabIndex = 3;
            txt_amount.TextChanged += txt_amount_TextChanged;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Font = new Font("Tw Cen MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_amount.ForeColor = SystemColors.Desktop;
            lbl_amount.Location = new Point(49, 68);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(104, 36);
            lbl_amount.TabIndex = 2;
            lbl_amount.Text = "Amount :";
            lbl_amount.UseCompatibleTextRendering = true;
            // 
            // btn_deposit
            // 
            btn_deposit.Font = new Font("Tw Cen MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deposit.Location = new Point(427, 151);
            btn_deposit.Name = "btn_deposit";
            btn_deposit.RightToLeft = RightToLeft.No;
            btn_deposit.Size = new Size(264, 46);
            btn_deposit.TabIndex = 1;
            btn_deposit.Text = "DEPOSIT";
            btn_deposit.UseVisualStyleBackColor = true;
            btn_deposit.Click += btn_deposit_Click;
            // 
            // btn_withdraw
            // 
            btn_withdraw.Font = new Font("Tw Cen MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_withdraw.Location = new Point(99, 151);
            btn_withdraw.Name = "btn_withdraw";
            btn_withdraw.Size = new Size(264, 46);
            btn_withdraw.TabIndex = 0;
            btn_withdraw.Text = "WITHDRAW";
            btn_withdraw.UseVisualStyleBackColor = true;
            btn_withdraw.Click += btn_withdraw_Click;
            // 
            // exchangeRateBindingSource1
            // 
            exchangeRateBindingSource1.DataSource = typeof(ConsoleBank.Models.ExchangeRate);
            // 
            // exchangeRateBindingSource
            // 
            exchangeRateBindingSource.DataSource = typeof(ConsoleBank.Models.ExchangeRate);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.datacan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(137, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 158);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // cbb_account
            // 
            cbb_account.FormattingEnabled = true;
            cbb_account.Items.AddRange(new object[] { "421" });
            cbb_account.Location = new Point(661, 234);
            cbb_account.Name = "cbb_account";
            cbb_account.Size = new Size(242, 40);
            cbb_account.TabIndex = 5;
            cbb_account.SelectedIndexChanged += cbb_account_SelectedIndexChanged;
            // 
            // txt_balance
            // 
            txt_balance.BackColor = SystemColors.ControlLightLight;
            txt_balance.BorderStyle = BorderStyle.None;
            txt_balance.Location = new Point(664, 311);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(239, 32);
            txt_balance.TabIndex = 6;
            txt_balance.TextChanged += txt_balance_TextChanged;
            // 
            // txt_welcome
            // 
            txt_welcome.BackColor = SystemColors.ControlLightLight;
            txt_welcome.BorderStyle = BorderStyle.None;
            txt_welcome.Location = new Point(137, 242);
            txt_welcome.Name = "txt_welcome";
            txt_welcome.Size = new Size(244, 32);
            txt_welcome.TabIndex = 7;
            // 
            // btn_load_customer
            // 
            btn_load_customer.BackColor = SystemColors.ScrollBar;
            btn_load_customer.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_load_customer.Location = new Point(664, 47);
            btn_load_customer.Name = "btn_load_customer";
            btn_load_customer.Size = new Size(239, 46);
            btn_load_customer.TabIndex = 8;
            btn_load_customer.Text = "Load Customer";
            btn_load_customer.UseVisualStyleBackColor = false;
            btn_load_customer.Click += btn_load_customer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1113, 749);
            Controls.Add(btn_load_customer);
            Controls.Add(txt_welcome);
            Controls.Add(txt_balance);
            Controls.Add(cbb_account);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(lbl_balance);
            Controls.Add(lbl_account);
            Name = "Form1";
            Text = "DataCan Virtual Bank";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exchangeRateBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exchangeRateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_account;
        private Label lbl_balance;
        private GroupBox groupBox1;
        private TextBox txt_amount;
        private Label lbl_amount;
        private Button btn_deposit;
        private Button btn_withdraw;
        private PictureBox pictureBox1;
        private ComboBox cbb_currency;
        private ComboBox cbb_account;
        private Label lbl_currency;
        private TextBox txt_welcome;
        private TextBox txt_balance;
        private BindingSource exchangeRateBindingSource;
        private BindingSource exchangeRateBindingSource1;
        private Button btn_load_customer;
    }
}
