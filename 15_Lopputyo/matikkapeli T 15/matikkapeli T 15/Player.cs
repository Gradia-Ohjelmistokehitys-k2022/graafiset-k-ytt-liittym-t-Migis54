using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace matikkapeli_T_15
{
    public class Player
    {
        bool player = true;
        //points
        int p1p;
        int p2p;
        public void CheckforWinner()
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
        public void playerTurn()
        {
            if (player == true)
            {
                player = false;
                muistipeli.instance.label6.Text = "pelaajan 2 vuoro";

            }
            else
            {
                player = true;
                muistipeli.instance.label6.Text = "pelaajan 1 vuoro";
            }
        }
        public void playerPoints()
        {
            if (player == true)
            {
                p1p++;
                muistipeli.instance.label3.Text = p1p.ToString();
            }
            else
            {
                p2p++;
                muistipeli.instance.label4.Text = p2p.ToString();
            }
        }

    }
}
