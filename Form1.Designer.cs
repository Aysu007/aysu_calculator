namespace Complex_Calculator;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        panelDisplay = new Panel();
        lblExpression = new Label();
        richTextBox1 = new RichTextBox();
        panelHistory = new Panel();
        lblHistoryHeader = new Label();
        listBox1 = new ListBox();
        btnClearHistory = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnAdd = new Button();
        btnBack = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btnSub = new Button();
        btnSqrt = new Button();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btnMul = new Button();
        btnSqr = new Button();
        btnDot = new Button();
        btn0 = new Button();
        btnC = new Button();
        btnDiv = new Button();
        btnEqual = new Button();
        panelDisplay.SuspendLayout();
        panelHistory.SuspendLayout();
        SuspendLayout();
        // 
        // panelDisplay
        // 
        panelDisplay.BackColor = Color.FromArgb(20, 23, 33);
        panelDisplay.Controls.Add(lblExpression);
        panelDisplay.Controls.Add(richTextBox1);
        panelDisplay.Location = new Point(24, 20);
        panelDisplay.Name = "panelDisplay";
        panelDisplay.Padding = new Padding(12, 8, 12, 8);
        panelDisplay.Size = new Size(504, 105);
        panelDisplay.TabIndex = 0;
        // 
        // lblExpression
        // 
        lblExpression.Dock = DockStyle.Top;
        lblExpression.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblExpression.ForeColor = Color.FromArgb(148, 163, 184);
        lblExpression.Location = new Point(12, 8);
        lblExpression.Name = "lblExpression";
        lblExpression.Size = new Size(480, 24);
        lblExpression.TabIndex = 0;
        lblExpression.TextAlign = ContentAlignment.MiddleRight;
        // 
        // richTextBox1
        // 
        richTextBox1.BackColor = Color.FromArgb(20, 23, 33);
        richTextBox1.BorderStyle = BorderStyle.None;
        richTextBox1.Dock = DockStyle.Bottom;
        richTextBox1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        richTextBox1.ForeColor = Color.FromArgb(241, 245, 249);
        richTextBox1.Location = new Point(12, 38);
        richTextBox1.Multiline = false;
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.RightToLeft = RightToLeft.No;
        richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
        richTextBox1.Size = new Size(480, 59);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "0";
        // 
        // panelHistory
        // 
        panelHistory.BackColor = Color.FromArgb(20, 23, 33);
        panelHistory.Controls.Add(lblHistoryHeader);
        panelHistory.Controls.Add(listBox1);
        panelHistory.Controls.Add(btnClearHistory);
        panelHistory.Location = new Point(544, 20);
        panelHistory.Name = "panelHistory";
        panelHistory.Padding = new Padding(10);
        panelHistory.Size = new Size(224, 465);
        panelHistory.TabIndex = 1;
        // 
        // lblHistoryHeader
        // 
        lblHistoryHeader.Dock = DockStyle.Top;
        lblHistoryHeader.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblHistoryHeader.ForeColor = Color.FromArgb(203, 213, 225);
        lblHistoryHeader.Location = new Point(10, 10);
        lblHistoryHeader.Name = "lblHistoryHeader";
        lblHistoryHeader.Size = new Size(204, 26);
        lblHistoryHeader.TabIndex = 0;
        lblHistoryHeader.Text = "Tarixçə (History)";
        lblHistoryHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // listBox1
        // 
        listBox1.BackColor = Color.FromArgb(24, 28, 40);
        listBox1.BorderStyle = BorderStyle.None;
        listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        listBox1.ForeColor = Color.FromArgb(226, 232, 240);
        listBox1.ItemHeight = 17;
        listBox1.Location = new Point(10, 42);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(204, 360);
        listBox1.TabIndex = 1;
        listBox1.DoubleClick += ListBox1_DoubleClick;
        // 
        // btnClearHistory
        // 
        btnClearHistory.BackColor = Color.FromArgb(32, 37, 52);
        btnClearHistory.Cursor = Cursors.Hand;
        btnClearHistory.FlatAppearance.BorderSize = 0;
        btnClearHistory.FlatStyle = FlatStyle.Flat;
        btnClearHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnClearHistory.ForeColor = Color.FromArgb(148, 163, 184);
        btnClearHistory.Location = new Point(10, 416);
        btnClearHistory.Name = "btnClearHistory";
        btnClearHistory.Size = new Size(204, 36);
        btnClearHistory.TabIndex = 2;
        btnClearHistory.Text = "Tarixçəni Təmizlə";
        btnClearHistory.UseVisualStyleBackColor = false;
        btnClearHistory.Click += BtnClearHistory_Click;
        // 
        // btn1
        // 
        btn1.BackColor = Color.FromArgb(40, 45, 62);
        btn1.Cursor = Cursors.Hand;
        btn1.FlatAppearance.BorderSize = 0;
        btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn1.FlatStyle = FlatStyle.Flat;
        btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn1.ForeColor = Color.FromArgb(241, 245, 249);
        btn1.Location = new Point(24, 140);
        btn1.Name = "btn1";
        btn1.Size = new Size(92, 74);
        btn1.TabIndex = 2;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = false;
        btn1.Click += ButtonNumber_Click;
        // 
        // btn2
        // 
        btn2.BackColor = Color.FromArgb(40, 45, 62);
        btn2.Cursor = Cursors.Hand;
        btn2.FlatAppearance.BorderSize = 0;
        btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn2.FlatStyle = FlatStyle.Flat;
        btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn2.ForeColor = Color.FromArgb(241, 245, 249);
        btn2.Location = new Point(127, 140);
        btn2.Name = "btn2";
        btn2.Size = new Size(92, 74);
        btn2.TabIndex = 3;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = false;
        btn2.Click += ButtonNumber_Click;
        // 
        // btn3
        // 
        btn3.BackColor = Color.FromArgb(40, 45, 62);
        btn3.Cursor = Cursors.Hand;
        btn3.FlatAppearance.BorderSize = 0;
        btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn3.FlatStyle = FlatStyle.Flat;
        btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn3.ForeColor = Color.FromArgb(241, 245, 249);
        btn3.Location = new Point(230, 140);
        btn3.Name = "btn3";
        btn3.Size = new Size(92, 74);
        btn3.TabIndex = 4;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = false;
        btn3.Click += ButtonNumber_Click;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(26, 86, 70);
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 112, 92);
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(333, 140);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(92, 74);
        btnAdd.TabIndex = 5;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += ButtonOperator_Click;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.FromArgb(36, 62, 124);
        btnBack.Cursor = Cursors.Hand;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 80, 158);
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
        btnBack.ForeColor = Color.White;
        btnBack.Location = new Point(436, 140);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(92, 74);
        btnBack.TabIndex = 6;
        btnBack.Text = "<--";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += BtnBack_Click;
        // 
        // btn4
        // 
        btn4.BackColor = Color.FromArgb(40, 45, 62);
        btn4.Cursor = Cursors.Hand;
        btn4.FlatAppearance.BorderSize = 0;
        btn4.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn4.FlatStyle = FlatStyle.Flat;
        btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn4.ForeColor = Color.FromArgb(241, 245, 249);
        btn4.Location = new Point(24, 226);
        btn4.Name = "btn4";
        btn4.Size = new Size(92, 74);
        btn4.TabIndex = 7;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = false;
        btn4.Click += ButtonNumber_Click;
        // 
        // btn5
        // 
        btn5.BackColor = Color.FromArgb(40, 45, 62);
        btn5.Cursor = Cursors.Hand;
        btn5.FlatAppearance.BorderSize = 0;
        btn5.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn5.FlatStyle = FlatStyle.Flat;
        btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn5.ForeColor = Color.FromArgb(241, 245, 249);
        btn5.Location = new Point(127, 226);
        btn5.Name = "btn5";
        btn5.Size = new Size(92, 74);
        btn5.TabIndex = 8;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = false;
        btn5.Click += ButtonNumber_Click;
        // 
        // btn6
        // 
        btn6.BackColor = Color.FromArgb(40, 45, 62);
        btn6.Cursor = Cursors.Hand;
        btn6.FlatAppearance.BorderSize = 0;
        btn6.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn6.FlatStyle = FlatStyle.Flat;
        btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn6.ForeColor = Color.FromArgb(241, 245, 249);
        btn6.Location = new Point(230, 226);
        btn6.Name = "btn6";
        btn6.Size = new Size(92, 74);
        btn6.TabIndex = 9;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = false;
        btn6.Click += ButtonNumber_Click;
        // 
        // btnSub
        // 
        btnSub.BackColor = Color.FromArgb(26, 86, 70);
        btnSub.Cursor = Cursors.Hand;
        btnSub.FlatAppearance.BorderSize = 0;
        btnSub.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 112, 92);
        btnSub.FlatStyle = FlatStyle.Flat;
        btnSub.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        btnSub.ForeColor = Color.White;
        btnSub.Location = new Point(333, 226);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(92, 74);
        btnSub.TabIndex = 10;
        btnSub.Text = "-";
        btnSub.UseVisualStyleBackColor = false;
        btnSub.Click += ButtonOperator_Click;
        // 
        // btnSqrt
        // 
        btnSqrt.BackColor = Color.FromArgb(36, 62, 124);
        btnSqrt.Cursor = Cursors.Hand;
        btnSqrt.FlatAppearance.BorderSize = 0;
        btnSqrt.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 80, 158);
        btnSqrt.FlatStyle = FlatStyle.Flat;
        btnSqrt.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnSqrt.ForeColor = Color.White;
        btnSqrt.Location = new Point(436, 226);
        btnSqrt.Name = "btnSqrt";
        btnSqrt.Size = new Size(92, 74);
        btnSqrt.TabIndex = 11;
        btnSqrt.Text = "Sqrt";
        btnSqrt.UseVisualStyleBackColor = false;
        btnSqrt.Click += BtnSqrt_Click;
        // 
        // btn7
        // 
        btn7.BackColor = Color.FromArgb(40, 45, 62);
        btn7.Cursor = Cursors.Hand;
        btn7.FlatAppearance.BorderSize = 0;
        btn7.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn7.FlatStyle = FlatStyle.Flat;
        btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn7.ForeColor = Color.FromArgb(241, 245, 249);
        btn7.Location = new Point(24, 312);
        btn7.Name = "btn7";
        btn7.Size = new Size(92, 74);
        btn7.TabIndex = 12;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = false;
        btn7.Click += ButtonNumber_Click;
        // 
        // btn8
        // 
        btn8.BackColor = Color.FromArgb(40, 45, 62);
        btn8.Cursor = Cursors.Hand;
        btn8.FlatAppearance.BorderSize = 0;
        btn8.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn8.FlatStyle = FlatStyle.Flat;
        btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn8.ForeColor = Color.FromArgb(241, 245, 249);
        btn8.Location = new Point(127, 312);
        btn8.Name = "btn8";
        btn8.Size = new Size(92, 74);
        btn8.TabIndex = 13;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = false;
        btn8.Click += ButtonNumber_Click;
        // 
        // btn9
        // 
        btn9.BackColor = Color.FromArgb(40, 45, 62);
        btn9.Cursor = Cursors.Hand;
        btn9.FlatAppearance.BorderSize = 0;
        btn9.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn9.FlatStyle = FlatStyle.Flat;
        btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn9.ForeColor = Color.FromArgb(241, 245, 249);
        btn9.Location = new Point(230, 312);
        btn9.Name = "btn9";
        btn9.Size = new Size(92, 74);
        btn9.TabIndex = 14;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = false;
        btn9.Click += ButtonNumber_Click;
        // 
        // btnMul
        // 
        btnMul.BackColor = Color.FromArgb(26, 86, 70);
        btnMul.Cursor = Cursors.Hand;
        btnMul.FlatAppearance.BorderSize = 0;
        btnMul.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 112, 92);
        btnMul.FlatStyle = FlatStyle.Flat;
        btnMul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        btnMul.ForeColor = Color.White;
        btnMul.Location = new Point(333, 312);
        btnMul.Name = "btnMul";
        btnMul.Size = new Size(92, 74);
        btnMul.TabIndex = 15;
        btnMul.Text = "*";
        btnMul.UseVisualStyleBackColor = false;
        btnMul.Click += ButtonOperator_Click;
        // 
        // btnSqr
        // 
        btnSqr.BackColor = Color.FromArgb(36, 62, 124);
        btnSqr.Cursor = Cursors.Hand;
        btnSqr.FlatAppearance.BorderSize = 0;
        btnSqr.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 80, 158);
        btnSqr.FlatStyle = FlatStyle.Flat;
        btnSqr.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnSqr.ForeColor = Color.White;
        btnSqr.Location = new Point(436, 312);
        btnSqr.Name = "btnSqr";
        btnSqr.Size = new Size(92, 74);
        btnSqr.TabIndex = 16;
        btnSqr.Text = "x^2";
        btnSqr.UseVisualStyleBackColor = false;
        btnSqr.Click += BtnSqr_Click;
        // 
        // btnDot
        // 
        btnDot.BackColor = Color.FromArgb(160, 36, 50);
        btnDot.Cursor = Cursors.Hand;
        btnDot.FlatAppearance.BorderSize = 0;
        btnDot.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 45, 62);
        btnDot.FlatStyle = FlatStyle.Flat;
        btnDot.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        btnDot.ForeColor = Color.White;
        btnDot.Location = new Point(24, 398);
        btnDot.Name = "btnDot";
        btnDot.Size = new Size(92, 74);
        btnDot.TabIndex = 17;
        btnDot.Text = ".";
        btnDot.UseVisualStyleBackColor = false;
        btnDot.Click += BtnDot_Click;
        // 
        // btn0
        // 
        btn0.BackColor = Color.FromArgb(40, 45, 62);
        btn0.Cursor = Cursors.Hand;
        btn0.FlatAppearance.BorderSize = 0;
        btn0.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 80);
        btn0.FlatStyle = FlatStyle.Flat;
        btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btn0.ForeColor = Color.FromArgb(241, 245, 249);
        btn0.Location = new Point(127, 398);
        btn0.Name = "btn0";
        btn0.Size = new Size(92, 74);
        btn0.TabIndex = 18;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = false;
        btn0.Click += ButtonNumber_Click;
        // 
        // btnC
        // 
        btnC.BackColor = Color.FromArgb(160, 36, 50);
        btnC.Cursor = Cursors.Hand;
        btnC.FlatAppearance.BorderSize = 0;
        btnC.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 45, 62);
        btnC.FlatStyle = FlatStyle.Flat;
        btnC.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        btnC.ForeColor = Color.White;
        btnC.Location = new Point(230, 398);
        btnC.Name = "btnC";
        btnC.Size = new Size(92, 74);
        btnC.TabIndex = 19;
        btnC.Text = "C";
        btnC.UseVisualStyleBackColor = false;
        btnC.Click += BtnC_Click;
        // 
        // btnDiv
        // 
        btnDiv.BackColor = Color.FromArgb(26, 86, 70);
        btnDiv.Cursor = Cursors.Hand;
        btnDiv.FlatAppearance.BorderSize = 0;
        btnDiv.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 112, 92);
        btnDiv.FlatStyle = FlatStyle.Flat;
        btnDiv.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        btnDiv.ForeColor = Color.White;
        btnDiv.Location = new Point(333, 398);
        btnDiv.Name = "btnDiv";
        btnDiv.Size = new Size(92, 74);
        btnDiv.TabIndex = 20;
        btnDiv.Text = "/";
        btnDiv.UseVisualStyleBackColor = false;
        btnDiv.Click += ButtonOperator_Click;
        // 
        // btnEqual
        // 
        btnEqual.BackColor = Color.FromArgb(37, 99, 235);
        btnEqual.Cursor = Cursors.Hand;
        btnEqual.FlatAppearance.BorderSize = 0;
        btnEqual.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
        btnEqual.FlatStyle = FlatStyle.Flat;
        btnEqual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        btnEqual.ForeColor = Color.White;
        btnEqual.Location = new Point(436, 398);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new Size(92, 74);
        btnEqual.TabIndex = 21;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = false;
        btnEqual.Click += BtnEqual_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(28, 32, 45);
        ClientSize = new Size(790, 498);
        Controls.Add(btnEqual);
        Controls.Add(btnDiv);
        Controls.Add(btnC);
        Controls.Add(btn0);
        Controls.Add(btnDot);
        Controls.Add(btnSqr);
        Controls.Add(btnMul);
        Controls.Add(btn9);
        Controls.Add(btn8);
        Controls.Add(btn7);
        Controls.Add(btnSqrt);
        Controls.Add(btnSub);
        Controls.Add(btn6);
        Controls.Add(btn5);
        Controls.Add(btn4);
        Controls.Add(btnBack);
        Controls.Add(btnAdd);
        Controls.Add(btn3);
        Controls.Add(btn2);
        Controls.Add(btn1);
        Controls.Add(panelHistory);
        Controls.Add(panelDisplay);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        KeyPreview = true;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculator";
        KeyDown += Form1_KeyDown;
        panelDisplay.ResumeLayout(false);
        panelHistory.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelDisplay;
    private Label lblExpression;
    private RichTextBox richTextBox1;
    private Panel panelHistory;
    private Label lblHistoryHeader;
    private ListBox listBox1;
    private Button btnClearHistory;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnAdd;
    private Button btnBack;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnSub;
    private Button btnSqrt;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnMul;
    private Button btnSqr;
    private Button btnDot;
    private Button btn0;
    private Button btnC;
    private Button btnDiv;
    private Button btnEqual;
}
