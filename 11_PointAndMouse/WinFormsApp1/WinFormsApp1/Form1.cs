namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Point point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillEllipse(Brushes.IndianRed, point.X - 4, point.Y - 8, 49, 49);
            graphics.DrawEllipse(Pens.Black, point.X - 4, point.Y - 8, 49, 49);
            graphics.DrawLine(Pens.Black, point.X + 21, point.Y + 41, point.X + 21, point.Y + 131);
            graphics.DrawLine(Pens.Black, point.X - 30, point.Y + 60, point.X + 70, point.Y + 60);
            graphics.DrawLine(Pens.Black, point.X + 21, point.Y + 131, point.X - 30, point.Y + 181);
            graphics.DrawLine(Pens.Black, point.X + 21, point.Y + 131, point.X + 70, point.Y + 181);
            DrawCordinates(graphics);
        }

        void DrawCordinates(Graphics graphics)
        {
            graphics.DrawString("(" + point.X + " ," + point.Y + ")", new Font("Arial", 14, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), 685, 400);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = e.Location;
                Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TabStop = false;
            textBox2.TabStop = false;
            button1.TabStop = false;
            point = new Point(Size.Width / 2, Size.Height / 2);
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                point = new Point(point.X, point.Y - 1);
            }
            else if (e.KeyCode == Keys.A)
            {
                point = new Point(point.X - 1, point.Y);
            }
            else if (e.KeyCode == Keys.S)
            {
                point = new Point(point.X, point.Y + 1);
            }
            else if (e.KeyCode == Keys.D)
            {
                point = new Point(point.X + 1, point.Y);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Invalidate();
            }
            else if (e.KeyCode == Keys.A)
            {
                Invalidate();
            }
            else if (e.KeyCode == Keys.S)
            {
                Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                Invalidate();
            }
        }
    }
}