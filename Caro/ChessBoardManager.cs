using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public List<Player> playerList;
        public List<Player> PlayerList { 
            get { return playerList; } 
            set { playerList = value; }
        }


        private int currentPlayer;
        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        private Label turnX;
        private Label turnO;

        public Label TurnX
        {
            get { return turnX; }
            set { turnX = value; }
        }

        public Label TurnO
        {
            get { return turnO; }
            set { turnO = value; }
        }

        public Label pointX;
        public Label pointO;
        public Label PointX { get { return pointX; } set { pointX = value; }  }
        public Label PointO { get { return pointO; } set { pointO = value; } }



        public List<List<Button>> Chess;

        public bool chan2dau;
        public bool Chan2dau { get { return chan2dau; } set { chan2dau = value; } }
        #endregion

        #region Initialize 
        public ChessBoardManager (Panel chessBoard, Label turnX, Label turnO, string NamePlayer1, string NamePlayer2)
        {
            this.ChessBoard = chessBoard;
            this.playerList = new List<Player>()
            {
                new Player(NamePlayer1, Library.chessmanX),
                new Player(NamePlayer2, Library.chessmanO)
            };
            this.TurnO = turnO;
            this.TurnX = turnX;
           currentPlayer = 0;
        }

        public int scoreX = 0;
        public int scoreO = 0;

        public void drawChessBoard()
        {
            Chess = new List<List<Button>>();
            TurnXO setColor = new TurnXO(currentPlayer==1?0:1, TurnX, TurnO);
            setColor.SetColor();

            PointX.Text = scoreX.ToString();
            PointO.Text = scoreO.ToString();

            for (int i = 0; i < Library.BoardHeight; i++)
            {
                Chess.Add(new List<Button>());
                for (int j = 0; j < Library.BoardWidth; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Library.sizeButtonWidth,
                        Height = Library.sizeButtonHeight,
                        Location = new Point(j * Library.sizeButtonWidth, i * Library.sizeButtonHeight),
                        FlatStyle = FlatStyle.Flat,
                        Font = Library.fontXO,
                        Tag = i.ToString(),
                    };
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);


                    Chess[i].Add(btn);
                }
            }
        }

        public void Rematch()
        {
            foreach (List<Button> chs in Chess)
            {
                foreach(Button btn in chs)
                {
                    btn.Text = string.Empty;
                    btn.BackColor = Color.White;
                }
            }
            chessUndo.Clear();
        }
        #endregion

        #region Undo

        Stack<Button> chessUndo = new Stack<Button>();
        public void UndoChess()
        {
            if (chessUndo.Count > 0)
            { 
                TurnXO setColor = new TurnXO(currentPlayer, TurnX, TurnO);
                setColor.SetColor();
                currentPlayer = currentPlayer == 1 ? 0 : 1;
                Button btn = chessUndo.Pop();
                btn.Text = string.Empty;
            }
        }

        #endregion

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Chess[vertical].IndexOf(btn);
            Point point = new Point() { X = horizontal, Y = vertical };
            return point;
        }

        #region CHECKWIN 

        
        private bool isMainDiagonal (Button btn)
        {
            Point point = GetChessPoint(btn);
            int count = 0;
            int i = 0;
            
            bool left = true;
            bool right = true;
            string sleft = string.Empty;
            string sright = string.Empty;
            while (left == true || right == true)
            {
                i++;
                if (point.X + i >= Library.BoardWidth || point.Y + i >= Library.BoardHeight
                    || Chess[point.Y + i][point.X + i].Text != btn.Text) 
                 
                    left = false;
                    
                
                if (point.X - i < 0 || point.Y - i < 0
                    || Chess[point.Y - i][point.X - i].Text != btn.Text)
                
                    right = false;


                if (left) { count++; }
                if (right) { count++;  }


            }
            if (count >= 4) {   return true; } 
            return false;
        }

        private bool isSecondDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int count = 0;
            int i = 0;
            bool left = true;
            bool right = true;
            while (left == true || right == true)
            {
                i++;
                if (point.X + i >= Library.BoardWidth || point.Y - i < 0
                    || Chess[point.Y - i][point.X + i].Text != btn.Text) left = false;
                if (point.X - i < 0 || point.Y + i >= Library.BoardHeight
                    || Chess[point.Y + i][point.X - i].Text != btn.Text) right = false;
                if (left) { count++;  }
                if (right) { count++; }


            }
            if (count >= 4) {  return true; }
            return false;
        }

        private bool isColumn (Button btn)
        {
            Point point = GetChessPoint(btn);
            int count = 0;
            int i = 0;
            bool down = true;
            bool up = true;

            while (down || up)
            {
                i++;
                if (point.Y + i >= Library.BoardHeight || Chess[point.Y + i][point.X].Text != btn.Text)
                    down = false;
                if (point.Y - i < 0 || Chess[point.Y - i][point.X].Text != btn.Text)
                    up = false;
                if (down) { count++;  }
                if (up) { count++; }
            }
            if (count >= 4) {return true; }
            return false;
        }

        private bool isRow (Button btn)
        {
            Point point = GetChessPoint(btn);
            int count = 0;
            int i = 0;
            bool left = true;
            bool right = true;

            while (right || left)
            {
                i++;
                if (point.X + i >= Library.BoardWidth || Chess[point.Y][point.X + i].Text != btn.Text)
                    right = false;
                if (point.X - i < 0 || Chess[point.Y][point.X-i].Text != btn.Text)
                    left = false;
                if (left) { count++; }
                if (right) { count++;  }


            }
            if (count >= 4) { return true; }
            return false;
        }


        private bool isMainDiagonal2Dau (Button btn)
        {
            int count = 0;
            int left = 0;
            int right = 0;
            string sRight, sLeft;
            sRight = sLeft = string.Empty;
            Point point = GetChessPoint(btn);

            while(point.X + right + 1<= Library.BoardWidth && point.Y + right + 1<= Library.BoardHeight)
            {
                right++;
                if (Chess[point.Y + right][point.X + right].Text == btn.Text) { count++;  }
                else { sRight = Chess[point.Y + right][point.X + right].Text; break; }
            }
            while (point.X - left - 1 >= 0 && point.Y - left - 1 >= 0)
            {
                left++;
                if (Chess[point.Y - left][point.X - left].Text == btn.Text) count++;
                else { sLeft = Chess[point.Y - left][point.X - left].Text; break; }
            }

            if (count == 4)
            {
                if (sLeft == string.Empty || sRight == string.Empty) return true;
            } else if (count > 4)
            {
                return true;
            }
            return false;
        }
        private bool isSecondDiagonal2Dau(Button btn)
        {
            int count = 0;
            int left = 0;
            int right = 0;
            string sRight, sLeft;
            sRight = sLeft = string.Empty;
            Point point = GetChessPoint(btn);

            while (point.X + right + 1 <= Library.BoardWidth && point.Y - right - 1 >= 0)
            {
                right++;
                if (Chess[point.Y - right][point.X + right].Text == btn.Text) count++;
                else { sRight = Chess[point.Y - right][point.X + right].Text; break; }
            }
            while (point.X - left - 1 >= 0 && point.Y + left + 1 >= 0)
            {
                left++;
                if (Chess[point.Y + left][point.X - left].Text == btn.Text) count++;
                else { sLeft = Chess[point.Y + left][point.X - left].Text; break; }
            }

            if (count == 4)
            {
                if (sLeft == string.Empty || sRight == string.Empty) return true;
            }
            else if (count > 4)
            {
                return true;
            }
            return false;
        }

        private bool isColumn2Dau(Button btn)
        {
            int count = 0;
            int up = 0;
            int down = 0;
            string sDown, sUp;
            sDown = sUp = string.Empty;
            Point point = GetChessPoint(btn);

            while (point.Y - up - 1 >= 0)
            {
                up++;
                if (Chess[point.Y - up][point.X].Text == btn.Text) count++;
                else { sUp = Chess[point.Y - up][point.X].Text; break; }
            }
            while (point.Y + down + 1 >= 0)
            {
                down++;
                if (Chess[point.Y + down][point.X].Text == btn.Text) count++;
                else { sDown = Chess[point.Y + down][point.X].Text; break; }
            }

            if (count == 4)
            {
                if (sDown == string.Empty || sUp == string.Empty) return true;
            }
            else if (count > 4)
            {
                return true;
            }
            return false;
        }

        private bool isRow2Dau(Button btn)
        {
            int count = 0;
            int left = 0;
            int right = 0;
            string sRight, sLeft;
            sRight = sLeft = string.Empty;
            Point point = GetChessPoint(btn);

            while (point.X + right + 1 <= Library.BoardWidth)
            {
                right++;
                if (Chess[point.Y][point.X + right].Text == btn.Text) count++;
                else { sRight = Chess[point.Y][point.X + right].Text; break; }
            }
            while (point.X - left - 1 >= 0)
            {
                left++;
                if (Chess[point.Y][point.X - left].Text == btn.Text) count++;
                else { sLeft = Chess[point.Y][point.X - left].Text; break; }
            }

            if (count == 4)
            {
                if (sLeft == string.Empty || sRight == string.Empty) return true;
            }
            else if (count > 4)
            {
                return true;
            }
            return false;
        }

        public bool checkWin(Button btn)
        {
            if (!Chan2dau)
            {
                if (isMainDiagonal(btn) || isSecondDiagonal(btn) || isColumn(btn) || isRow(btn))
                    return true;
            } else
            {
                if (isMainDiagonal2Dau(btn) || isSecondDiagonal2Dau(btn) || isRow2Dau(btn) || isColumn2Dau(btn))
                    return true;
            }
            return false;
        }

        #endregion

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == string.Empty)
            {
                TurnXO setColor = new TurnXO(currentPlayer, TurnX, TurnO);
                setColor.SetColor();
                
                btn.Text = playerList[currentPlayer].ChessMan;
                btn.ForeColor = playerList[currentPlayer].ColorChessman;
                currentPlayer = currentPlayer == 1 ? 0 : 1;
                Point point = GetChessPoint(btn);
                chessUndo.Push(btn);
                if (checkWin(btn)) { 
                    MessageBox.Show(btn.Text + " WIN", "Congratulation"); 
                    Rematch();
                    if (currentPlayer == 1) scoreX++; else scoreO++;
                    PointX.Text = scoreX.ToString();
                    PointO.Text = scoreO.ToString();
                }
            }
           
        }
    }
}
