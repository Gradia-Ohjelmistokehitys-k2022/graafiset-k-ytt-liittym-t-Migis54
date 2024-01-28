namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            while(true) 
            {
                DialogResult x = MessageBox.Show("yes for loop no for no loop", "Warning", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    continue;
                }
                else if (x == DialogResult.No)
                {
                    break;
                }
            }
        }
    }
}