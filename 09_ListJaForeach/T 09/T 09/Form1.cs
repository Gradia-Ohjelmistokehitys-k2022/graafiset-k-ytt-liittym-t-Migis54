using System.Diagnostics.Contracts;

namespace T_09
{
    public partial class Form1 : Form
    {
        List<string> emt;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            emt = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (emt.Contains(x))
            {
                MessageBox.Show("dont try to add same thing twice");
            }
            else
            {
                emt.Add(x);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(string i in emt) 
            {
                if (!comboBox1.Items.Contains(i)) 
                {
                    comboBox1.Items.Add(i);
                }
                
            }
        }
    }
}