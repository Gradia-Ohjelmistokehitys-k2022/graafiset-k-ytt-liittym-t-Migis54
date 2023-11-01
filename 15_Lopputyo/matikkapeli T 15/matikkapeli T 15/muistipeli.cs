using System.Text.RegularExpressions;

namespace matikkapeli_T_15
{
    public partial class muistipeli : Form
    {   
        bool player = true;
        //points
        int p1p;
        int p2p;
        List<Button> buttons = new List<Button>();
        List<Button> showbutton = new List<Button>();
        List<string> match = new List<string>();
        List<string> buttonValue = new List<string>()
        {
            "a","b","c","d",
            "e","f","g","h",
            "i","j","k","l",
            "m","n","o","p",
            "q","r","s","t",
            "u","v","w","x",
            "y","z","ö","ä"
        };
        private void Generate_board(int sizeIndex)
        {
            int aX = 0;
            int aY = 0;
            int nextLineIndex = 0;

            for (int i = 0; i < sizeIndex * sizeIndex; i++)
            {
                Button butt = new Button();
                this.Controls.Add(butt);
                butt.Location = new Point(15 + aX, 50 + aY);
                aX += 100;
                butt.Size = new Size(90, 90);
                butt.Click += button_Click;
                butt.Name = "";
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
            Random random = new Random();
            for (int spot = 0; spot < buttons.Count; spot++)
            {
                if (buttons[spot].Name == string.Empty)
                {
                    availableSpots.Add(spot);
                }
            }
            for (int i = 0; i < availableSpots.Count; i++)
            {
                int randIndex = random.Next(buttonValue.Count);
                if (availableSpots.Count > 0)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int randSpotIndex = random.Next(availableSpots.Count);
                        int spotIndex = availableSpots[randSpotIndex];
                        string character = buttonValue[randIndex];
                        if (buttons[spotIndex].Name != string.Empty)
                        {
                            j--;
                            return;
                        }
                        buttons[spotIndex].Name = character;
                        if (j == 1)
                        {
                            buttonValue.RemoveAt(randIndex);
                        }
                        availableSpots.RemoveAt(randSpotIndex);
                    }
                    i--;
                }
            }
        }
        private void CheckforWinner() 
        {
            if (p2p + p1p == 8)
            {
                if (p1p > p2p)
                {
                    MessageBox.Show("Player 1 won");
                }
                else if (p2p > p1p)
                {
                    MessageBox.Show("Player 2 Won");
                }
                else if (p2p == p1p)
                {
                    MessageBox.Show("draw");
                }
                Application.Restart();
            }
        }
        private void playerTurn() 
        {
            if (player == true)
            {
                player = false;
                label6.Text = "pelaajan 2 vuoro";

            }
            else
            {
                player = true;
                label6.Text = "pelaajan 1 vuoro";
            }
        }
        private void playerPoints() 
        {
            if (player == true)
            {
                p1p++;
                label3.Text = p1p.ToString();
            }
            else
            {
                p2p++;
                label4.Text = p2p.ToString();
            }
        }
        
        private void button_Click(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            match.Add(button.Name);
            button.Text = button.Name;
            showbutton.Add(button);
            if (match.Count == 2)
            {
                if (match[0] == match[1])
                {
                    MessageBox.Show("match");
                    playerPoints();
                    for (int x = 0; x < showbutton.Count; x++)
                    {
                        showbutton[x].Text = button.Name;
                        showbutton[x].Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("no match");
                    for(int x = 0; x < showbutton.Count; x++) 
                    {
                        showbutton[x].Enabled= true;
                        showbutton[x].Text = "";
                    }
                    playerTurn();
                }
                match.Clear();
                showbutton.Clear();
            }
            if (match.Count == 1) 
            { 
                button.Enabled = false; 
            }
            CheckforWinner();
            
        }
        public muistipeli()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Generate_board(4);
            button_rand();
        }
    }
}