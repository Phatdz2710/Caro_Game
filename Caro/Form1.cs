using System.Security.Cryptography.X509Certificates;

namespace Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1(string name1, string name2, int time, bool chan2dau)
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, lblChessX, lblChessO, name1, name2);
            ChessBoard.PointX = lblScore1;
            ChessBoard.PointO = lblScore2;
            ChessBoard.Chan2dau = chan2dau;
            ChessBoard.drawChessBoard();
            name[0] = name1;
            name[1] = name2;
            
        }


        private string[] name = new string[2];


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlChessBoard.Width = Library.sizePanelWidth;
            pnlChessBoard.Height = Library.sizePanelHeight;

            lblPlayer1.Text = name[0];
            lblPlayer2.Text = name[1];
            lblPlayer1Score.Text = name[0];
            lblPlayer2Score.Text = name[1];

            pnlTurnX.Location = new Point(Library.sizePanelHeight + 30, 20);
            pnlTurnO.Location = new Point(Library.sizePanelHeight + pnlTurnX.Height + 40, 20);

            pnlOption.Location = new Point(Library.sizePanelHeight + 30, pnlTurnX.Location.Y + pnlTurnX.Width);
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thiết lập lại số điểm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ChessBoard.scoreX = 0;
                ChessBoard.scoreO = 0;

                lblScore1.Text = "0";
                lblScore2.Text = "0";
            }
        }

        private void btnRematch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn chơi lại ván này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ChessBoard.Rematch();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ChessBoard.UndoChess();
        }
    }
}