﻿namespace NotesApp
{
    partial class Form7
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
            panel1 = new Panel();
            ConvertTempButton = new Button();
            ToCurrencyCombo = new ComboBox();
            FromCurrencyCombo = new ComboBox();
            ConvertCurrencyButton = new Button();
            AmountTxtBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            LblCurrencyResult = new Label();
            TempResultTxtBox = new TextBox();
            TempResetButton = new Button();
            label3 = new Label();
            FTCButton = new RadioButton();
            CTFButton = new RadioButton();
            label2 = new Label();
            TempTxtBox = new TextBox();
            label1 = new Label();
            UnitAmountTxtBox = new TextBox();
            FromUnitCmb = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            ToUnitCmb = new ComboBox();
            ConvertUnitButton = new Button();
            UnitResultTxtBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(ConvertTempButton);
            panel1.Controls.Add(ToCurrencyCombo);
            panel1.Controls.Add(FromCurrencyCombo);
            panel1.Controls.Add(ConvertCurrencyButton);
            panel1.Controls.Add(AmountTxtBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LblCurrencyResult);
            panel1.Controls.Add(TempResultTxtBox);
            panel1.Controls.Add(TempResetButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(FTCButton);
            panel1.Controls.Add(CTFButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TempTxtBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 999);
            panel1.TabIndex = 0;
            // 
            // ConvertTempButton
            // 
            ConvertTempButton.FlatStyle = FlatStyle.Flat;
            ConvertTempButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertTempButton.ForeColor = Color.White;
            ConvertTempButton.Location = new Point(122, 286);
            ConvertTempButton.Margin = new Padding(3, 4, 3, 4);
            ConvertTempButton.Name = "ConvertTempButton";
            ConvertTempButton.Size = new Size(98, 45);
            ConvertTempButton.TabIndex = 19;
            ConvertTempButton.Text = "Convert";
            ConvertTempButton.UseVisualStyleBackColor = true;
            ConvertTempButton.Click += ConvertTempButton_Click;
            ConvertTempButton.MouseLeave += ConvertTempButton_MouseLeave;
            ConvertTempButton.MouseHover += ConvertTempButton_MouseHover;
            // 
            // ToCurrencyCombo
            // 
            ToCurrencyCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToCurrencyCombo.FormattingEnabled = true;
            ToCurrencyCombo.Items.AddRange(new object[] { "AUD", "CAD", "EUR", "GBP", "JPY", "NZD", "PHP", "USD" });
            ToCurrencyCombo.Location = new Point(138, 646);
            ToCurrencyCombo.Margin = new Padding(3, 4, 3, 4);
            ToCurrencyCombo.Name = "ToCurrencyCombo";
            ToCurrencyCombo.Size = new Size(138, 36);
            ToCurrencyCombo.TabIndex = 18;
            // 
            // FromCurrencyCombo
            // 
            FromCurrencyCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FromCurrencyCombo.FormattingEnabled = true;
            FromCurrencyCombo.Items.AddRange(new object[] { "AUD", "CAD", "EUR", "GBP", "JPY", "NZD", "PHP", "USD" });
            FromCurrencyCombo.Location = new Point(138, 559);
            FromCurrencyCombo.Margin = new Padding(3, 4, 3, 4);
            FromCurrencyCombo.Name = "FromCurrencyCombo";
            FromCurrencyCombo.Size = new Size(138, 36);
            FromCurrencyCombo.TabIndex = 17;
            // 
            // ConvertCurrencyButton
            // 
            ConvertCurrencyButton.FlatStyle = FlatStyle.Flat;
            ConvertCurrencyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertCurrencyButton.ForeColor = Color.White;
            ConvertCurrencyButton.Location = new Point(149, 700);
            ConvertCurrencyButton.Margin = new Padding(3, 4, 3, 4);
            ConvertCurrencyButton.Name = "ConvertCurrencyButton";
            ConvertCurrencyButton.Size = new Size(123, 45);
            ConvertCurrencyButton.TabIndex = 16;
            ConvertCurrencyButton.Text = "Convert";
            ConvertCurrencyButton.UseVisualStyleBackColor = true;
            ConvertCurrencyButton.Click += ConvertCurrencyButton_Click;
            ConvertCurrencyButton.MouseLeave += ConvertCurrencyButton_MouseLeave;
            ConvertCurrencyButton.MouseHover += ConvertCurrencyButton_MouseHover;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTxtBox.Location = new Point(144, 471);
            AmountTxtBox.Margin = new Padding(3, 4, 3, 4);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(126, 34);
            AmountTxtBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(153, 614);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 12;
            label7.Text = "To Currency";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(138, 527);
            label6.Name = "label6";
            label6.Size = new Size(145, 28);
            label6.TabIndex = 11;
            label6.Text = "From Currency";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(144, 439);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 10;
            label5.Text = "Enter Amount";
            // 
            // LblCurrencyResult
            // 
            LblCurrencyResult.AutoSize = true;
            LblCurrencyResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCurrencyResult.ForeColor = Color.White;
            LblCurrencyResult.Location = new Point(112, 375);
            LblCurrencyResult.Name = "LblCurrencyResult";
            LblCurrencyResult.Size = new Size(203, 28);
            LblCurrencyResult.TabIndex = 9;
            LblCurrencyResult.Text = "Converted Amount: ";
            // 
            // TempResultTxtBox
            // 
            TempResultTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TempResultTxtBox.Location = new Point(163, 239);
            TempResultTxtBox.Margin = new Padding(3, 4, 3, 4);
            TempResultTxtBox.Name = "TempResultTxtBox";
            TempResultTxtBox.Size = new Size(85, 34);
            TempResultTxtBox.TabIndex = 8;
            // 
            // TempResetButton
            // 
            TempResetButton.FlatStyle = FlatStyle.Flat;
            TempResetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TempResetButton.ForeColor = Color.White;
            TempResetButton.Location = new Point(227, 286);
            TempResetButton.Margin = new Padding(3, 4, 3, 4);
            TempResetButton.Name = "TempResetButton";
            TempResetButton.Size = new Size(86, 45);
            TempResetButton.TabIndex = 7;
            TempResetButton.Text = "Reset";
            TempResetButton.UseVisualStyleBackColor = true;
            TempResetButton.Click += TempResetButton_Click;
            TempResetButton.MouseLeave += TempResetButton_MouseLeave;
            TempResetButton.MouseHover += TempResetButton_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 207);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // FTCButton
            // 
            FTCButton.AutoSize = true;
            FTCButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            FTCButton.ForeColor = Color.White;
            FTCButton.Location = new Point(144, 163);
            FTCButton.Margin = new Padding(3, 4, 3, 4);
            FTCButton.Name = "FTCButton";
            FTCButton.Size = new Size(177, 27);
            FTCButton.TabIndex = 5;
            FTCButton.TabStop = true;
            FTCButton.Text = "Farenheit To Celcius";
            FTCButton.UseVisualStyleBackColor = true;
            // 
            // CTFButton
            // 
            CTFButton.AutoSize = true;
            CTFButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            CTFButton.ForeColor = Color.White;
            CTFButton.Location = new Point(144, 130);
            CTFButton.Margin = new Padding(3, 4, 3, 4);
            CTFButton.Name = "CTFButton";
            CTFButton.Size = new Size(177, 27);
            CTFButton.TabIndex = 4;
            CTFButton.TabStop = true;
            CTFButton.Text = "Celcius To Farenheit";
            CTFButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(153, 98);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 3;
            label2.Text = "Select Unit";
            // 
            // TempTxtBox
            // 
            TempTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TempTxtBox.Location = new Point(163, 49);
            TempTxtBox.Margin = new Padding(3, 4, 3, 4);
            TempTxtBox.Name = "TempTxtBox";
            TempTxtBox.Size = new Size(95, 34);
            TempTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 17);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter Temperature";
            // 
            // UnitAmountTxtBox
            // 
            UnitAmountTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitAmountTxtBox.Location = new Point(651, 44);
            UnitAmountTxtBox.Margin = new Padding(3, 4, 3, 4);
            UnitAmountTxtBox.Name = "UnitAmountTxtBox";
            UnitAmountTxtBox.Size = new Size(126, 34);
            UnitAmountTxtBox.TabIndex = 2;
            // 
            // FromUnitCmb
            // 
            FromUnitCmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FromUnitCmb.FormattingEnabled = true;
            FromUnitCmb.Items.AddRange(new object[] { "Kilometer", "Meter", "Centimeter", "Feet", "Kilograms", "Grams", "Miligrams" });
            FromUnitCmb.Location = new Point(651, 125);
            FromUnitCmb.Margin = new Padding(3, 4, 3, 4);
            FromUnitCmb.Name = "FromUnitCmb";
            FromUnitCmb.Size = new Size(126, 36);
            FromUnitCmb.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(638, 11);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 4;
            label4.Text = "Enter Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(638, 93);
            label8.Name = "label8";
            label8.Size = new Size(59, 28);
            label8.TabIndex = 5;
            label8.Text = "From";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(651, 174);
            label9.Name = "label9";
            label9.Size = new Size(33, 28);
            label9.TabIndex = 6;
            label9.Text = "To";
            // 
            // ToUnitCmb
            // 
            ToUnitCmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToUnitCmb.FormattingEnabled = true;
            ToUnitCmb.Items.AddRange(new object[] { "Kilometer", "Meter", "Centimeter", "Feet", "Kilograms", "Grams", "Miligrams" });
            ToUnitCmb.Location = new Point(651, 206);
            ToUnitCmb.Margin = new Padding(3, 4, 3, 4);
            ToUnitCmb.Name = "ToUnitCmb";
            ToUnitCmb.Size = new Size(126, 36);
            ToUnitCmb.TabIndex = 7;
            // 
            // ConvertUnitButton
            // 
            ConvertUnitButton.FlatStyle = FlatStyle.Flat;
            ConvertUnitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertUnitButton.ForeColor = Color.White;
            ConvertUnitButton.Location = new Point(599, 261);
            ConvertUnitButton.Margin = new Padding(3, 4, 3, 4);
            ConvertUnitButton.Name = "ConvertUnitButton";
            ConvertUnitButton.Size = new Size(126, 45);
            ConvertUnitButton.TabIndex = 20;
            ConvertUnitButton.Text = "Convert";
            ConvertUnitButton.UseVisualStyleBackColor = true;
            ConvertUnitButton.Click += ConvertUnitButton_Click;
            ConvertUnitButton.MouseLeave += ConvertUnitButton_MouseLeave;
            ConvertUnitButton.MouseHover += ConvertUnitButton_MouseHover;
            // 
            // UnitResultTxtBox
            // 
            UnitResultTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitResultTxtBox.Location = new Point(732, 266);
            UnitResultTxtBox.Margin = new Padding(3, 4, 3, 4);
            UnitResultTxtBox.Name = "UnitResultTxtBox";
            UnitResultTxtBox.Size = new Size(114, 34);
            UnitResultTxtBox.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(629, 358);
            label10.Name = "label10";
            label10.Size = new Size(248, 28);
            label10.TabIndex = 22;
            label10.Text = "Conversion Units Available:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(651, 398);
            label11.Name = "label11";
            label11.Size = new Size(185, 280);
            label11.TabIndex = 25;
            label11.Text = "Kilometer to Meter\r\nMeter to Kilometer\r\nCentimeter to Meter\r\nMeter to Centimeter\r\nCentimeter to Feet\r\nFeet to Centimeter\r\nKilograms to Grams\r\nGrams to Kilograms\r\nMiligrams to Grams\r\nGrams to Miligrams";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(114, 137, 218);
            label12.Location = new Point(610, 709);
            label12.Name = "label12";
            label12.Size = new Size(256, 56);
            label12.TabIndex = 26;
            label12.Text = "*No Output will be shown \r\nif unit is not listed";
            label12.Click += label12_Click;
            // 
            // ConverterForm4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(942, 803);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(UnitResultTxtBox);
            Controls.Add(ConvertUnitButton);
            Controls.Add(ToUnitCmb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(FromUnitCmb);
            Controls.Add(UnitAmountTxtBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ConverterForm4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Converter";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TempTxtBox;
        private TextBox TempResultTxtBox;
        private Button TempResetButton;
        private Label label3;
        private RadioButton FTCButton;
        private RadioButton CTFButton;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label LblCurrencyResult;
        private Button ConvertCurrencyButton;
        private TextBox AmountTxtBox;
        private ComboBox ToCurrencyCombo;
        private ComboBox FromCurrencyCombo;
        private Button ConvertTempButton;
        private TextBox UnitAmountTxtBox;
        private ComboBox FromUnitCmb;
        private Label label4;
        private Label label8;
        private Label label9;
        private ComboBox ToUnitCmb;
        private Button ConvertUnitButton;
        private TextBox UnitResultTxtBox;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}