using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorWin : Form
    {
        // Global variable for storing the current state of calculator.
        // (ON/OFF)
        bool CalcState = true;

        public CalculatorWin()
        {
            InitializeComponent();
        }

        public string Calculate()
        {
            if (Operations.Text.Length == 0 || OutBox.Text.Length == 0)
                return OutBox.Text;

            string result = string.Empty;
            char operation = Operations.Text[Operations.Text.Length - 1];

            decimal[] numbers =
            {
                Convert.ToDecimal(OutBox.Text),
                Convert.ToDecimal(Operations.Text.Remove(Operations.Text.Length - 1))
            };

            switch (operation)
            {
                case '+':
                    result = (numbers[0] + numbers[1]).ToString();
                    break;
                case '-':
                    result = (numbers[0] - numbers[1]).ToString();
                    break;
                case 'x':
                    result = (numbers[0] * numbers[1]).ToString();
                    break;
                case '/':
                    result = (numbers[0] / numbers[1]).ToString();
                    break;
            }
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
            // * Sets variable 'CalcState' to true (enabled).

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

            CalcState = true;
        }

        private void ButtonON_Click(object sender, EventArgs e)
        {
            // EXPLANATION:
            // * Shows 'OFF' button, hides 'ON' button.
            // * Disables entry cleaning buttons (Delete, CLEAR).
            // * Disables 'OutBox' (TextBox, which outputs the input/result).
            // * Disables math buttons (addition, subtraction, multiplication, division).
            // * Disables number buttons (from 0 to 9).
            // * Sets variable 'CalcState' to false (disabled).

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

            CalcState = false;
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

        private void Key_Shortcuts(object sender, KeyEventArgs e)
        {
            #region Entry cleaning button key shortcuts.
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (e.Alt) { ButtonCLEAR_Click(sender, e); }
                else { ButtonDELETE_Click(sender, e); }
            }
            #endregion

            #region Number button key shortcuts.
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            { Button0_Click(sender, e); }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            { Button1_Click(sender, e); }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            { Button2_Click(sender, e); }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            { Button3_Click(sender, e); }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            { Button4_Click(sender, e); }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            { Button5_Click(sender, e); }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            { Button6_Click(sender, e); }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            { Button7_Click(sender, e); }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            { Button8_Click(sender, e); }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            { Button9_Click(sender, e); }
            #endregion

            #region Math button key shortcuts.
            if (e.KeyCode == Keys.Add)
            { ButtonAddition_Click(sender, e); }
            if (e.KeyCode == Keys.Subtract)
            { ButtonSubtraction_Click(sender, e); }
            if (e.KeyCode == Keys.Multiply || e.KeyCode == Keys.X)
            { ButtonMultiplication_Click(sender, e); }
            if (e.KeyCode == Keys.Divide)
            { ButtonDivision_Click(sender, e); }
            if(e.KeyCode == Keys.OemPeriod)
            { ButtonPeriod_Click(sender, e); }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
            { ButtonResult_Click(sender, e); }
            #endregion

            #region ON/OFF button key shortcuts.
            if(e.KeyCode == Keys.Escape)
            {
                switch(CalcState)
                {
                    case true:
                        ButtonON_Click(sender, e);
                        break;
                    case false:
                        ButtonOFF_Click(sender, e);
                        break;
                }
            }
            #endregion
        }
    }
}
