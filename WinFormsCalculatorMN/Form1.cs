namespace WinFormsCalculatorMN
{
    public partial class Form1 : Form
    {
        public string currentBuffer = "";
        string expression = "";
        System.Globalization.CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
        //double firstNum, secondNum;
        //string op = "";
        //bool isOpClicked = false;

        // ToDo: Make more robust regarding text on buttons, e g test for valid numbers and operands.

        public Form1()
        {
            InitializeComponent();
        }

        private void updateDisplay() // The update mechanism could be improved - events, yada yada
        {
            txtDisplay.Text = currentBuffer;
        }

        public void btnDec_Click(object sender, EventArgs e)
        {
            if (!currentBuffer.Contains(ci.NumberFormat.NumberDecimalSeparator))
            {
                currentBuffer = currentBuffer + ci.NumberFormat.NumberDecimalSeparator;
                updateDisplay();
            }
        }

        public void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if(currentBuffer[0] != '-')
            {
                currentBuffer = "-" + currentBuffer;
            }
            else
            {
                currentBuffer = currentBuffer.Substring(1, currentBuffer.Length - 1);
            }
            updateDisplay();
            //double q = Convert.ToDouble(txtDisplay.Text);
            //txtDisplay.Text = Convert.ToString(-1 * q);
        }

        public void btnC_Click(object sender, EventArgs e)
        {
            currentBuffer = "";
            expression = "";
            updateDisplay();
        }
        public void btnCE_Click(object sender, EventArgs e)
        {
            currentBuffer = "";
            updateDisplay();
        }

        public void btnNum_Click(object sender, EventArgs e)
        {
            currentBuffer = currentBuffer + ((Button)sender).Text;
            updateDisplay();

        }


        public void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(currentBuffer.Length>0)
            {
                currentBuffer = currentBuffer.Substring(0, currentBuffer.Length - 1);  // This can be done smarter - just gotta look up how.
            }
            updateDisplay();
        }

        public void btnOper_Click(object sender, EventArgs e)
        {
            expression = expression + currentBuffer + ((Button)sender).Text;
            //if (Double.TryParse(txtDisplay.Text, out firstNum))
            //{
            //    Button button = (Button)sender;
            //    op = button.Text;
            //    isOpClicked = true;
            //    txtDisplay.Text = "";
            //} else
            //{
            //    txtDisplay.Text = "";
            //}
                          

        }

        public void btnEquals_Click(object sender, EventArgs e)
        {
            //if (Double.TryParse(txtDisplay.Text, out secondNum))
            //{
            //    double result = 0;

            //    switch (op)
            //    {
            //        case "+":
            //            result = firstNum + secondNum;

            //            break;
            //        case "-":
            //            result = firstNum - secondNum;

            //            break;
            //        case "*":
            //            result = firstNum * secondNum;

            //            break;
            //        case "/":
            //            if (secondNum != 0)
            //            {
            //                result = firstNum / secondNum;

            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //    txtDisplay.Text = result.ToString();
            //    firstNum = 0;
            //    secondNum = 0;
            //    op = "";
            //}
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}