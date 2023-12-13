using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    public class Player
    {
        private string name;
        public string Name { 
            get { return name; } 
            set { name = value; } 
        }

        private string chessMan;
        public string ChessMan
        {
            get { return chessMan; } 
            set {  chessMan = value; }
        }

        private Color colorChessman;
        public Color ColorChessman
        {
            get { return colorChessman; }
            set {
                if (ChessMan == Library.chessmanX)
                    colorChessman = Color.Red;
                else if (ChessMan == Library.chessmanO) 
                    colorChessman = Color.Green;              
            }
        }
        public Player(string name, string chessman) 
        {
            this.Name = name;
            this.ChessMan = chessman;
            this.ColorChessman = colorChessman;
             
        }
    }
}
