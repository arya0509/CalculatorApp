namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<string> NumbersAndOp = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Equalclicked() 
        {
            NumbersAndOp.Add(label.Text);

            if (NumbersAndOp[1] == "+")
            {
                float firstnum = float.Parse(NumbersAndOp[0]);
                float sum = firstnum + float.Parse(NumbersAndOp[2]);
                label.Text = sum.ToString();
                NumbersAndOp.Clear();
                NumbersAndOp.Add(sum.ToString());


            }
            else if (NumbersAndOp[1] == "-")
            {
                float firstnum = float.Parse(NumbersAndOp[0]);
                float sum = firstnum - float.Parse(NumbersAndOp[2]);
                label.Text = sum.ToString();
                NumbersAndOp.Clear();
                NumbersAndOp.Add(sum.ToString());

            }
            else if (NumbersAndOp[1] == "*")
            {
                float firstnum = float.Parse(NumbersAndOp[0]);
                float sum = firstnum * float.Parse(NumbersAndOp[2]);
                label.Text = sum.ToString();
                NumbersAndOp.Clear();
                NumbersAndOp.Add(sum.ToString());

            }
            else
            {
                float firstnum = float.Parse(NumbersAndOp[0]);
                float secondnum = float.Parse(NumbersAndOp[2]);
                if (secondnum == 0)
                { label.Text = "Invalid operation.Cannot Divide by zer"; }
                else
                {
                    float sum = firstnum / secondnum;
                    label.Text = sum.ToString();
                    NumbersAndOp.Clear();
                    NumbersAndOp.Add(sum.ToString());

                }
            }
        }

        private void AC_Clicked(object sender, EventArgs e)
        {
            label.Text = "";
            NumbersAndOp.Clear();

        }

        private void PlusOrMinus_Clicked(object sender, EventArgs e)
        {
            if (int.Parse(label.Text) > 0)
            {
                label.Text = "-" + label.Text;
            }
            else
            {
                int newnum = int.Parse(label.Text) * (-1);
                label.Text = newnum.ToString();
            }

        }

        private void Percentage_Clicked(object sender, EventArgs e)
        {
            float NewNum = float.Parse(label.Text)/100;

            label.Text = NewNum.ToString();
        }

   

        private void number_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "+")
            {
                    NumbersAndOp.Add(label.Text);
                    NumbersAndOp.Add("+");
                    label.Text = "+";
                if (NumbersAndOp[0]==NumbersAndOp
                    [1]) 
                {
                    NumbersAndOp.RemoveAt(0);
                }
                
            }
            else if (button.Text == "*")
            {
                
                
                    NumbersAndOp.Add(label.Text);
                    NumbersAndOp.Add("*");
                    label.Text = "*";
                if (NumbersAndOp[0] == NumbersAndOp
                   [1])
                {
                    NumbersAndOp.RemoveAt(0);
                }

            }
            else if (button.Text == "/")
            {
                    NumbersAndOp.Add(label.Text);
                    NumbersAndOp.Add("/");
                    label.Text = "/";
                if (NumbersAndOp[0] == NumbersAndOp
                   [1])
                {
                    NumbersAndOp.RemoveAt(0);
                }
            }
            else if (button.Text == "-")
            {
                
                
                    NumbersAndOp.Add(label.Text);
                    NumbersAndOp.Add("-");
                    label.Text = "-";
                if (NumbersAndOp[0] == NumbersAndOp
                   [1])
                {
                    NumbersAndOp.RemoveAt(0);
                }

            }
            else if (button.Text == "=")
            {
                Equalclicked();
            }
            else
            {
                if(label.Text=="+"|| label.Text == "-"|| label.Text == "*"|| label.Text == "/")
                { label.Text = ""; }
                label.Text = label.Text+button.Text;
                        
            }

            
            
            
             
                
            
        }

        private void dot_Clicked(object sender, EventArgs e)
        {
            int num = int.Parse(label.Text);
            label.Text = label.Text + ".";


        }
    }

}
