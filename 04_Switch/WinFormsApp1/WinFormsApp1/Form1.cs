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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Press(object sender, EventArgs e) 
        {
            Button button1 = sender as Button;
            switch (button1.Text) 
            {
                case "Valinta 1":
                    MessageBox.Show(button1.Text);
                    break;
                case "Valinta 2":
                    MessageBox.Show(button2.Text);
                    break;
                case "Valinta3":
                    MessageBox.Show(button3.Text);
                    break;
                case "Valinta4":
                    MessageBox.Show(button4.Text);
                    break;
                case "Default":
                    MessageBox.Show(button5.Text);
                    break;
                    
            }

        }
    }
}