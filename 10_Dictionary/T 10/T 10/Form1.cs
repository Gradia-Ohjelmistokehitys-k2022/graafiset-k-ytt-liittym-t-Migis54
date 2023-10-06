using System.Drawing.Imaging;
using System.Linq;

namespace T_10
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> emt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emt = new Dictionary<string, string>();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string x = textBox1.Text;
            if (emt.ContainsValue(x))
            {
                MessageBox.Show("dont try to add same thing twice");
            }
            else
            {
                emt.Add(textBox1.Text, textBox2.Text);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = textBox3.Text;
            label8.Text = emt[x];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}