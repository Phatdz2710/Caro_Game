using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    public class Library
    {
        public static int sizeButtonHeight = 30;
        public static int sizeButtonWidth = 30;

        public static int BoardHeight = 20;
        public static int BoardWidth = 20;

        public static int sizePanelHeight = BoardHeight * sizeButtonHeight;
        public static int sizePanelWidth = BoardWidth * sizeButtonWidth;

        public static string chessmanX = "X";
        public static string chessmanO = "O";

        public static Font fontXO = new Font("Unispace", 12, FontStyle.Bold);
    }
}
