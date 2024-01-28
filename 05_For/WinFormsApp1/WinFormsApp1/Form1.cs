namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            for(int i = 0; i <= num; i++) 
            {
                label1.Update();
                label1.Text = i.ToString();
                Thread.Sleep(50);
            }
        }
    }
}