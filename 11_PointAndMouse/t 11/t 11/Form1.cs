using System.Drawing;
using System.Security.Cryptography;

namespace t_11
{
    public partial class Form1 : Form
    {
        Point piste = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }
        

        // Talletetaan grafiikkaobjekti. Grafiikkaobjekti tarvitaan 

        // grafikan piirtämiseksi näytölle. 

        private void Form1_paint(object sender, PaintEventArgs e)

        {

            Graphics Graf = e.Graphics;

            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);



            // Kutsutaan DrawCoordinates()-metodia. 

            DrawCordinates(Graf);

        }

        // DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle.  



        private void DrawCordinates(Graphics Graf)

        {

            // Piirretään piirtokoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TabStop = false;
            textBox2.TabStop = false;
            button1.TabStop = false;
            piste = new Point(Size.Width / 2, Size.Height / 2);
            Invalidate();

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            piste = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Invalidate();
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) 
        {
            
            if (e.KeyCode == Keys.W) 
            {
                piste = new Point(piste.X, piste.Y - 1);
            }
            else if (e.KeyCode == Keys.S)
            {
                piste = new Point(piste.X, piste.Y + 1);
            }
            else if (e.KeyCode == Keys.A)
            {
                piste = new Point(piste.X - 1, piste.Y);
            }
            else if (e.KeyCode == Keys.D)
            {
                piste = new Point(piste.X + 1, piste.Y);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.W)
            {
                Invalidate();
            }
            else if (e.KeyCode == Keys.S)
            {
                Invalidate();
            }
            else if (e.KeyCode == Keys.A)
            {
                Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                Invalidate();
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}