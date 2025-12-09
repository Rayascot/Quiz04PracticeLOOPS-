namespace Quiz04PracticeLOOPS_
{
    public partial class Form1 : Form
    {
        int G;
        int numTimes;

        public Form1()
        {
            InitializeComponent();
        }

        private void q4QuestionButton_Click(object sender, EventArgs e)
        {
            q4 q4 = new q4();
            q4.Show();
           
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {//out put go bears go 5 times
                q1OutputLabel.Text += "GO BEARS GO!";
            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            while (G < 5)
            {
                q2OutputLabel.Text += "GO BEARS GO!";
                G += 1;
            }
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {
                numTimes = Convert.ToInt32(q3TextBox.Text);
                while (G < numTimes)
                {
                    q3OutputLabel.Text += "GO BEARS GO!";
                    G += 1;
                }
            }
            catch
            {
                q3OutputLabel.Text = "Enter a whole number";
            }
        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    q4OutputLabel.Text += $"({i},{j})" + "\t" + " ";
                }
                q4OutputLabel.Text += ("\n");
            } 
        }
    }
}
