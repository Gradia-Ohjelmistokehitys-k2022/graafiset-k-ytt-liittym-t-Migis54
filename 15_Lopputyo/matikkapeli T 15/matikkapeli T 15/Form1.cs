using System.Text.RegularExpressions;

namespace matikkapeli_T_15
{
    public partial class Form1 : Form
    {   Button butt;
        bool player = true;
        //points
        int p1p;
        int p2p;
        List<Button> buttons = new List<Button>();
        List<string> match = new List<string>();
        // Listaan nappejen valuet
        List<string> jee = new List<string>()
        {
             "a","a","b","b","c","c","d","d",
             "e","e","v","v","w","w","z","z"
        };
        private void lauta(int sizeIndex)
        {
            int aX = 0;
            int aY = 0;
            int nextLineIndex = 0;

            // luodaan lauta
            for (int i = 0; i < sizeIndex * sizeIndex; i++)
            {
                Button butt = new Button();
                this.Controls.Add(butt);
                butt.Location = new Point(15 + aX, 50 + aY);
                aX += 100;
                butt.Size = new Size(100, 100);
                butt.Click += button_Click;
                butt.Name = i.ToString();
                buttons.Add(butt);
                if (i == (sizeIndex - 1) + nextLineIndex)
                {
                    aY += 100;
                    nextLineIndex += sizeIndex;
                    aX = 0;
                }
            }
        }
        private void button_rand() 
        {
            List<int> availableSpots = new List<int>();
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Text == string.Empty)
                {
                    availableSpots.Add(i);
                }
            }
            if (availableSpots.Count > 0)
            {
                
                Random random = new Random();
                int x = 0;
                for(int a=0; a <= 8; a++) 
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (i < 1)
                        {
                            x = random.Next(jee.Count);
                        }
                        int randIndex = random.Next(availableSpots.Count);
                        int spotIndex = availableSpots[randIndex];
                        buttons[spotIndex].Name = jee[x];
                        buttons[spotIndex].Text = jee[x];
                    }
                }
            }
        }
        private void button_Click(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            match.Add(button.Name);
            if (match.Count == 2)
            {
                if (match[0] == match[1])
                {
                    MessageBox.Show("match");
                    match.Clear();
                    if(player == true) 
                    {
                        p1p++;
                        label3.Text = p1p.ToString();
                        player = false;
                    }
                    else
                    {
                        p2p++;
                        label4.Text = p2p.ToString();
                        player = true;
                    }
                    
                }
                else
                {
                    MessageBox.Show("no match");
                    match.Clear();
                }
                
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lauta(4);
            button_rand();
        }
    }
}