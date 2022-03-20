namespace WinFormsCalculatorMN
{
    public partial class Form1 : Form
    {
        double firstNum, secondNum;
        string op = "";
        bool isOpClicked = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnDec_Click(object sender, EventArgs e)
        {
            if (btnDec.Text == ".")
            {
                if (!txtDisplay.Text.Contains(","))
                {
                    txtDisplay.Text = txtDisplay.Text + ",";
                }
            }

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * q);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            
            if ((txtDisplay.Text == "0") || (isOpClicked))
            {
                txtDisplay.Clear();
            }
            Button button = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + button.Text;
            isOpClicked = false;
        }


        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnOper_Click(object sender, EventArgs e)
        {
          
            
            if (Double.TryParse(txtDisplay.Text, out firstNum))
            {
                Button button = (Button)sender;
                op = button.Text;
                isOpClicked = true;
                txtDisplay.Text = "";
            } else
            {
                txtDisplay.Text = "";
            }
                          

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtDisplay.Text, out secondNum))
            {
                double result = 0;

                switch (op)
                {
                    case "+":
                        result = firstNum + secondNum;

                        break;
                    case "-":
                        result = firstNum - secondNum;

                        break;
                    case "*":
                        result = firstNum * secondNum;

                        break;
                    case "/":
                        if (secondNum != 0)
                        {
                            result = firstNum / secondNum;

                        }
                        break;
                    default:
                        break;
                }
                txtDisplay.Text = result.ToString();
                firstNum = 0;
                secondNum = 0;
                op = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}