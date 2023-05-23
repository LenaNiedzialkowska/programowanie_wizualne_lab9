using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace programowanie_wizualne_lab9
{
    public partial class Form1 : Form
    {
        bool newNumber = true;
        string sign;
        double num1;
        double num2;
        bool simple_calc = true;
        public Form1()
        {
            InitializeComponent();
            this.textBox1.AutoSize = false;
            if (simple_calc == true)
            {
                this.textBox1.Size = new System.Drawing.Size(357, 45);
                this.Size = new Size(393, 592);
                buttonLn.Hide();
                buttonLog.Hide();
                buttonSquareRoot.Hide();
                button10ToX.Hide();
                buttonXToY.Hide();
                buttonXto2.Hide();
                button1ByX.Hide();
                buttonExp.Hide();
                buttonPercent.Hide();
                buttonPi.Hide();
                buttonE.Hide();
                buttonSin.Hide();
                buttonCos.Hide();
                buttonNPower.Hide();
                buttonAbsolute.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = String.Empty;
            sign = String.Empty;
            newNumber = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            newNumber = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberButton_Click("1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButton_Click("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButton_Click("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Operation("x");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberButton_Click("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberButton_Click("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NumberButton_Click("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NumberButton_Click("7");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NumberButton_Click("8");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NumberButton_Click("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt64(textBox1.Text) * -1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            NumberButton_Click("0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
                newNumber = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            label2.Text = String.Empty;
            switch (sign)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "x":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = "Nie mo¿na dzieliæ przez 0";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(num1 / num2);
                    }
                    break;
            }
            sign = String.Empty;
            newNumber = true;
        }

        private void NumberButton_Click(string number)
        {
            if (newNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                newNumber = false;
            }
        }

        private void Operation(string sign)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text;
            label2.Text += sign;
            this.sign = sign;
            newNumber = true;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (simple_calc == true)
            {
                label1.Text = "Naukowy";
                simple_calc = false;
                this.Size = new Size(675, 592);
                this.textBox1.Size = new System.Drawing.Size(634, 45);
                buttonLn.Show();
                buttonLog.Show();
                buttonSquareRoot.Show();
                button10ToX.Show();
                buttonXToY.Show();
                buttonXto2.Show();
                button1ByX.Show();
                buttonExp.Show();
                buttonPercent.Show();
                buttonPi.Show();
                buttonE.Show();
                buttonSin.Show();
                buttonCos.Show();
                buttonNPower.Show();
                buttonAbsolute.Show();
            }
            else
            {
                label1.Text = "Standardowy";
                simple_calc = true;
                this.textBox1.Size = new System.Drawing.Size(357, 45);
                this.Size = new Size(393, 592);
                buttonLn.Hide();
                buttonLog.Hide();
                buttonSquareRoot.Hide();
                button10ToX.Hide();
                buttonXToY.Hide();
                buttonXto2.Hide();
                button1ByX.Hide();
                buttonExp.Hide();
                buttonPercent.Hide();
                buttonPi.Hide();
                buttonE.Hide();
                buttonSin.Hide();
                buttonCos.Hide();
                buttonNPower.Hide();
                buttonAbsolute.Hide();

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = "Ln(" + textBox1.Text + ")";
            newNumber = true;
            num1 = Math.Log(num1);
            textBox1.Text = num1.ToString();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = "Log10(" + textBox1.Text + ")";
            newNumber = true;
            num1 = Math.Log10(num1);
            textBox1.Text = num1.ToString();
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = "sqrt(" + textBox1.Text + ")";
            newNumber = true;
            num1 = Math.Sqrt(num1);
            textBox1.Text = num1.ToString();
        }

        private void button10ToX_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = 10 + "^" + textBox1;
            newNumber = true;
            num1 = Math.Pow(10, num1);
            textBox1.Text = num1.ToString();
        }

        private void buttonXToY_Click(object sender, EventArgs e)
        {

        }

        private void buttonXto2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text + "^2";
            newNumber = true;
            num1 = Math.Pow(num1, 2);
            textBox1.Text = num1.ToString();
        }

        private void button1ByX_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label2.Text = "1/" + textBox1.Text;
            newNumber = true;
            num1 = 1 / num1;
            textBox1.Text = num1.ToString();
        }

        private void buttonAbsolute_Click(object sender, EventArgs e)
        {
            label2.Text = "|"+textBox1.Text + "|";
            num1 = Convert.ToDouble(textBox1.Text);
            num1 = Math.Abs(num1);
            textBox1.Text = num1.ToString();
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {

        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text + "%";
            num1 = Convert.ToDouble(textBox1.Text);
            num1 = num1 / 100;
            textBox1.Text = num1.ToString();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265359";
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                num1 = Math.Exp(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(num1);
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            label2.Text = "sin(" + textBox1.Text + ")";
            num1 = Math.Sin(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(num1);
        }
        private void buttonCos_Click(object sender, EventArgs e)
        {
            label2.Text = "cos("+ textBox1.Text+")";
            num1 = Math.Cos(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(num1);
        }

        private void buttonNPower_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = textBox1.Text + "!";
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
                {
                    fact = fact * i;
                }
                textBox1.Text = Convert.ToString(fact);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}