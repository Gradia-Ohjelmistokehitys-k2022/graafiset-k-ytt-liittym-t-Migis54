using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace matikkapeli_T_15
{
    public partial class muistipeli : Form
    { public static muistipeli instance { get; private set;}
        Player reference;
        List<Button> showbutton = new List<Button>();
        List<string> match = new List<string>();
        List<Button> buttons = new List<Button>();
        List<string> buttonValue = new List<string>()
        {
            "Dog","Cat","Duck","Mouse",
            "Rat","Snake","Pig","Cow",
            "Pidgeon","Goat","Fox","Chicken",
            "Bear","Lion","Parrot","Salmon",
            "FatBear","Turtle","Bird","Ant",
            "Horse","Donkey","Jaguar","Elephant",
            "Mikko","Jasper","Joel","Otso", "Niko"
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
        private void Random_button_value()
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
        
        public void button_Click(object sender, EventArgs e)
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
                    reference.playerPoints();
                    for (int x = 0; x < showbutton.Count; x++)
                    {
                        showbutton[x].Text = button.Name;
                        showbutton[x].Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("no match");
                    for (int x = 0; x < showbutton.Count; x++)
                    {
                        showbutton[x].Enabled = true;
                        showbutton[x].Text = "";
                    }
                    reference.playerTurn();
                }
                match.Clear();
                showbutton.Clear();
            }
            if (match.Count == 1)
            {
                button.Enabled = false;
            }
            reference.CheckforWinner();

        }


        public muistipeli()
        {
            instance = this;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Generate_board(4);
            Random_button_value();
            reference = new Player();
        }
    }
}
