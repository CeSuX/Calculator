using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorWin : Form
    {
        public CalculatorWin()
        {
            InitializeComponent();
        }

        public string Calculate()
        {
            string result = string.Empty;
            if(Operations.Text.Length == 0 || OutBox.Text.Length == 0) { return OutBox.Text; }
            switch (Operations.Text[Operations.Text.Length - 1])
            {
                case '+':
                    result = (Convert.ToDecimal(OutBox.Text) +
                    Convert.ToDecimal(Operations.Text.Remove(Operations.Text.Length - 1)))
                    .ToString();
                    break;
                case '-':
                    result = (Convert.ToDecimal(OutBox.Text) -
                    Convert.ToDecimal(Operations.Text.Remove(Operations.Text.Length - 1)))
                    .ToString();
                    break;
                case 'x':
                    result = (Convert.ToDecimal(OutBox.Text) *
                    Convert.ToDecimal(Operations.Text.Remove(Operations.Text.Length - 1)))
                    .ToString();
                    break;
                case '/':
                    if(OutBox.Text.Length == 0) { return ""; }
                    result = (Convert.ToDecimal(OutBox.Text) /
                    Convert.ToDecimal(Operations.Text.Remove(Operations.Text.Length - 1)))
                    .ToString();
                    break;
            }
            Operations.ResetText();
            return result;
        }

        #region ON/OFF Buttons.
        private void ButtonOFF_Click(object sender, EventArgs e)
        {
            // EXPLANATION:
            // * Hides 'OFF' button, shows 'ON' button.
            // * Enables entry cleaning buttons (Delete, CLEAR).
            // * Enables 'OutBox' (TextBox, which outputs the input/result).
            // * Enables math buttons (addition, subtraction, multiplication, division).
            // * Enables number buttons (from 0 to 9).

            #region ON/OFF buttons:
            ButtonON.Show();
            ButtonOFF.Hide();
            #endregion

            #region Entry cleaning buttons:
            ButtonDELETE.Enabled = true;
            ButtonCLEAR.Enabled  = true;
            #endregion

            #region OutBox button:
            OutBox.Enabled = true;
            #endregion

            #region Math buttons:
            ButtonAddition.Enabled       = true;
            ButtonSubtraction.Enabled    = true;
            ButtonMultiplication.Enabled = true;
            ButtonDivision.Enabled       = true;
            ButtonResult.Enabled         = true;
            ButtonPeriod.Enabled         = true;
            #endregion

            #region Number buttons:
            Button0.Enabled = true;
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            #endregion
        }

        private void ButtonON_Click(object sender, EventArgs e)
        {
            // EXPLANATION:
            // * Shows 'OFF' button, hides 'ON' button.
            // * Disables entry cleaning buttons (Delete, CLEAR).
            // * Disables 'OutBox' (TextBox, which outputs the input/result).
            // * Disables math buttons (addition, subtraction, multiplication, division).
            // * Disables number buttons (from 0 to 9).

            #region ON/OFF buttons:
            ButtonON.Hide();
            ButtonOFF.Show();
            #endregion

            #region Entry cleaning buttons:
            ButtonDELETE.Enabled = false;
            ButtonCLEAR.Enabled  = false;
            #endregion

            #region OutBox button:
            OutBox.Enabled = false;
            #endregion

            #region Math buttons:
            ButtonAddition.Enabled       = false;
            ButtonSubtraction.Enabled    = false;
            ButtonMultiplication.Enabled = false;
            ButtonDivision.Enabled       = false;
            ButtonResult.Enabled         = false;
            ButtonPeriod.Enabled         = false;
            #endregion

            #region Number buttons:
            Button0.Enabled = false;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
            #endregion
        }
        #endregion

        #region Entry cleaning buttons.
        public void ButtonDELETE_Click(object sender, EventArgs e)
        {
            // Removes the last character of 'OutBox'.
            try
            { OutBox.Text = OutBox.Text.Remove(OutBox.Text.Length - 1); }
            catch(System.Exception) { }
        }

        private void ButtonCLEAR_Click(object sender, EventArgs e)
        {
            // Clears the 'OutBox', 'Operations'.
            OutBox.Clear();
            Operations.ResetText();
        }
        #endregion

        #region Math buttons.
        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            if (OutBox.Text.Length != 0)
            {
                Operations.Text = OutBox.Text + " +";
                OutBox.Clear();
            }
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            if (OutBox.Text.Length != 0)
            {
                Operations.Text = OutBox.Text + " -";
                OutBox.Clear();
            }
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            if (OutBox.Text.Length != 0)
            {
                Operations.Text = OutBox.Text + " x";
                OutBox.Clear();
            }
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            if (OutBox.Text.Length != 0)
            {
                Operations.Text = OutBox.Text + " /";
                OutBox.Clear();
            }
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            OutBox.Text = Calculate();
        }

        private void ButtonPeriod_Click(object sender, EventArgs e)
        {
            if (!(OutBox.Text.Contains(".") || OutBox.Text.Length == 0))
            { OutBox.Text += "."; }
        }
        #endregion

        #region Number buttons.
        private void Button9_Click(object sender, EventArgs e)
        {
            OutBox.Text += 9;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            OutBox.Text += 8;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OutBox.Text += 7;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OutBox.Text += 6;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OutBox.Text += 5;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OutBox.Text += 4;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OutBox.Text += 3;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OutBox.Text += 2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OutBox.Text += 1;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            OutBox.Text += 0;
        }
        #endregion
    }
}
