namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int[] taul;

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            
            taul = new int[i + 1];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= int.Parse(textBox3.Text); i++)
                {
                    if (i == int.Parse(textBox3.Text))
                    {
                        taul[i] = int.Parse(textBox2.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (taul != null)
                {
                    label8.Text = taul[int.Parse(textBox4.Text)].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}