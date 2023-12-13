namespace Caro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBoard = new Panel();
            pnlTurnX = new Panel();
            lblPlayer1 = new Label();
            lblChessX = new Label();
            pnlTurnO = new Panel();
            lblPlayer2 = new Label();
            lblChessO = new Label();
            pnlOption = new Panel();
            label10 = new Label();
            lblSecond = new Label();
            lblMinutes = new Label();
            lblTime = new Label();
            btnResetScore = new Button();
            lblScore2 = new Label();
            lblScore1 = new Label();
            lblScoreBoard = new Label();
            lblPlayer2Score = new Label();
            lblPlayer1Score = new Label();
            btnUndo = new Button();
            imageList1 = new ImageList(components);
            btnRematch = new Button();
            pnlTurnX.SuspendLayout();
            pnlTurnO.SuspendLayout();
            pnlOption.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.ControlLightLight;
            pnlChessBoard.Location = new Point(16, 10);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(813, 643);
            pnlChessBoard.TabIndex = 0;
            pnlChessBoard.Paint += panel1_Paint;
            // 
            // pnlTurnX
            // 
            pnlTurnX.BackColor = Color.MistyRose;
            pnlTurnX.Controls.Add(lblPlayer1);
            pnlTurnX.Controls.Add(lblChessX);
            pnlTurnX.Location = new Point(831, 9);
            pnlTurnX.Name = "pnlTurnX";
            pnlTurnX.Size = new Size(168, 165);
            pnlTurnX.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayer1.ForeColor = Color.Crimson;
            lblPlayer1.Location = new Point(4, 8);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(86, 25);
            lblPlayer1.TabIndex = 2;
            lblPlayer1.Text = "Xin chào";
            // 
            // lblChessX
            // 
            lblChessX.Dock = DockStyle.Fill;
            lblChessX.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblChessX.ForeColor = Color.Red;
            lblChessX.Location = new Point(0, 0);
            lblChessX.Name = "lblChessX";
            lblChessX.Size = new Size(168, 165);
            lblChessX.TabIndex = 0;
            lblChessX.Text = "X";
            lblChessX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTurnO
            // 
            pnlTurnO.BackColor = Color.FromArgb(192, 255, 192);
            pnlTurnO.Controls.Add(lblPlayer2);
            pnlTurnO.Controls.Add(lblChessO);
            pnlTurnO.Location = new Point(1005, 9);
            pnlTurnO.Name = "pnlTurnO";
            pnlTurnO.Size = new Size(168, 165);
            pnlTurnO.TabIndex = 2;
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayer2.ForeColor = Color.SeaGreen;
            lblPlayer2.Location = new Point(3, 8);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(86, 25);
            lblPlayer2.TabIndex = 3;
            lblPlayer2.Text = "Xin chào";
            // 
            // lblChessO
            // 
            lblChessO.Dock = DockStyle.Fill;
            lblChessO.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblChessO.ForeColor = Color.Lime;
            lblChessO.Location = new Point(0, 0);
            lblChessO.Name = "lblChessO";
            lblChessO.Size = new Size(168, 165);
            lblChessO.TabIndex = 0;
            lblChessO.Text = "O";
            lblChessO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOption
            // 
            pnlOption.Controls.Add(label10);
            pnlOption.Controls.Add(lblSecond);
            pnlOption.Controls.Add(lblMinutes);
            pnlOption.Controls.Add(lblTime);
            pnlOption.Controls.Add(btnResetScore);
            pnlOption.Controls.Add(lblScore2);
            pnlOption.Controls.Add(lblScore1);
            pnlOption.Controls.Add(lblScoreBoard);
            pnlOption.Controls.Add(lblPlayer2Score);
            pnlOption.Controls.Add(lblPlayer1Score);
            pnlOption.Controls.Add(btnUndo);
            pnlOption.Controls.Add(btnRematch);
            pnlOption.ForeColor = Color.RoyalBlue;
            pnlOption.Location = new Point(835, 180);
            pnlOption.Name = "pnlOption";
            pnlOption.Size = new Size(350, 451);
            pnlOption.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(178, 136);
            label10.Name = "label10";
            label10.Size = new Size(25, 41);
            label10.TabIndex = 12;
            label10.Text = ":";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecond.Location = new Point(195, 138);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(50, 41);
            lblSecond.TabIndex = 11;
            lblSecond.Text = "00";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMinutes.Location = new Point(138, 138);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(50, 41);
            lblMinutes.TabIndex = 10;
            lblMinutes.Text = "00";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.DarkSlateGray;
            lblTime.Location = new Point(27, 141);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 38);
            lblTime.TabIndex = 9;
            lblTime.Text = "TIME: ";
            // 
            // btnResetScore
            // 
            btnResetScore.BackColor = SystemColors.GradientInactiveCaption;
            btnResetScore.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetScore.ForeColor = Color.DarkSlateGray;
            btnResetScore.ImageIndex = 0;
            btnResetScore.Location = new Point(271, 49);
            btnResetScore.Name = "btnResetScore";
            btnResetScore.Size = new Size(63, 50);
            btnResetScore.TabIndex = 8;
            btnResetScore.Text = "Reset";
            btnResetScore.UseVisualStyleBackColor = false;
            btnResetScore.Click += btnResetScore_Click;
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.BackColor = Color.White;
            lblScore2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore2.ForeColor = Color.FromArgb(0, 192, 0);
            lblScore2.Location = new Point(147, 79);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(97, 28);
            lblScore2.TabIndex = 7;
            lblScore2.Text = "Xin chào";
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.BackColor = Color.White;
            lblScore1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore1.ForeColor = Color.Crimson;
            lblScore1.Location = new Point(147, 40);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(97, 28);
            lblScore1.TabIndex = 6;
            lblScore1.Text = "Xin chào";
            // 
            // lblScoreBoard
            // 
            lblScoreBoard.AutoSize = true;
            lblScoreBoard.BackColor = Color.PowderBlue;
            lblScoreBoard.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblScoreBoard.ForeColor = Color.MidnightBlue;
            lblScoreBoard.Location = new Point(3, 3);
            lblScoreBoard.Name = "lblScoreBoard";
            lblScoreBoard.Size = new Size(122, 25);
            lblScoreBoard.TabIndex = 5;
            lblScoreBoard.Text = "Score Board: ";
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.BackColor = Color.FromArgb(192, 255, 192);
            lblPlayer2Score.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayer2Score.ForeColor = Color.SeaGreen;
            lblPlayer2Score.Location = new Point(12, 79);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(86, 25);
            lblPlayer2Score.TabIndex = 4;
            lblPlayer2Score.Text = "Xin chào";
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.BackColor = Color.MistyRose;
            lblPlayer1Score.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayer1Score.ForeColor = Color.Crimson;
            lblPlayer1Score.Location = new Point(12, 43);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(86, 25);
            lblPlayer1Score.TabIndex = 3;
            lblPlayer1Score.Text = "Xin chào";
            // 
            // btnUndo
            // 
            btnUndo.BackColor = SystemColors.Info;
            btnUndo.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUndo.ForeColor = Color.SaddleBrown;
            btnUndo.ImageIndex = 0;
            btnUndo.ImageList = imageList1;
            btnUndo.Location = new Point(27, 202);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(152, 64);
            btnUndo.TabIndex = 1;
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "reload.png");
            // 
            // btnRematch
            // 
            btnRematch.BackColor = Color.PowderBlue;
            btnRematch.FlatStyle = FlatStyle.Flat;
            btnRematch.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRematch.ForeColor = Color.SteelBlue;
            btnRematch.Location = new Point(27, 307);
            btnRematch.Name = "btnRematch";
            btnRematch.Size = new Size(295, 48);
            btnRematch.TabIndex = 0;
            btnRematch.Text = "Chơi lại";
            btnRematch.UseVisualStyleBackColor = false;
            btnRematch.Click += btnRematch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 660);
            Controls.Add(pnlOption);
            Controls.Add(pnlChessBoard);
            Controls.Add(pnlTurnO);
            Controls.Add(pnlTurnX);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlTurnX.ResumeLayout(false);
            pnlTurnX.PerformLayout();
            pnlTurnO.ResumeLayout(false);
            pnlTurnO.PerformLayout();
            pnlOption.ResumeLayout(false);
            pnlOption.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel pnlTurnX;
        private Label lblChessX;
        private Panel pnlTurnO;
        private Label lblChessO;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Panel pnlOption;
        private Button btnResetScore;
        private Label lblScore2;
        private Label lblScore1;
        private Label lblScoreBoard;
        private Label lblPlayer2Score;
        private Label lblPlayer1Score;
        private Button btnUndo;
        private ImageList imageList1;
        private Button btnRematch;
        private Label label10;
        private Label lblSecond;
        private Label lblMinutes;
        private Label lblTime;
    }
}