
using System.Security.Cryptography.X509Certificates;

namespace _08
{
    public partial class Form1 : Form
    {
        int[] joo;
        int[] extr;
        int[] you;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd= new Random();
            for (int j = 0; j < joo.Length; j++)
            {
                int x = rnd.Next(1, 41);
                if (!joo.Contains(x)) 
                {
                    joo[j] = x;
                }
                else 
                {
                    j--;
                }

            }
            for (int j = 0; j< extr.Length; j++) 
            {
                int x = rnd.Next(1, 41);
                if(!extr.Contains(x)) 
                {
                    extr[j] = x;
                }
                else 
                {
                    j--;
                }
            }
            Array.Sort(extr);
            Array.Sort(joo);
            label5.Text = string.Join(", ", extr);
            label1.Text = string.Join(", ", joo);   

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            joo = new int[7];
            extr = new int[2];
            you = new int[7];   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cn = 0;
            you[0] = int.Parse(textBox1.Text);
            you[1] = int.Parse(textBox2.Text);
            you[2] = int.Parse(textBox3.Text);
            you[3] = int.Parse(textBox4.Text);
            you[4] = int.Parse(textBox5.Text);
            you[5] = int.Parse(textBox6.Text);
            you[6] = int.Parse(textBox7.Text);
            Array.Sort(you);
            for(int j = 0; j < you.Length; j++)
                if (joo.Contains(you[j]) || extr.Contains(you[j])) 
                {
                    cn++;
                }
            MessageBox.Show("you guessed " + cn + " numbers right");
        }
    }
}