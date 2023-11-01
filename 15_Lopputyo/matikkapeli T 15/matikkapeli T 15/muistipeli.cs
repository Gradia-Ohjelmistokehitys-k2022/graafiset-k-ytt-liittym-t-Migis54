using System.Text.RegularExpressions;

namespace matikkapeli_T_15
{
    public partial class muistipeli : Form
    {   
        bool _player = true;
        //points
        int _p1p;
        int _p2p;
        List<Button> _kortit = new List<Button>();
        List<Button> _showbutton = new List<Button>();
        List<string> _match = new List<string>();
        List<string> _kortinArvo = new List<string>()
        {
            "a","b","c","d",
            "e","f","g","h",
            "i","j","k","l",
            "m","n","o","p",
            "q","r","s","t",
            "u","v","w","x",
            "y","z","ö","ä"
        };
        private void PiirraLauta(int sizeIndex)
        {
            int aX = 0;
            int aY = 0;
            int nextLineIndex = 0;

            for (int i = 0; i < sizeIndex * sizeIndex; i++)
            {
                //butt.Location = new Point(15 + aX, 50 + aY);
                Kortti kortti = new (aX, aY, nextLineIndex);
                Controls.Add(kortti);    
                Click += button_Click;
                
                _kortit.Add(kortti);

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
           
            List<string> characters = new List<string>(_kortinArvo); // kopio lista
            List<int> availableSpots = new List<int>();
            Random random = new Random();
           
            for (int spot = 0; spot < _kortit.Count; spot++)
            {
                if (_kortit[spot].Name == string.Empty)
                {
                    availableSpots.Add(spot);
                }
            }
            for (int i = 0; i < availableSpots.Count; i++)
            {
                int randIndex = random.Next(characters.Count);
                if (availableSpots.Count > 0)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int randSpotIndex = random.Next(availableSpots.Count);
                        int spotIndex = availableSpots[randSpotIndex];
                        string character = characters[randIndex];
                        if (_kortit[spotIndex].Name != string.Empty)
                        {
                            j--;
                            return;
                        }
                        _kortit[spotIndex].Name = character;
                        if (j == 1)
                        {
                            characters.RemoveAt(randIndex);
                        }
                        availableSpots.RemoveAt(randSpotIndex);
                    }
                    i--;
                }
            }
        }
        private void CheckforWinner() 
        {
            if (_p2p + _p1p == 8)
            {
                if (_p1p > _p2p)
                {
                    MessageBox.Show("Player 1 won");
                }
                else if (_p2p > _p1p)
                {
                    MessageBox.Show("Player 2 Won");
                }
                else if (_p2p == _p1p)
                {
                    MessageBox.Show("draw");
                }
                Application.Restart();
            }
        }
        private void playerTurn() 
        {
            if (_player == true)
            {
                _player = false;
                label6.Text = "pelaajan 2 vuoro";

            }
            else
            {
                _player = true;
                label6.Text = "pelaajan 1 vuoro";
            }
        }
        private void playerPoints() 
        {
            if (_player == true)
            {
                _p1p++;
                label3.Text = _p1p.ToString();
            }
            else
            {
                _p2p++;
                label4.Text = _p2p.ToString();
            }
        }
        
        private void button_Click(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            _match.Add(button.Name);
            button.Text = button.Name;
            _showbutton.Add(button);
            if (_match.Count == 2)
            {
                if (_match[0] == _match[1])
                {
                    MessageBox.Show("match");
                    playerPoints();
                    for (int x = 0; x < _showbutton.Count; x++)
                    {
                        _showbutton[x].Text = button.Name;
                        _showbutton[x].Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("no match");
                    for(int x = 0; x < _showbutton.Count; x++) 
                    {
                        _showbutton[x].Enabled= true;
                        _showbutton[x].Text = "";
                    }
                    playerTurn();
                }
                _match.Clear();
                _showbutton.Clear();
            }
            if (_match.Count == 1) 
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
            PiirraLauta(4);
            button_rand();
        }
    }
}