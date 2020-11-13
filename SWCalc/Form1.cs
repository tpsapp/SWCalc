using System;
using System.Windows.Forms;

namespace SWCalc
{
    public partial class frmMain : Form
    {
        decimal iFirstValue = 0;
        decimal iSecondValue = 0;
        decimal iAnswer = 0;
        bool bAdd = false;
        bool bSub = false;
        bool bMult = false;
        bool bDiv = false;
        bool bAns = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0";
            iFirstValue = 0;
            iSecondValue = 0;
            iAnswer = 0;
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = false;
            bAns = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "1";
            }
            else
            {
                tbDisplay.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "2";
            }
            else
            {
                tbDisplay.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "3";
            }
            else
            {
                tbDisplay.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "4";
            }
            else
            {
                tbDisplay.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "5";
            }
            else
            {
                tbDisplay.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "6";
            }
            else
            {
                tbDisplay.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "7";
            }
            else
            {
                tbDisplay.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "8";
            }
            else
            {
                tbDisplay.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "9";
            }
            else
            {
                tbDisplay.Text = "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += "0";
            }
            else
            {
                tbDisplay.Text = "0";
            }
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (bAns)
            {
                tbDisplay.Text = "0";
                bAns = false;
            }
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tbDisplay.Text != "Overflow Err") && (tbDisplay.Text != "Divide by 0"))
            {
                iFirstValue = Convert.ToDecimal(tbDisplay.Text);
            }
            bAdd = true;
            bSub = false;
            bMult = false;
            bDiv = false;
            tbDisplay.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if ((tbDisplay.Text != "Overflow Err") && (tbDisplay.Text != "Divide by 0"))
            {
                iFirstValue = Convert.ToDecimal(tbDisplay.Text);
            }
            bAdd = false;
            bSub = true;
            bMult = false;
            bDiv = false;
            tbDisplay.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if ((tbDisplay.Text != "Overflow Err") && (tbDisplay.Text != "Divide by 0"))
            {
                iFirstValue = Convert.ToDecimal(tbDisplay.Text);
            }
            bAdd = false;
            bSub = false;
            bMult = true;
            bDiv = false;
            tbDisplay.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if ((tbDisplay.Text != "Overflow Err") && (tbDisplay.Text != "Divide by 0"))
            {
                iFirstValue = Convert.ToDecimal(tbDisplay.Text);
            }
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = true;
            tbDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (bAdd)
            {
                iSecondValue = Convert.ToDecimal(tbDisplay.Text);
                iAnswer = iFirstValue + iSecondValue;
                tbDisplay.Text = iAnswer.ToString();
            }
            if (bSub)
            {
                iSecondValue = Convert.ToDecimal(tbDisplay.Text);
                iAnswer = iFirstValue - iSecondValue;
                tbDisplay.Text = iAnswer.ToString();
            }
            if (bMult)
            {
                iSecondValue = Convert.ToDecimal(tbDisplay.Text);
                iAnswer = iFirstValue * iSecondValue;
                tbDisplay.Text = iAnswer.ToString();
            }
            if (bDiv)
            {
                if (tbDisplay.Text != "0")
                {
                    iSecondValue = Convert.ToDecimal(tbDisplay.Text);
                    iAnswer = iFirstValue / iSecondValue;
                    tbDisplay.Text = iAnswer.ToString();
                }
                else
                {
                    tbDisplay.Text = "Divide by 0";
                }
            }
            if ((iAnswer > 999999999999) || (iAnswer < -99999999999))
            {
                tbDisplay.Text = "Overflow Err";
            }
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = false;
            bAns = true;
            iFirstValue = 0;
            iSecondValue = 0;
            iAnswer = 0;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    btnAdd_Click(sender, e);
                    break;
                case Keys.D0:
                    btn0_Click(sender, e);
                    break;
                case Keys.D1:
                    btn1_Click(sender, e);
                    break;
                case Keys.D2:
                    btn2_Click(sender, e);
                    break;
                case Keys.D3:
                    btn3_Click(sender, e);
                    break;
                case Keys.D4:
                    btn4_Click(sender, e);
                    break;
                case Keys.D5:
                    btn5_Click(sender, e);
                    break;
                case Keys.D6:
                    btn6_Click(sender, e);
                    break;
                case Keys.D7:
                    btn7_Click(sender, e);
                    break;
                case Keys.D8:
                    {
                        if (e.Shift)
                        {
                            btnMult_Click(sender, e);
                        }
                        else
                        {
                            btn8_Click(sender, e);
                        }
                    }
                    break;
                case Keys.D9:
                    btn9_Click(sender, e);
                    break;
                case Keys.Decimal:
                    btnPeriod_Click(sender, e);
                    break;
                case Keys.Delete:
                    btnClear_Click(sender, e);
                    break;
                case Keys.Divide:
                    btnDiv_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnClear_Click(sender, e);
                    break;
                case Keys.Multiply:
                    btnMult_Click(sender, e);
                    break;
                case Keys.NumPad0:
                    btn0_Click(sender, e);
                    break;
                case Keys.NumPad1:
                    btn1_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    btn2_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    btn3_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    btn4_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    btn5_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    btn6_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    btn7_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    btn8_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    btn9_Click(sender, e);
                    break;
                case Keys.Subtract:
                    btnSub_Click(sender, e);
                    break;
                case Keys.Enter:
                    btnEquals_Click(sender, e);
                    break;
                case Keys.OemPeriod:
                    btnPeriod_Click(sender, e);
                    break;
                case Keys.OemMinus:
                    btnSub_Click(sender, e);
                    break;
                case Keys.Oemplus:
                    {
                        if (e.Shift)
                        {
                            btnAdd_Click(sender, e);
                        }
                        else
                        {
                            btnEquals_Click(sender, e);
                        }
                    }
                    break;
                case Keys.OemQuestion:
                    btnDiv_Click(sender, e);
                    break;
                case Keys.F1:
                    MessageBox.Show("Sappsworld Calculator V1.0\nCreated by Thomas Sapp\nhttp://code.sappsworld.com", "About...");
                    break;
                case Keys.F12:
                    {
                        MessageBox.Show("iFirstValue = " + iFirstValue + "\niSecondValue = " + iSecondValue + "\niAnswer = " + iAnswer + "\nbAdd = " + bAdd + "\nbSub = " + bSub + "\nbMult = " + bMult + "\nbDiv = " + bDiv + "\nbAns = " + bAns, "Variable Info");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
