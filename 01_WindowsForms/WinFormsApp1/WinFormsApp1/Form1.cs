namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string defaultname = "syötä elokuvan nimi";
        string defaultarvio = "lisää arvio tähän";
        int defaultLenght = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "syötä elokuvan nimi";
            textBox3.Text = "0";
            textBox5.Text = "lisää arvio tähän";
            textBox1.Text = DateTime.Now.Year.ToString();
            numericUpDown1.Value = 5;
            numericUpDown2.Value= 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiedostojaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Mikko Reini!");
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.Year.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == DateTime.Now.Year.ToString())
            {
                textBox1.Clear();
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty) 
            {
                textBox2.Text = ("syötä elokuvan nimi");
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "syötä elokuvan nimi")
            {
                textBox2.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = DateTime.Now.Year.ToString();
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                textBox3.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = ("0");
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "lisää arvio tähän")
            {
                textBox5.Clear();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.Text = ("lisää arvio tähän");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num;
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("julkaisuvuosi tyhjä");
            }
            else if (!int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("Julkaisuvuosi ei ole numero");
            }
            else if (textBox3.Text == string.Empty || textBox3.Text == defaultLenght.ToString())
            {
                MessageBox.Show("kesto kenttä tyhjä");
            }
            else if (!int.TryParse(textBox3.Text, out num))
            {
                MessageBox.Show("Kesto ei ole numero");
            }
            else if (textBox2.Text == defaultname) 
            {
                MessageBox.Show("et ole laittanut elokuvan nimeä");
            }
            else
            {
                MessageBox.Show("Check Ok!");
            }
        }
    }
}