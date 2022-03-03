namespace Maszyna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, Answer1, Answer2, Delta;
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);
            c = double.Parse(C.Text);

            Answer1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Answer2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Delta = (Math.Pow(b, 2) - 4 * a * c);

            label5.Text = Answer1.ToString("n2");
            label6.Text = Answer2.ToString("n2");
            label9.Text = Delta.ToString("n2");


        }

    }
}