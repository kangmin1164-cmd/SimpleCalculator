namespace SimpleCalculator
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
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            txtResult = new TextBox();
            txtExpression = new TextBox();
            btnEqual = new Button();
            btnPlus = new Button();
            lblTitle = new Label();
            btnMulti = new Button();
            btnDiv = new Button();
            btnMinus = new Button();
            btnCE = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnDot = new Button();
            btnSign = new Button();
            btnParenthesis = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(56, 249);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 75);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(174, 249);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 75);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(292, 249);
            btn9.Name = "btn9";
            btn9.Size = new Size(112, 75);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(56, 330);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 75);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(174, 330);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 75);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(292, 330);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 75);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(56, 411);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 75);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(174, 411);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 75);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(292, 411);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 75);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(174, 492);
            btn0.Name = "btn0";
            btn0.Size = new Size(112, 75);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.HighlightText;
            txtResult.Font = new Font("한컴 고딕", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtResult.Location = new Point(56, 121);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(348, 44);
            txtResult.TabIndex = 10;
            // 
            // txtExpression
            // 
            txtExpression.BackColor = SystemColors.HighlightText;
            txtExpression.Font = new Font("한컴 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtExpression.Location = new Point(56, 65);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(466, 49);
            txtExpression.TabIndex = 11;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 224, 192);
            btnEqual.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEqual.Location = new Point(410, 492);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(112, 75);
            btnEqual.TabIndex = 12;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 224, 192);
            btnPlus.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPlus.Location = new Point(410, 411);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(112, 75);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnOperator_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ActiveCaption;
            lblTitle.Location = new Point(94, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(408, 53);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Simple Calculator\r\n";
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.FromArgb(255, 224, 192);
            btnMulti.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMulti.Location = new Point(410, 249);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(112, 75);
            btnMulti.TabIndex = 15;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnOperator_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 224, 192);
            btnDiv.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDiv.Location = new Point(410, 168);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(112, 75);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnOperator_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 224, 192);
            btnMinus.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMinus.Location = new Point(410, 330);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(112, 75);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnOperator_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(255, 128, 128);
            btnCE.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCE.Location = new Point(56, 168);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(112, 75);
            btnCE.TabIndex = 18;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.Location = new Point(174, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 75);
            btnClear.TabIndex = 19;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelete.Location = new Point(292, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 75);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(292, 492);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(112, 75);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(56, 492);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(112, 75);
            btnSign.TabIndex = 22;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btnParenthesis
            // 
            btnParenthesis.BackColor = Color.FromArgb(255, 224, 192);
            btnParenthesis.Font = new Font("한컴 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnParenthesis.Location = new Point(410, 120);
            btnParenthesis.Name = "btnParenthesis";
            btnParenthesis.Size = new Size(112, 45);
            btnParenthesis.TabIndex = 23;
            btnParenthesis.Text = "(";
            btnParenthesis.UseVisualStyleBackColor = false;
            btnParenthesis.Click += btnParenthesis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(552, 585);
            Controls.Add(btnParenthesis);
            Controls.Add(btnSign);
            Controls.Add(btnDot);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnCE);
            Controls.Add(btnMinus);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(lblTitle);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(txtExpression);
            Controls.Add(txtResult);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private TextBox txtResult;
        private TextBox txtExpression;
        private Button btnEqual;
        private Button btnPlus;
        private Label lblTitle;
        private Button btnMulti;
        private Button btnDiv;
        private Button btnMinus;
        private Button btnCE;
        private Button btnClear;
        private Button btnDelete;
        private Button btnDot;
        private Button btnSign;
        private Button btnParenthesis;
    }
}
