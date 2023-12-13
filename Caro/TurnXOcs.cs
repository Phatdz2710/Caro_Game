using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    public class TurnXO
    {
        private Label turnX;
        private Label turnO;

        public Label TurnX {
            get { return turnX; }
            set { turnX = value; }
        }

        public Label TurnO
        {
            get { return turnO; }
            set { turnO = value;}
        }



        private int currentPlayer;
        public int CurrentPlayer { get { return currentPlayer; } set { currentPlayer = value; } }


        public TurnXO(int currentPlayer, Label turnX, Label turnO)
        {
            this.CurrentPlayer = currentPlayer;
            this.TurnX = turnX;
            this.TurnO = turnO;
        }

        public void SetColor()
        {
            if (CurrentPlayer == 1)
            {
                turnX.ForeColor = TurnX_ForeColor;
                turnX.BackColor = TurnX_BackColor;
                turnO.ForeColor = Off_ForeColor;
                turnO.BackColor = Off_BackColor;
            } 
            else 
            {
                turnO.ForeColor = TurnO_ForeColor;
                turnO.BackColor = TurnO_BackColor;
                turnX.ForeColor = Off_ForeColor;
                turnX.BackColor = Off_BackColor;
            }
        }

        private Color TurnX_ForeColor = Color.Red;
        private Color TurnX_BackColor = Color.MistyRose;
        private Color TurnO_ForeColor = Color.Green;
        private Color TurnO_BackColor = Color.FromArgb(192, 255, 192);

        private Color Off_ForeColor = Color.Black;
        private Color Off_BackColor = Color.Gray;

    }
}
