namespace T_13
{
    public partial class Form1 : Form
    {
        Bitmap img1;
        Point piste = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            img1 = new Bitmap(Properties.Resources.picture04);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics joo = e.Graphics;
            img1.MakeTransparent();
            joo.DrawImage(img1, piste.X -100, piste.Y -150 );
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
            piste = new Point(Size.Width / 2, Size.Height / 2);
            Invalidate();

        }
    }
}