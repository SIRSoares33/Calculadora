namespace Calculadora;

partial class MainView
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
        pnlInput = new Panel();
        txtResult = new TextBox();
        pnlButtons = new Panel();
        btnClear = new Button();
        btnExit = new Button();
        btnResult = new Button();
        btnDivision = new Button();
        btnMultiplicacao = new Button();
        btnLess = new Button();
        btnPlus = new Button();
        button9 = new Button();
        button8 = new Button();
        button4 = new Button();
        button7 = new Button();
        button6 = new Button();
        button5 = new Button();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        button0 = new Button();
        pnlInput.SuspendLayout();
        pnlButtons.SuspendLayout();
        SuspendLayout();
        // 
        // pnlInput
        // 
        pnlInput.BackColor = SystemColors.ActiveCaption;
        pnlInput.Controls.Add(txtResult);
        pnlInput.Location = new Point(0, 23);
        pnlInput.Name = "pnlInput";
        pnlInput.Size = new Size(324, 72);
        pnlInput.TabIndex = 0;
        // 
        // txtResult
        // 
        txtResult.BackColor = SystemColors.ActiveCaption;
        txtResult.BorderStyle = BorderStyle.None;
        txtResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        txtResult.Location = new Point(0, 19);
        txtResult.Name = "txtResult";
        txtResult.ReadOnly = true;
        txtResult.Size = new Size(302, 43);
        txtResult.TabIndex = 0;
        // 
        // pnlButtons
        // 
        pnlButtons.Controls.Add(btnClear);
        pnlButtons.Controls.Add(btnExit);
        pnlButtons.Controls.Add(btnResult);
        pnlButtons.Controls.Add(btnDivision);
        pnlButtons.Controls.Add(btnMultiplicacao);
        pnlButtons.Controls.Add(btnLess);
        pnlButtons.Controls.Add(btnPlus);
        pnlButtons.Controls.Add(button9);
        pnlButtons.Controls.Add(button8);
        pnlButtons.Controls.Add(button4);
        pnlButtons.Controls.Add(button7);
        pnlButtons.Controls.Add(button6);
        pnlButtons.Controls.Add(button5);
        pnlButtons.Controls.Add(button3);
        pnlButtons.Controls.Add(button2);
        pnlButtons.Controls.Add(button1);
        pnlButtons.Location = new Point(0, 109);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Size = new Size(324, 253);
        pnlButtons.TabIndex = 1;
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnClear.Location = new Point(225, 184);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(77, 69);
        btnClear.TabIndex = 16;
        btnClear.Text = "C";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += ClickedButtonClear;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnExit.Location = new Point(149, 184);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(77, 69);
        btnExit.TabIndex = 15;
        btnExit.Text = "exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += exit;
        // 
        // btnResult
        // 
        btnResult.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnResult.Location = new Point(76, 184);
        btnResult.Name = "btnResult";
        btnResult.Size = new Size(77, 69);
        btnResult.TabIndex = 14;
        btnResult.Text = "=";
        btnResult.UseVisualStyleBackColor = true;
        btnResult.Click += ClickedButtonResult;
        // 
        // btnDivision
        // 
        btnDivision.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnDivision.Location = new Point(0, 184);
        btnDivision.Name = "btnDivision";
        btnDivision.Size = new Size(77, 69);
        btnDivision.TabIndex = 13;
        btnDivision.Text = "/";
        btnDivision.UseVisualStyleBackColor = true;
        btnDivision.Click += clickedButtonsOperation;
        // 
        // btnMultiplicacao
        // 
        btnMultiplicacao.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnMultiplicacao.Location = new Point(225, 120);
        btnMultiplicacao.Name = "btnMultiplicacao";
        btnMultiplicacao.Size = new Size(77, 69);
        btnMultiplicacao.TabIndex = 12;
        btnMultiplicacao.Text = "*";
        btnMultiplicacao.UseVisualStyleBackColor = true;
        btnMultiplicacao.Click += clickedButtonsOperation;
        // 
        // btnLess
        // 
        btnLess.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnLess.Location = new Point(149, 120);
        btnLess.Name = "btnLess";
        btnLess.Size = new Size(77, 69);
        btnLess.TabIndex = 11;
        btnLess.Text = "-";
        btnLess.UseVisualStyleBackColor = true;
        btnLess.Click += clickedButtonsOperation;
        // 
        // btnPlus
        // 
        btnPlus.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnPlus.Location = new Point(76, 120);
        btnPlus.Name = "btnPlus";
        btnPlus.Size = new Size(77, 69);
        btnPlus.TabIndex = 10;
        btnPlus.Text = "+";
        btnPlus.UseVisualStyleBackColor = true;
        btnPlus.Click += clickedButtonsOperation;
        // 
        // button9
        // 
        button9.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button9.Location = new Point(0, 120);
        button9.Name = "button9";
        button9.Size = new Size(77, 69);
        button9.TabIndex = 9;
        button9.Text = "9";
        button9.UseVisualStyleBackColor = true;
        button9.Click += clickedButtonsNumber;
        // 
        // button8
        // 
        button8.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button8.Location = new Point(225, 58);
        button8.Name = "button8";
        button8.Size = new Size(77, 69);
        button8.TabIndex = 8;
        button8.Text = "8";
        button8.UseVisualStyleBackColor = true;
        button8.Click += clickedButtonsNumber;
        // 
        // button4
        // 
        button4.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button4.Location = new Point(225, -8);
        button4.Name = "button4";
        button4.Size = new Size(77, 69);
        button4.TabIndex = 7;
        button4.Text = "4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += clickedButtonsNumber;
        // 
        // button7
        // 
        button7.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button7.Location = new Point(149, 58);
        button7.Name = "button7";
        button7.Size = new Size(77, 69);
        button7.TabIndex = 6;
        button7.Text = "7";
        button7.UseVisualStyleBackColor = true;
        button7.Click += clickedButtonsNumber;
        // 
        // button6
        // 
        button6.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button6.Location = new Point(76, 58);
        button6.Name = "button6";
        button6.Size = new Size(77, 69);
        button6.TabIndex = 5;
        button6.Text = "6";
        button6.UseVisualStyleBackColor = true;
        button6.Click += clickedButtonsNumber;
        // 
        // button5
        // 
        button5.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button5.Location = new Point(0, 58);
        button5.Name = "button5";
        button5.Size = new Size(77, 69);
        button5.TabIndex = 4;
        button5.Text = "5";
        button5.UseVisualStyleBackColor = true;
        button5.Click += clickedButtonsNumber;
        // 
        // button3
        // 
        button3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button3.Location = new Point(149, -8);
        button3.Name = "button3";
        button3.Size = new Size(77, 69);
        button3.TabIndex = 2;
        button3.Tag = "3";
        button3.Text = "3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += clickedButtonsNumber;
        // 
        // button2
        // 
        button2.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(76, -8);
        button2.Name = "button2";
        button2.Size = new Size(75, 69);
        button2.TabIndex = 1;
        button2.Text = "2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += clickedButtonsNumber;
        // 
        // button1
        // 
        button1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(0, -8);
        button1.Name = "button1";
        button1.Size = new Size(77, 69);
        button1.TabIndex = 0;
        button1.Text = "1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += clickedButtonsNumber;
        // 
        // button0
        // 
        button0.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        button0.Location = new Point(0, 354);
        button0.Name = "button0";
        button0.Size = new Size(77, 69);
        button0.TabIndex = 14;
        button0.Text = "0";
        button0.UseVisualStyleBackColor = true;
        button0.Click += clickedButtonsNumber;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonShadow;
        ClientSize = new Size(300, 423);
        Controls.Add(button0);
        Controls.Add(pnlButtons);
        Controls.Add(pnlInput);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainView";
        Text = "Form1";
        pnlInput.ResumeLayout(false);
        pnlInput.PerformLayout();
        pnlButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlInput;
    private Panel pnlButtons;
    private Button button1;
    private Button button3;
    private Button button2;
    private Button btnDivision;
    private Button btnMultiplicacao;
    private Button btnLess;
    private Button btnPlus;
    private Button button9;
    private Button button8;
    private Button button4;
    private Button button7;
    private Button button6;
    private Button button5;
    private TextBox txtResult;
    private Button btnResult;
    private Button btnExit;
    private Button btnClear;
    private Button button0;
}
