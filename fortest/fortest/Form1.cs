namespace fortest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 1; i <= 100; i++)
            {
                ans = ans + i; // ans+=i;
            }
            textBox1.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBox2.Text);
            int end = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            int ans = 0;
            for (int i = start; i <= end; i = i + d)
            {
                ans = ans + i; // ans+=i;
            }
            textBox1.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ans = 0;
            for (double i = 1; i <= 100; i = i + 0.5)
            {
                ans = ans + i; // ans+=i;
            }
            textBox1.Text = ans.ToString();
        }

        //n! =n*n-1*n-2*...1
        //n! =1 *2*3*...*n
        private void button5_Click(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                ans = ans * i; // ans+=i;
            }
            textBox1.Text = ans.ToString();
        }
    }
}