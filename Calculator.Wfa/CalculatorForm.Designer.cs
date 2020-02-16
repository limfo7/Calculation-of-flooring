namespace Calculator.Wfa
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.CoverageTypeLbl = new System.Windows.Forms.Label();
            this.CoverageLength = new System.Windows.Forms.Label();
            this.CoverageWidthLbl = new System.Windows.Forms.Label();
            this.FloorLengthLbl = new System.Windows.Forms.Label();
            this.FloorWidthLbl = new System.Windows.Forms.Label();
            this.MinExpenseLbl = new System.Windows.Forms.Label();
            this.FloorWidthTextBox = new System.Windows.Forms.TextBox();
            this.CovLengthTxtBox = new System.Windows.Forms.TextBox();
            this.CovWidthTextBox = new System.Windows.Forms.TextBox();
            this.FloorLengthTextBox = new System.Windows.Forms.TextBox();
            this.MinExpenseResultLbl = new System.Windows.Forms.Label();
            this.CovTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoverageTypeLbl
            // 
            this.CoverageTypeLbl.AutoSize = true;
            this.CoverageTypeLbl.Location = new System.Drawing.Point(50, 90);
            this.CoverageTypeLbl.Name = "CoverageTypeLbl";
            this.CoverageTypeLbl.Size = new System.Drawing.Size(81, 13);
            this.CoverageTypeLbl.TabIndex = 0;
            this.CoverageTypeLbl.Text = "Тип покрытия:";
            // 
            // CoverageLength
            // 
            this.CoverageLength.AutoSize = true;
            this.CoverageLength.Location = new System.Drawing.Point(50, 127);
            this.CoverageLength.Name = "CoverageLength";
            this.CoverageLength.Size = new System.Drawing.Size(112, 13);
            this.CoverageLength.TabIndex = 1;
            this.CoverageLength.Text = "Длина покрытия (м.)";
            // 
            // CoverageWidthLbl
            // 
            this.CoverageWidthLbl.AutoSize = true;
            this.CoverageWidthLbl.Location = new System.Drawing.Point(50, 172);
            this.CoverageWidthLbl.Name = "CoverageWidthLbl";
            this.CoverageWidthLbl.Size = new System.Drawing.Size(115, 13);
            this.CoverageWidthLbl.TabIndex = 2;
            this.CoverageWidthLbl.Text = "Ширина покрытия(м.)";
            // 
            // FloorLengthLbl
            // 
            this.FloorLengthLbl.AutoSize = true;
            this.FloorLengthLbl.Location = new System.Drawing.Point(50, 216);
            this.FloorLengthLbl.Name = "FloorLengthLbl";
            this.FloorLengthLbl.Size = new System.Drawing.Size(84, 13);
            this.FloorLengthLbl.TabIndex = 3;
            this.FloorLengthLbl.Text = "Длина пола(м.)";
            // 
            // FloorWidthLbl
            // 
            this.FloorWidthLbl.AutoSize = true;
            this.FloorWidthLbl.Location = new System.Drawing.Point(50, 259);
            this.FloorWidthLbl.Name = "FloorWidthLbl";
            this.FloorWidthLbl.Size = new System.Drawing.Size(90, 13);
            this.FloorWidthLbl.TabIndex = 4;
            this.FloorWidthLbl.Text = "Ширина пола(м.)";
            // 
            // MinExpenseLbl
            // 
            this.MinExpenseLbl.AutoSize = true;
            this.MinExpenseLbl.Location = new System.Drawing.Point(50, 314);
            this.MinExpenseLbl.Name = "MinExpenseLbl";
            this.MinExpenseLbl.Size = new System.Drawing.Size(121, 13);
            this.MinExpenseLbl.TabIndex = 5;
            this.MinExpenseLbl.Text = "Минимальный расход:";
            // 
            // FloorWidthTextBox
            // 
            this.FloorWidthTextBox.Location = new System.Drawing.Point(180, 259);
            this.FloorWidthTextBox.Name = "FloorWidthTextBox";
            this.FloorWidthTextBox.Size = new System.Drawing.Size(121, 20);
            this.FloorWidthTextBox.TabIndex = 6;
            // 
            // CovLengthTxtBox
            // 
            this.CovLengthTxtBox.Location = new System.Drawing.Point(180, 124);
            this.CovLengthTxtBox.Name = "CovLengthTxtBox";
            this.CovLengthTxtBox.Size = new System.Drawing.Size(121, 20);
            this.CovLengthTxtBox.TabIndex = 7;
            // 
            // CovWidthTextBox
            // 
            this.CovWidthTextBox.Location = new System.Drawing.Point(180, 169);
            this.CovWidthTextBox.Name = "CovWidthTextBox";
            this.CovWidthTextBox.Size = new System.Drawing.Size(121, 20);
            this.CovWidthTextBox.TabIndex = 8;
            // 
            // FloorLengthTextBox
            // 
            this.FloorLengthTextBox.Location = new System.Drawing.Point(180, 213);
            this.FloorLengthTextBox.Name = "FloorLengthTextBox";
            this.FloorLengthTextBox.Size = new System.Drawing.Size(121, 20);
            this.FloorLengthTextBox.TabIndex = 9;
            // 
            // MinExpenseResultLbl
            // 
            this.MinExpenseResultLbl.AutoSize = true;
            this.MinExpenseResultLbl.Location = new System.Drawing.Point(192, 314);
            this.MinExpenseResultLbl.Name = "MinExpenseResultLbl";
            this.MinExpenseResultLbl.Size = new System.Drawing.Size(0, 13);
            this.MinExpenseResultLbl.TabIndex = 10;
            // 
            // CovTypeComboBox
            // 
            this.CovTypeComboBox.FormattingEnabled = true;
            this.CovTypeComboBox.Items.AddRange(new object[] {
            "Керамическая плитка",
            "Линулеум",
            "Паркет",
            "Паркетная доска",
            "Ковролин",
            "Ламинат"});
            this.CovTypeComboBox.Location = new System.Drawing.Point(180, 86);
            this.CovTypeComboBox.Name = "CovTypeComboBox";
            this.CovTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CovTypeComboBox.TabIndex = 11;
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(156, 370);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(75, 23);
            this.ResultBtn.TabIndex = 12;
            this.ResultBtn.Text = "Посчитать";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 435);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.CovTypeComboBox);
            this.Controls.Add(this.MinExpenseResultLbl);
            this.Controls.Add(this.FloorLengthTextBox);
            this.Controls.Add(this.CovWidthTextBox);
            this.Controls.Add(this.CovLengthTxtBox);
            this.Controls.Add(this.FloorWidthTextBox);
            this.Controls.Add(this.MinExpenseLbl);
            this.Controls.Add(this.FloorWidthLbl);
            this.Controls.Add(this.FloorLengthLbl);
            this.Controls.Add(this.CoverageWidthLbl);
            this.Controls.Add(this.CoverageLength);
            this.Controls.Add(this.CoverageTypeLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoverageTypeLbl;
        private System.Windows.Forms.Label CoverageLength;
        private System.Windows.Forms.Label CoverageWidthLbl;
        private System.Windows.Forms.Label FloorLengthLbl;
        private System.Windows.Forms.Label FloorWidthLbl;
        private System.Windows.Forms.Label MinExpenseLbl;
        private System.Windows.Forms.TextBox FloorWidthTextBox;
        private System.Windows.Forms.TextBox CovLengthTxtBox;
        private System.Windows.Forms.TextBox CovWidthTextBox;
        private System.Windows.Forms.TextBox FloorLengthTextBox;
        private System.Windows.Forms.Label MinExpenseResultLbl;
        private System.Windows.Forms.ComboBox CovTypeComboBox;
        private System.Windows.Forms.Button ResultBtn;
    }
}

