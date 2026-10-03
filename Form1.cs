using System.Globalization;

namespace Complex_Calculator;

public partial class Form1 : Form
{
    private double _firstNumber = 0;
    private string _currentOperator = "";
    private bool _isNewEntry = false;

    public Form1()
    {
        InitializeComponent();
    }

    private void ButtonNumber_Click(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            if (_isNewEntry || richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
                _isNewEntry = false;
            }

            if (richTextBox1.Text.Length < 16)
            {
                richTextBox1.Text += btn.Text;
            }
        }
    }

    private void BtnDot_Click(object sender, EventArgs e)
    {
        if (_isNewEntry)
        {
            richTextBox1.Text = "0.";
            _isNewEntry = false;
            return;
        }

        if (!richTextBox1.Text.Contains("."))
        {
            richTextBox1.Text += ".";
        }
    }

    private void ButtonOperator_Click(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            if (!string.IsNullOrEmpty(_currentOperator) && !_isNewEntry)
            {
                CalculateCurrent();
            }

            if (double.TryParse(richTextBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedVal))
            {
                _firstNumber = parsedVal;
            }

            _currentOperator = btn.Text;
            lblExpression.Text = $"{FormatNumber(_firstNumber)} {_currentOperator}";
            _isNewEntry = true;
        }
    }

    private void BtnEqual_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_currentOperator))
            return;

        CalculateCurrent();
        _currentOperator = "";
    }

    private void CalculateCurrent()
    {
        if (!double.TryParse(richTextBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double secondNumber))
            return;

        double result = 0;

        switch (_currentOperator)
        {
            case "+":
                result = _firstNumber + secondNumber;
                break;
            case "-":
                result = _firstNumber - secondNumber;
                break;
            case "*":
                result = _firstNumber * secondNumber;
                break;
            case "/":
                if (Math.Abs(secondNumber) < 1e-15)
                {
                    MessageBox.Show("Sıfıra bölmək mümkün deyil!", "Riyazi Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                result = _firstNumber / secondNumber;
                break;
            default:
                return;
        }

        string entry = $"{FormatNumber(_firstNumber)} {_currentOperator} {FormatNumber(secondNumber)} = {FormatNumber(result)}";
        listBox1.Items.Insert(0, entry);

        lblExpression.Text = $"{FormatNumber(_firstNumber)} {_currentOperator} {FormatNumber(secondNumber)} =";
        richTextBox1.Text = FormatNumber(result);
        _firstNumber = result;
        _isNewEntry = true;
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        if (_isNewEntry)
        {
            richTextBox1.Text = "0";
            lblExpression.Text = "";
            _isNewEntry = false;
            return;
        }

        if (richTextBox1.Text.Length > 1)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            if (richTextBox1.Text == "-") richTextBox1.Text = "0";
        }
        else
        {
            richTextBox1.Text = "0";
        }
    }

    private void BtnC_Click(object sender, EventArgs e)
    {
        richTextBox1.Text = "0";
        lblExpression.Text = "";
        _firstNumber = 0;
        _currentOperator = "";
        _isNewEntry = false;
    }

    private void BtnSqrt_Click(object sender, EventArgs e)
    {
        if (double.TryParse(richTextBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
        {
            if (val < 0)
            {
                MessageBox.Show("Mənfi ədədin kvadrat kökü mövcud deyil!", "Riyazi Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = Math.Sqrt(val);
            string entry = $"√({FormatNumber(val)}) = {FormatNumber(result)}";
            listBox1.Items.Insert(0, entry);

            lblExpression.Text = $"√({FormatNumber(val)}) =";
            richTextBox1.Text = FormatNumber(result);
            _firstNumber = result;
            _isNewEntry = true;
        }
    }

    private void BtnSqr_Click(object sender, EventArgs e)
    {
        if (double.TryParse(richTextBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
        {
            double result = val * val;
            string entry = $"sqr({FormatNumber(val)}) = {FormatNumber(result)}";
            listBox1.Items.Insert(0, entry);

            lblExpression.Text = $"sqr({FormatNumber(val)}) =";
            richTextBox1.Text = FormatNumber(result);
            _firstNumber = result;
            _isNewEntry = true;
        }
    }

    private void ListBox1_DoubleClick(object? sender, EventArgs e)
    {
        if (listBox1.SelectedItem is string item)
        {
            int eqIndex = item.LastIndexOf('=');
            if (eqIndex != -1 && eqIndex + 1 < item.Length)
            {
                string val = item.Substring(eqIndex + 1).Trim();
                richTextBox1.Text = val;
                _isNewEntry = true;
            }
        }
    }

    private void BtnClearHistory_Click(object? sender, EventArgs e)
    {
        listBox1.Items.Clear();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
        {
            string digit = (e.KeyCode - Keys.D0).ToString();
            SimulateNumber(digit);
            e.Handled = true;
        }
        else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
        {
            string digit = (e.KeyCode - Keys.NumPad0).ToString();
            SimulateNumber(digit);
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus && e.Shift))
        {
            btnAdd.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
        {
            btnSub.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Multiply)
        {
            btnMul.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
        {
            btnDiv.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
        {
            btnEqual.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Back)
        {
            btnBack.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Escape)
        {
            btnC.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
        {
            btnDot.PerformClick();
            e.Handled = true;
        }
    }

    private void SimulateNumber(string digit)
    {
        switch (digit)
        {
            case "0": btn0.PerformClick(); break;
            case "1": btn1.PerformClick(); break;
            case "2": btn2.PerformClick(); break;
            case "3": btn3.PerformClick(); break;
            case "4": btn4.PerformClick(); break;
            case "5": btn5.PerformClick(); break;
            case "6": btn6.PerformClick(); break;
            case "7": btn7.PerformClick(); break;
            case "8": btn8.PerformClick(); break;
            case "9": btn9.PerformClick(); break;
        }
    }

    private static string FormatNumber(double val)
    {
        if (double.IsNaN(val)) return "NaN";
        if (double.IsInfinity(val)) return "∞";
        if (Math.Abs(val - Math.Round(val)) < 1e-12)
        {
            return Math.Round(val).ToString("0", CultureInfo.InvariantCulture);
        }
        return val.ToString("0.##########", CultureInfo.InvariantCulture);
    }
}
